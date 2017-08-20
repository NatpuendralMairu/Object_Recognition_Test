using System;
using System.Drawing;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;

namespace Object_Recognition_Test
{
    public partial class ObjRecognition : MetroFramework.Forms.MetroForm
    {
        Capture capwebcam = null;
        bool BlnCapturingInProcess = false;
        Image<Bgr, Byte> imgOriginal;
        Image<Gray, Byte> imgProcessed;

        public ObjRecognition()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                capwebcam = new Capture();
            }
            catch (NullReferenceException except)
            {
                txtXYRadius.Text = except.Message;
                return;
            }
            Application.Idle += processFrameAndUpdateGUI;
            BlnCapturingInProcess = true;
        }

        #region PROCESS FRAME AND UPDATE GUI
        private void processFrameAndUpdateGUI(object sender, EventArgs e)
        {

            imgOriginal = capwebcam.QueryFrame().ToImage<Bgr, Byte>();

            if (imgOriginal == null) return;

            imgProcessed = imgOriginal.InRange(new Bgr(0, 0, 175),
                                                new Bgr(100, 100, 256));

            imgProcessed = imgProcessed.SmoothGaussian(9);
            CircleF[] circles = imgProcessed.HoughCircles(new Gray(100),
                                                          new Gray(50),
                                                           2,
                                                           imgProcessed.Height / 4,
                                                           10,
                                                           400)[0];

            foreach (CircleF circle in circles)
            {
                if (txtXYRadius.Text == "") txtXYRadius.AppendText(Environment.NewLine);
                txtXYRadius.AppendText("ball position = x" + circle.Center.X.ToString().PadLeft(4) +
                    ", y =" + circle.Center.Y.ToString().PadLeft(4) +
                    ", radius = " + circle.Radius.ToString("###.000").PadLeft(7));

                txtXYRadius.ScrollToCaret();

                CvInvoke.Circle(imgOriginal,
                                new Point((int)circle.Center.X
                                , (int)circle.Center.Y),
                                3,
                                new MCvScalar(0, 255, 0),
                                1,
                                LineType.EightConnected,
                                0);

                imgOriginal.Draw(circle,
                                 new Bgr(Color.Red),
                                 3);
            }

            IbOriginal.Image = imgOriginal;
            IbProcessed.Image = imgProcessed;
        }
        #endregion

        private void btnPauseOrResume_Click(object sender, EventArgs e)
        {
            if (BlnCapturingInProcess == true)
            {
                Application.Idle -= processFrameAndUpdateGUI;
                BlnCapturingInProcess = false;
                btnPauseOrResume.Text = "Resume";
            }
            else
            {
                Application.Idle += processFrameAndUpdateGUI;
                BlnCapturingInProcess = true;
                btnPauseOrResume.Text = "Pause";
            }
        }
    }
}
