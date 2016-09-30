namespace Custom_Crosshair_Overlay
{
    partial class Form1
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
            this.crossHairPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.crossHairPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // crossHairPictureBox
            // 
            this.crossHairPictureBox.Image = global::Custom_Crosshair_Overlay.Properties.Resources.juuzou;
            this.crossHairPictureBox.Location = new System.Drawing.Point(12, 22);
            this.crossHairPictureBox.Name = "crossHairPictureBox";
            this.crossHairPictureBox.Size = new System.Drawing.Size(64, 64);
            this.crossHairPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.crossHairPictureBox.TabIndex = 0;
            this.crossHairPictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(64, 64);
            this.Controls.Add(this.crossHairPictureBox);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.crossHairPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox crossHairPictureBox;
    }
}

