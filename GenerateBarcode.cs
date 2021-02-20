using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;

namespace BarcodeSystem
{
    public partial class GenerateBarcode : Form
    {
        public GenerateBarcode()
        {
            InitializeComponent();
        }
        SaveFileDialog SaveBarcode; //Untuk save barcode in png format
        private void ButtonEncode_Click(object sender, EventArgs e)
        {
            BarcodeWriter Writer = new BarcodeWriter { Format = BarcodeFormat.CODE_128 };
            BarcodePictureBox.Image = Writer.Write(TextBoxEncode.Text);
        }
        private void ButtonDecode_Click(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            var Result = Reader.Decode((Bitmap)BarcodePictureBox.Image);
            if (Result != null)
                TextBoxDecode.Text = Result.Text;
        }
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            SaveBarcode = new SaveFileDialog();
            SaveBarcode.Filter = "PNG File|*.png";
            if (SaveBarcode.ShowDialog() == DialogResult.OK)
                BarcodePictureBox.Image.Save(SaveBarcode.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }
        private void ButtonReset_Click(object sender, EventArgs e)
        {
            BarcodePictureBox.Image = null;
            TextBoxEncode.Text = null;
            TextBoxDecode.Text = null;
        }
        private void readBarcodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReadBarcode RB = new ReadBarcode();
            RB.ShowDialog();
        }
    }
}
