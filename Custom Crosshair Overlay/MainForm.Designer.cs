namespace Custom_Crosshair_Overlay
{
    partial class MainForm
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
            this.processesWithWindowComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crosshairURLTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addCrosshairByURLButton = new System.Windows.Forms.Button();
            this.useLocalImageButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.crosshairFileLocationTextBox = new System.Windows.Forms.TextBox();
            this.activateButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.crosshairSizeSpinner = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.adjustXspinner = new System.Windows.Forms.NumericUpDown();
            this.adjustYspinner = new System.Windows.Forms.NumericUpDown();
            this.browseLocalImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.browseFileButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.crosshairSizeSpinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustXspinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustYspinner)).BeginInit();
            this.SuspendLayout();
            // 
            // processesWithWindowComboBox
            // 
            this.processesWithWindowComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processesWithWindowComboBox.FormattingEnabled = true;
            this.processesWithWindowComboBox.Location = new System.Drawing.Point(133, 118);
            this.processesWithWindowComboBox.Name = "processesWithWindowComboBox";
            this.processesWithWindowComboBox.Size = new System.Drawing.Size(233, 21);
            this.processesWithWindowComboBox.TabIndex = 0;
            this.processesWithWindowComboBox.DropDown += new System.EventHandler(this.processesWithWindowComboBox_DropDown);
            this.processesWithWindowComboBox.SelectedIndexChanged += new System.EventHandler(this.processesWithWindowComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Window to Overlay";
            // 
            // crosshairURLTextBox
            // 
            this.crosshairURLTextBox.Location = new System.Drawing.Point(133, 51);
            this.crosshairURLTextBox.Name = "crosshairURLTextBox";
            this.crosshairURLTextBox.Size = new System.Drawing.Size(233, 20);
            this.crosshairURLTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crosshair URL";
            // 
            // addCrosshairByURLButton
            // 
            this.addCrosshairByURLButton.Enabled = false;
            this.addCrosshairByURLButton.Location = new System.Drawing.Point(133, 12);
            this.addCrosshairByURLButton.Name = "addCrosshairByURLButton";
            this.addCrosshairByURLButton.Size = new System.Drawing.Size(109, 23);
            this.addCrosshairByURLButton.TabIndex = 4;
            this.addCrosshairByURLButton.Text = "Use URL";
            this.addCrosshairByURLButton.UseVisualStyleBackColor = true;
            this.addCrosshairByURLButton.Click += new System.EventHandler(this.addCrosshairByURLButton_Click);
            // 
            // useLocalImageButton
            // 
            this.useLocalImageButton.Location = new System.Drawing.Point(257, 12);
            this.useLocalImageButton.Name = "useLocalImageButton";
            this.useLocalImageButton.Size = new System.Drawing.Size(109, 23);
            this.useLocalImageButton.TabIndex = 5;
            this.useLocalImageButton.Text = "Use Local Image";
            this.useLocalImageButton.UseVisualStyleBackColor = true;
            this.useLocalImageButton.Click += new System.EventHandler(this.useLocalImageButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Crosshair File Location";
            // 
            // crosshairFileLocationTextBox
            // 
            this.crosshairFileLocationTextBox.Enabled = false;
            this.crosshairFileLocationTextBox.Location = new System.Drawing.Point(133, 84);
            this.crosshairFileLocationTextBox.Name = "crosshairFileLocationTextBox";
            this.crosshairFileLocationTextBox.Size = new System.Drawing.Size(163, 20);
            this.crosshairFileLocationTextBox.TabIndex = 7;
            // 
            // activateButton
            // 
            this.activateButton.Location = new System.Drawing.Point(133, 159);
            this.activateButton.Name = "activateButton";
            this.activateButton.Size = new System.Drawing.Size(233, 45);
            this.activateButton.TabIndex = 8;
            this.activateButton.Text = "Activate";
            this.activateButton.UseVisualStyleBackColor = true;
            this.activateButton.Click += new System.EventHandler(this.activateButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Crosshair Size";
            // 
            // crosshairSizeSpinner
            // 
            this.crosshairSizeSpinner.Location = new System.Drawing.Point(133, 221);
            this.crosshairSizeSpinner.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.crosshairSizeSpinner.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.crosshairSizeSpinner.Name = "crosshairSizeSpinner";
            this.crosshairSizeSpinner.Size = new System.Drawing.Size(233, 20);
            this.crosshairSizeSpinner.TabIndex = 10;
            this.crosshairSizeSpinner.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.crosshairSizeSpinner.ValueChanged += new System.EventHandler(this.crosshairSizeSpinner_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adjust X Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Adjust Y Location";
            // 
            // adjustXspinner
            // 
            this.adjustXspinner.Location = new System.Drawing.Point(133, 247);
            this.adjustXspinner.Maximum = new decimal(new int[] {
            960,
            0,
            0,
            0});
            this.adjustXspinner.Minimum = new decimal(new int[] {
            960,
            0,
            0,
            -2147483648});
            this.adjustXspinner.Name = "adjustXspinner";
            this.adjustXspinner.Size = new System.Drawing.Size(233, 20);
            this.adjustXspinner.TabIndex = 13;
            this.adjustXspinner.ValueChanged += new System.EventHandler(this.adjustXspinner_ValueChanged);
            // 
            // adjustYspinner
            // 
            this.adjustYspinner.Location = new System.Drawing.Point(133, 273);
            this.adjustYspinner.Maximum = new decimal(new int[] {
            540,
            0,
            0,
            0});
            this.adjustYspinner.Minimum = new decimal(new int[] {
            540,
            0,
            0,
            -2147483648});
            this.adjustYspinner.Name = "adjustYspinner";
            this.adjustYspinner.Size = new System.Drawing.Size(233, 20);
            this.adjustYspinner.TabIndex = 14;
            this.adjustYspinner.ValueChanged += new System.EventHandler(this.adjustYspinner_ValueChanged);
            // 
            // browseLocalImageDialog
            // 
            this.browseLocalImageDialog.FileName = "openFileDialog1";
            // 
            // browseFileButton
            // 
            this.browseFileButton.Enabled = false;
            this.browseFileButton.Location = new System.Drawing.Point(302, 82);
            this.browseFileButton.Name = "browseFileButton";
            this.browseFileButton.Size = new System.Drawing.Size(63, 23);
            this.browseFileButton.TabIndex = 15;
            this.browseFileButton.Text = "Browse";
            this.browseFileButton.UseVisualStyleBackColor = true;
            this.browseFileButton.Click += new System.EventHandler(this.browseFileButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 309);
            this.Controls.Add(this.browseFileButton);
            this.Controls.Add(this.adjustYspinner);
            this.Controls.Add(this.adjustXspinner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.crosshairSizeSpinner);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.activateButton);
            this.Controls.Add(this.crosshairFileLocationTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.useLocalImageButton);
            this.Controls.Add(this.addCrosshairByURLButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.crosshairURLTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processesWithWindowComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Custom Crosshair Overlay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.crosshairSizeSpinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustXspinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustYspinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox processesWithWindowComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox crosshairURLTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addCrosshairByURLButton;
        private System.Windows.Forms.Button useLocalImageButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox crosshairFileLocationTextBox;
        private System.Windows.Forms.Button activateButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown crosshairSizeSpinner;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown adjustXspinner;
        private System.Windows.Forms.NumericUpDown adjustYspinner;
        private System.Windows.Forms.OpenFileDialog browseLocalImageDialog;
        private System.Windows.Forms.Button browseFileButton;
    }
}