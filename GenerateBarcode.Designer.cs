namespace BarcodeSystem
{
    partial class GenerateBarcode
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
            this.ButtonEncode = new System.Windows.Forms.Button();
            this.LabelEncode = new System.Windows.Forms.Label();
            this.BarcodePictureBox = new System.Windows.Forms.PictureBox();
            this.TextBoxEncode = new System.Windows.Forms.TextBox();
            this.TextBoxDecode = new System.Windows.Forms.TextBox();
            this.ButtonDecode = new System.Windows.Forms.Button();
            this.LabelDecode = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.menuStripGenerateBarcode = new System.Windows.Forms.MenuStrip();
            this.readBarcodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePictureBox)).BeginInit();
            this.menuStripGenerateBarcode.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonEncode
            // 
            this.ButtonEncode.Location = new System.Drawing.Point(97, 345);
            this.ButtonEncode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonEncode.Name = "ButtonEncode";
            this.ButtonEncode.Size = new System.Drawing.Size(103, 28);
            this.ButtonEncode.TabIndex = 0;
            this.ButtonEncode.Text = "Encode";
            this.ButtonEncode.UseVisualStyleBackColor = true;
            this.ButtonEncode.Click += new System.EventHandler(this.ButtonEncode_Click);
            // 
            // LabelEncode
            // 
            this.LabelEncode.AutoSize = true;
            this.LabelEncode.Location = new System.Drawing.Point(5, 254);
            this.LabelEncode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelEncode.Name = "LabelEncode";
            this.LabelEncode.Size = new System.Drawing.Size(60, 17);
            this.LabelEncode.TabIndex = 1;
            this.LabelEncode.Text = "Encode:";
            // 
            // BarcodePictureBox
            // 
            this.BarcodePictureBox.BackColor = System.Drawing.Color.White;
            this.BarcodePictureBox.Location = new System.Drawing.Point(9, 33);
            this.BarcodePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarcodePictureBox.Name = "BarcodePictureBox";
            this.BarcodePictureBox.Size = new System.Drawing.Size(561, 197);
            this.BarcodePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BarcodePictureBox.TabIndex = 2;
            this.BarcodePictureBox.TabStop = false;
            // 
            // TextBoxEncode
            // 
            this.TextBoxEncode.Location = new System.Drawing.Point(76, 254);
            this.TextBoxEncode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxEncode.Name = "TextBoxEncode";
            this.TextBoxEncode.Size = new System.Drawing.Size(493, 22);
            this.TextBoxEncode.TabIndex = 3;
            // 
            // TextBoxDecode
            // 
            this.TextBoxDecode.Location = new System.Drawing.Point(76, 295);
            this.TextBoxDecode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextBoxDecode.Name = "TextBoxDecode";
            this.TextBoxDecode.Size = new System.Drawing.Size(493, 22);
            this.TextBoxDecode.TabIndex = 5;
            // 
            // ButtonDecode
            // 
            this.ButtonDecode.Location = new System.Drawing.Point(205, 345);
            this.ButtonDecode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonDecode.Name = "ButtonDecode";
            this.ButtonDecode.Size = new System.Drawing.Size(103, 28);
            this.ButtonDecode.TabIndex = 6;
            this.ButtonDecode.Text = "Decode";
            this.ButtonDecode.UseVisualStyleBackColor = true;
            this.ButtonDecode.Click += new System.EventHandler(this.ButtonDecode_Click);
            // 
            // LabelDecode
            // 
            this.LabelDecode.AutoSize = true;
            this.LabelDecode.Location = new System.Drawing.Point(5, 299);
            this.LabelDecode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelDecode.Name = "LabelDecode";
            this.LabelDecode.Size = new System.Drawing.Size(61, 17);
            this.LabelDecode.TabIndex = 7;
            this.LabelDecode.Text = "Decode:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(313, 345);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(103, 28);
            this.ButtonSave.TabIndex = 8;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Location = new System.Drawing.Point(421, 345);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(103, 28);
            this.ButtonReset.TabIndex = 9;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // menuStripGenerateBarcode
            // 
            this.menuStripGenerateBarcode.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripGenerateBarcode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.readBarcodeToolStripMenuItem});
            this.menuStripGenerateBarcode.Location = new System.Drawing.Point(0, 0);
            this.menuStripGenerateBarcode.Name = "menuStripGenerateBarcode";
            this.menuStripGenerateBarcode.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStripGenerateBarcode.Size = new System.Drawing.Size(581, 28);
            this.menuStripGenerateBarcode.TabIndex = 10;
            this.menuStripGenerateBarcode.Text = "menuStripGenerateBarcode";
            // 
            // readBarcodeToolStripMenuItem
            // 
            this.readBarcodeToolStripMenuItem.ForeColor = System.Drawing.Color.Blue;
            this.readBarcodeToolStripMenuItem.Name = "readBarcodeToolStripMenuItem";
            this.readBarcodeToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.readBarcodeToolStripMenuItem.Text = "Read Barcode";
            this.readBarcodeToolStripMenuItem.Click += new System.EventHandler(this.readBarcodeToolStripMenuItem_Click);
            // 
            // GenerateBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 388);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelDecode);
            this.Controls.Add(this.ButtonDecode);
            this.Controls.Add(this.TextBoxDecode);
            this.Controls.Add(this.TextBoxEncode);
            this.Controls.Add(this.BarcodePictureBox);
            this.Controls.Add(this.LabelEncode);
            this.Controls.Add(this.ButtonEncode);
            this.Controls.Add(this.menuStripGenerateBarcode);
            this.MainMenuStrip = this.menuStripGenerateBarcode;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GenerateBarcode";
            this.Text = "Generate Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.BarcodePictureBox)).EndInit();
            this.menuStripGenerateBarcode.ResumeLayout(false);
            this.menuStripGenerateBarcode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonEncode;
        private System.Windows.Forms.Label LabelEncode;
        private System.Windows.Forms.PictureBox BarcodePictureBox;
        private System.Windows.Forms.TextBox TextBoxEncode;
        private System.Windows.Forms.TextBox TextBoxDecode;
        private System.Windows.Forms.Button ButtonDecode;
        private System.Windows.Forms.Label LabelDecode;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.MenuStrip menuStripGenerateBarcode;
        private System.Windows.Forms.ToolStripMenuItem readBarcodeToolStripMenuItem;
    }
}

