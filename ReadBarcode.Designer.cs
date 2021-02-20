namespace BarcodeSystem
{
    partial class ReadBarcode
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
            this.BarcodePictureBox = new System.Windows.Forms.PictureBox();
            this.ButtonOpenFile = new System.Windows.Forms.Button();
            this.LabelBarcode = new System.Windows.Forms.Label();
            this.TextBoxBarcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BarcodePictureBox
            // 
            this.BarcodePictureBox.BackColor = System.Drawing.Color.White;
            this.BarcodePictureBox.Location = new System.Drawing.Point(12, 12);
            this.BarcodePictureBox.Name = "BarcodePictureBox";
            this.BarcodePictureBox.Size = new System.Drawing.Size(362, 125);
            this.BarcodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BarcodePictureBox.TabIndex = 1;
            this.BarcodePictureBox.TabStop = false;
            // 
            // ButtonOpenFile
            // 
            this.ButtonOpenFile.Location = new System.Drawing.Point(299, 155);
            this.ButtonOpenFile.Name = "ButtonOpenFile";
            this.ButtonOpenFile.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpenFile.TabIndex = 2;
            this.ButtonOpenFile.Text = "Open File";
            this.ButtonOpenFile.UseVisualStyleBackColor = true;
            this.ButtonOpenFile.Click += new System.EventHandler(this.ButtonOpenFile_Click);
            // 
            // LabelBarcode
            // 
            this.LabelBarcode.AutoSize = true;
            this.LabelBarcode.Location = new System.Drawing.Point(12, 187);
            this.LabelBarcode.Name = "LabelBarcode";
            this.LabelBarcode.Size = new System.Drawing.Size(50, 13);
            this.LabelBarcode.TabIndex = 3;
            this.LabelBarcode.Text = "Barcode:";
            // 
            // TextBoxBarcode
            // 
            this.TextBoxBarcode.Location = new System.Drawing.Point(66, 184);
            this.TextBoxBarcode.Name = "TextBoxBarcode";
            this.TextBoxBarcode.Size = new System.Drawing.Size(308, 20);
            this.TextBoxBarcode.TabIndex = 4;
            // 
            // ReadBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 213);
            this.Controls.Add(this.TextBoxBarcode);
            this.Controls.Add(this.LabelBarcode);
            this.Controls.Add(this.ButtonOpenFile);
            this.Controls.Add(this.BarcodePictureBox);
            this.Name = "ReadBarcode";
            this.Text = "ReadBarcode";
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox BarcodePictureBox;
        private System.Windows.Forms.Button ButtonOpenFile;
        private System.Windows.Forms.Label LabelBarcode;
        private System.Windows.Forms.TextBox TextBoxBarcode;
    }
}