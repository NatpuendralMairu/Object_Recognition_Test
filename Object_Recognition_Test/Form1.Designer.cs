namespace Object_Recognition_Test
{
    partial class ObjRecognition
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.IbOriginal = new Emgu.CV.UI.ImageBox();
            this.IbProcessed = new Emgu.CV.UI.ImageBox();
            this.btnPauseOrResume = new MetroFramework.Controls.MetroButton();
            this.txtXYRadius = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.IbOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IbProcessed)).BeginInit();
            this.SuspendLayout();
            // 
            // IbOriginal
            // 
            this.IbOriginal.Location = new System.Drawing.Point(23, 63);
            this.IbOriginal.Name = "IbOriginal";
            this.IbOriginal.Size = new System.Drawing.Size(335, 230);
            this.IbOriginal.TabIndex = 2;
            this.IbOriginal.TabStop = false;
            // 
            // IbProcessed
            // 
            this.IbProcessed.Location = new System.Drawing.Point(377, 63);
            this.IbProcessed.Name = "IbProcessed";
            this.IbProcessed.Size = new System.Drawing.Size(335, 230);
            this.IbProcessed.TabIndex = 2;
            this.IbProcessed.TabStop = false;
            // 
            // btnPauseOrResume
            // 
            this.btnPauseOrResume.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnPauseOrResume.Location = new System.Drawing.Point(95, 341);
            this.btnPauseOrResume.Name = "btnPauseOrResume";
            this.btnPauseOrResume.Size = new System.Drawing.Size(118, 43);
            this.btnPauseOrResume.Style = MetroFramework.MetroColorStyle.Teal;
            this.btnPauseOrResume.TabIndex = 3;
            this.btnPauseOrResume.Text = "Pause";
            this.btnPauseOrResume.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPauseOrResume.UseSelectable = true;
            this.btnPauseOrResume.Click += new System.EventHandler(this.btnPauseOrResume_Click);
            // 
            // txtXYRadius
            // 
            this.txtXYRadius.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXYRadius.ForeColor = System.Drawing.Color.Navy;
            this.txtXYRadius.Location = new System.Drawing.Point(268, 312);
            this.txtXYRadius.Multiline = true;
            this.txtXYRadius.Name = "txtXYRadius";
            this.txtXYRadius.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXYRadius.Size = new System.Drawing.Size(444, 101);
            this.txtXYRadius.TabIndex = 4;
            // 
            // ObjRecognition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 426);
            this.Controls.Add(this.txtXYRadius);
            this.Controls.Add(this.btnPauseOrResume);
            this.Controls.Add(this.IbProcessed);
            this.Controls.Add(this.IbOriginal);
            this.Name = "ObjRecognition";
            this.Text = "OBJECT RECOGNITION";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IbOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IbProcessed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox IbOriginal;
        private Emgu.CV.UI.ImageBox IbProcessed;
        private MetroFramework.Controls.MetroButton btnPauseOrResume;
        private System.Windows.Forms.TextBox txtXYRadius;
    }
}

