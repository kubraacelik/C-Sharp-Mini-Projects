using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ülkeler_ve_Başkentleri_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0;
        int puan = 0;
        int sure = 60;

        private void button5_Click(object sender, EventArgs e)
        {
            sayac++;
            BtnSoru.Text = "Sonraki";
            timer1.Start();

            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSoru.Enabled = false;

            BtnA.BackColor = Color.LightGray;
            BtnB.BackColor = Color.LightGray;
            BtnC.BackColor = Color.LightGray;
            BtnD.BackColor = Color.LightGray;

            if (sayac == 1)
            {
                label1.Text = "Türkiye";
                BtnA.Text = "İstanbul";
                BtnB.Text = "İzmir";
                BtnC.Text = "Ankara";
                BtnD.Text = "Gaziantep";
                label2.Text = "Ankara";
                pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Başkentler\Ankara.jpg";
            }

            if(sayac == 2)
            {
                label1.Text = "Almanya";
                BtnA.Text = "Köln";
                BtnB.Text = "Frankfurt";
                BtnC.Text = "Stutgart";
                BtnD.Text = "Berlin";
                label2.Text = "Berlin";
                pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Başkentler\Berlin.jpg";
            }

            if (sayac == 3)
            {
                label1.Text = "Mısır";
                BtnA.Text = "Kahire";
                BtnB.Text = "Dimyat";
                BtnC.Text = "İskenderiye";
                BtnD.Text = "Süveyş";
                label2.Text = "Kahire";
                pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Başkentler\Kahire.jpg";
            }

            if (sayac == 4)
            {
                label1.Text = "İspanya";
                BtnA.Text = "Barcelona";
                BtnB.Text = "Madrid";
                BtnC.Text = "Kurtuba";
                BtnD.Text = "Malaga";
                label2.Text = "Madrid";
                pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Başkentler\Madrid.jpg";
            }

            if (sayac == 5)
            {
                label1.Text = "Rusya";
                BtnA.Text = "Kazan";
                BtnB.Text = "Rostov";
                BtnC.Text = "Petersburg";
                BtnD.Text = "Moskova";
                label2.Text = "Moskova";
                pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Başkentler\Moskova.jpg";
            }

            if (sayac == 6)
            {
                label1.Text = "Fransa";
                BtnA.Text = "Lyon";
                BtnB.Text = "Lille";
                BtnC.Text = "Paris";
                BtnD.Text = "Marsilya";
                label2.Text = "Paris";
                pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Başkentler\Paris.jpg";
            }

            if (sayac == 7)
            {
                label1.Text = "Çin";
                BtnA.Text = "Makao";
                BtnB.Text = "Pekin";
                BtnC.Text = "Hong Kong";
                BtnD.Text = "Altay";
                label2.Text = "Pekin";
                pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Başkentler\Pekin.jpg";
            }

            if (sayac == 8)
            {
                label1.Text = "Arabistan";
                BtnA.Text = "Riyadh";
                BtnB.Text = "Medine";
                BtnC.Text = "Mekke";
                BtnD.Text = "Cidde";
                label2.Text = "Riyadh";
                pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Başkentler\Riyadh.jpg";
            }

            if (sayac == 9)
            {
                label1.Text = "İtalya";
                BtnA.Text = "Venedik";
                BtnB.Text = "Roma";
                BtnC.Text = "Floransa";
                BtnD.Text = "Milano";
                label2.Text = "Roma";
                pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Başkentler\Roma.jpg";
            }

            if (sayac == 10)
            {
                label1.Text = "Japonya";
                BtnA.Text = "Hiroshima";
                BtnB.Text = "Osaka";
                BtnC.Text = "Fukushima";
                BtnD.Text = "Tokyo";
                label2.Text = "Tokyo";
                pictureBox1.ImageLocation = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Başkentler\Tokyo.jpg";
            }

            if(sayac == 11)
            {
                puan = puan + Convert.ToInt32(LblSure.Text);
                LblPuan.Text = puan.ToString();
                timer1.Stop();
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            label3.Text = BtnA.Text;

            if(label2.Text == label3.Text)
            {
                puan += 10;
                LblPuan.Text = puan.ToString();
                BtnA.BackColor = Color.Green;
            }
            else
            {
                BtnA.BackColor = Color.Red; 
            }

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSoru.Enabled = true;
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            label3.Text = BtnB.Text;

            if (label2.Text == label3.Text)
            {
                puan += 10;
                LblPuan.Text = puan.ToString();
                BtnB.BackColor = Color.Green;
            }
            else
            {
                BtnB.BackColor = Color.Red;
            }

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSoru.Enabled = true;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            label3.Text = BtnC.Text;

            if (label2.Text == label3.Text)
            {
                puan += 10;
                LblPuan.Text = puan.ToString();
                BtnC.BackColor = Color.Green;
            }
            else
            {
                BtnC.BackColor = Color.Red;
            }

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSoru.Enabled = true;
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            label3.Text = BtnD.Text;

            if (label2.Text == label3.Text)
            {
                puan += 10;
                LblPuan.Text = puan.ToString();
                BtnD.BackColor = Color.Green;
            }
            else
            {
                BtnD.BackColor = Color.Red;
            }

            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSoru.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\hp\source\repos\C-Sharp Mini Projects\Ülkeler ve Başkentleri Oyunu\Headlights.mp3";
            BtnA.BackColor = Color.LightGray;
            BtnB.BackColor = Color.LightGray;
            BtnC.BackColor = Color.LightGray;
            BtnD.BackColor = Color.LightGray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();

            if(sure == 0)
            {
                timer1.Stop();
            }
        }
    }
}
