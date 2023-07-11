using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Köstebek_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int puan = 0;
        Random rnd = new Random();
        int sure = 60;

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();

            //köstebekler için 66 adet buton oluşturdum
            for (int i = 1; i < 67; i++) 
            {
                Button btn = new Button();
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.Width = 50;
                btn.Height = 50;
                btn.Text = i.ToString();
                flowLayoutPanel1.Controls.Add(btn); //butonu flowlayoutpanel içine ekledim 
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            LblSure.Text = sure.ToString();

            int rastgele = rnd.Next(1, 67); //sıçrama yapacağı butonu belirliyoruz

            foreach (var a in flowLayoutPanel1.Controls) //flowLayoutPanel1.Controls içindeki her elemana a dedik
            {
                Button btn = a as Button;

                if (btn.Text == rastgele.ToString()) //button'un text'i rastgele ile birbirini tutuyorsa o butonu kırmızı yap
                {
                    btn.BackColor = Color.Red;
                    btn.Click += new EventHandler(btn_click);
                }
                else
                {
                    btn.BackColor = Color.White;
                }
            }

            if (sure == 0)
            {
                timer1.Stop();
                MessageBox.Show("OYUN SONLANMIŞTIR.");
            }
        }

        void btn_click(object sender, EventArgs e)
        {
            Button btn = sender as Button; //buton gibi gönder

            if(btn.BackColor == Color.Red)
            {
                puan++;
                LblSkor.Text = puan.ToString();
            }
            else
            {
                puan--;
                LblSkor.Text = puan.ToString();
            }

            this.Text = puan.ToString();    
        }
    }
}
