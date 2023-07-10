using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtYarışı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int birinciatsolauzaklik, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        Random rastgele = new Random();

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true; //butona basınca zamanlayıcı çalışsın
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sayi = Convert.ToInt32(label7.Text); //yazıyı int'e çevir
            sayi++; //her seferinde 1 1 arttır
            label7.Text = sayi.ToString(); //arttırdığın dereceyi label'a yazdır

            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            int bitisuzakligi = label5.Left;

            pictureBox1.Left += rastgele.Next(5, 15); //1. at için 5 ve 15 arasında rastgele sayılar vererek ilerleteceğiz
            pictureBox2.Left += rastgele.Next(5, 15);
            pictureBox3.Left += rastgele.Next(5, 15);

            if(pictureBox1.Left > pictureBox2.Left + 5 && pictureBox1.Left > pictureBox3.Left + 5) //+ 5 olmasının sebebi rastgele kısmında 5 ile başlatmamız
            {
                label6.Text = "HORSE NUMBER 1, LEADS THE RACE";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left > pictureBox3.Left + 5) 
            {
                label6.Text = "HORSE NUMBER 2, TAKES THE LEAD WITH A GOOD ATTACK";
            }

            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left > pictureBox2.Left + 5)
            {
                label6.Text = "HORSE NUMBER 3, TAKES THE LEAD";
            }

            if (birinciatingenisligi + pictureBox1.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "HORSE NUMBER 1 WINS THE RACE!!!";
            }
            if (ikinciatingenisligi + pictureBox2.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "HORSE NUMBER 2 WINS THE RACE!!!";
            }
            if (ucuncuatingenisligi + pictureBox3.Left >= bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "HORSE NUMBER 3 WINS THE RACE!!!";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklik = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }
    }
}
