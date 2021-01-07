using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace Project
{
    public partial class Qr : Form
    {
        private Encryption encry = new Encryption();
        public Qr()
        {
            InitializeComponent();
        }

        private void Qr_Load(object sender, EventArgs e)
        {
            string code = "http://localhost/Website%20Project/Webfiles/Attendance.php?Key="+encry.Encrypt(DateTime.Now.ToString("dd-MM-yyyy")+Variables.User);
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(8);
            this.pictureBox1.Image = qrCodeImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://localhost/Website%20Project/Webfiles/Attendance.php?Key=" + encry.Encrypt(DateTime.Now.ToString("dd-MM-yyyy") + Variables.User));
        }
    }
}
