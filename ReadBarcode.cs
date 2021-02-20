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
    public partial class ReadBarcode : Form
    {
        public ReadBarcode()
        {
            InitializeComponent();
        }

        private void ButtonOpenFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "PNG File|*.png" }) 
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    BarcodePictureBox.Image = Image.FromFile(ofd.FileName);
                    BarcodeReader Reader = new BarcodeReader();
                    var Result = Reader.Decode((Bitmap)BarcodePictureBox.Image);
                    if (Result != null)
                        TextBoxBarcode.Text = Result.ToString();
                }
            }
        }
    }
}
