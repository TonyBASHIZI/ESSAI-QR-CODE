using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;
using ThoughtWorks.QRCode.Codec.Util;
namespace essai_qr_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void QRCode(PictureBox pic_box, string data)
        {

            try
            {
                QRCodeEncoder objQRCode = new QRCodeEncoder();
                Image imgImage;
                objQRCode.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
                //objQRCode.QRCodeScale = 7;
                //objQRCode.QRCodeVersion = 4;
                objQRCode.QRCodeScale = 47;
                objQRCode.QRCodeVersion = 24;
                objQRCode.QRCodeErrorCorrect = ThoughtWorks.QRCode.Codec.QRCodeEncoder.ERROR_CORRECTION.L;
                imgImage = objQRCode.Encode(data);
                pic_box.Image = imgImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                MessageBox.Show("LE CHAMP DE LA MATRICULE EST VIDE");
            }
            else {
                QRCode(pictureBox1, textBox1.Text);
            }
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void initialise()
        {
            pictureBox1.Image.Equals("");
            textBox1.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            initialise();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    
    }
    

}
