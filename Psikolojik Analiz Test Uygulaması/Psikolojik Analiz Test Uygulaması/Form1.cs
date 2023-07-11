using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psikolojik_Analiz_Test_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            textBox1.Text = "PSİKOLOJİK ANALİZ TEST UYGULAMASI'NA HOŞGELDİNİZ";

            //girişteki yazının boyutunu ayarladım
            Font eski = textBox1.Font;
            textBox1.Font = new Font(eski.FontFamily, eski.Size + 12, eski.Style);
        }

        int soru;
        int toplam = 0; //puan 

        private void button6_Click(object sender, EventArgs e)
        {
            soru++;

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = false;
            button7.Enabled = false;

            button6.Text = "İleri";

            if(soru == 1)
            {
                textBox1.Text = "1)Sevgilinizle ya da eşinizle 'mükemmel bir akşam' size aşağıdakilerden hangisini çağrıştırıyor?";
                button1.Text = "Bir rock konserine gitmek";
                button2.Text = "Lunaparka gitmek";
                button3.Text = "Sinemaya gitmek";
                button4.Text = "Mum ışığında romantik bir yemek";
                button5.Text = "Arabayla turlamak";
                button8.Enabled = false;
            }

            if (soru == 2)
            {
                textBox1.Text = "2)En sevdiğiniz müzik türü nedir?";
                button1.Text = "Alternatif";
                button2.Text = "Rock and Roll";
                button3.Text = "Pop";
                button4.Text = "Soft Rock";
                button5.Text = "Klasik";
                button8.Enabled = false;
            }

            if (soru == 3)
            {
                textBox1.Text = "3)En çok hangi film türünü seversiniz?";
                button1.Text = "Korku";
                button2.Text = "Komedi";
                button3.Text = "Müzikal";
                button4.Text = "Romantik";
                button5.Text = "Belgesel";
            }

            if (soru == 4)
            {
                textBox1.Text = "4)Aşağıdaki mesleklerden birini seçmeniz gerekseydi hangisi olurdunuz  ?";
                button1.Text = "Barmen/Barmaid";
                button2.Text = "Polis";
                button3.Text = "Öğretmen";
                button4.Text = "Garson";
                button5.Text = "Futbolcu";
            }

            if (soru == 5)
            {
                textBox1.Text = "5)Bir saat boş vaktinizi değerlendirmek için hangisi size daha uygun?";
                button1.Text = "TV izlemek";
                button2.Text = "İnternete girmek";
                button3.Text = "Uyumak";
                button4.Text = "Kitap okumak";
                button5.Text = "Dışarıda gezmek";
            }

            if (soru == 6)
            {
                textBox1.Text = "6)Aşağıdaki renklerden birini seçiniz.";
                button1.Text = "Sarı";
                button2.Text = "Kahverengi";
                button3.Text = "Mavi";
                button4.Text = "Mor";
                button5.Text = "Kırmızı";
            }

            if (soru == 7)
            {
                textBox1.Text = "7)Şuan önünüzde aşağıdaki yiyeceklerden hangisi olsa dayanamayıp yersiniz?";
                button1.Text = "Sushi";
                button2.Text = "Pizza";
                button3.Text = "Dondurma";
                button4.Text = "Makarna";
                button5.Text = "Salata";
            }

            if (soru == 8)
            {
                textBox1.Text = "8)En sevdiğiniz tatil, bayram ya da özel gün hangisidir?";
                button1.Text = "23 Nisan Çocuk Bayramı";
                button2.Text = "Yılbaşı Tatili";
                button3.Text = "Ramazan Bayramı";
                button4.Text = "Sevgililer Günü";
                button5.Text = "Kurban Bayramı";
            }

            if (soru == 9)
            {
                textBox1.Text = "9)Şuan aşağıdakilerden hangisinde olmak isterdiniz?";
                button1.Text = "Lav Vegas'ta";
                button2.Text = "Hawaii'de";
                button3.Text = "Hollywood'da";
                button4.Text = "Paris'te";
                button5.Text = "İspanya'da";
            }

            if (soru == 10)
            {
                textBox1.Text = "10)Nasıl biriyle vakit geçirmekten hoşlanırsınız?";
                button1.Text = "Bir parti canavarıyla";
                button2.Text = "Güzel/yakışıklı biriyle";
                button3.Text = "Komik biriyle";
                button4.Text = "Duygusal biriyle";
                button5.Text = "Akıllı biriyle";
            }

            if(soru == 11)
            {
                label2.Text = toplam.ToString();
                button7.Enabled = true;
                button7.Visible = true;
                button8.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toplam += 1; //bu buton seçilince 1 puan gelsin

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = false;
            button8.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toplam += 2;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = false;
            button8.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            toplam += 3;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = false;
            button8.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            toplam += 4;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = false;
            button8.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            toplam += 5;

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = false;
            button8.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (toplam >= 10 && toplam <= 17)
            {
                textBox1.Text = "Siz vahşi ve çılgın birisiniz. Eğleneyim derken uçuyorsunuz. Ama her zaman ne yaptığınızın " +
                                "farkındasınız, hayatınızın kontrolünü kaybetmiyorsunuz. İnsanlar olaylara sizin gibi bakmadığında bu " +
                                "sizi durdurmuyor. \n Tavsiye : Bu vahşi karakterinizle kendinizi ve etrafınızdakileri incitebilirsiniz." +
                                " Dikkatli olun.";
            }

            if (toplam >= 18 && toplam <= 26)
            {
                textBox1.Text = "Siz eğlenceli, arkadaş canlısı ve popülersiniz. Cıvıl cıvıl halinizle etrafa neşe saçıyorsunuz. Çoğu zaman " +
                                "ikili ilişkilerinizde uçuk kaçık davransanızda inandığınız değerlerden asla taviz vermiyorsunuz. Evlilik ve " +
                                "çocuk sahibi olmak sizin için önemli ama öncelikle yeterince tecrübe edinmek istiyorsunuz.\n Tavsiye : İnsanların " +
                                "aldığınız kararlarda sizi bu kadar etkilemelerine izin vermeyin.";
            }

            if (toplam >= 27 && toplam <= 34)
            {
                textBox1.Text = "Öyle tatlısınız ki sizi sevmemek imkansız. Siz insanların asla kaybetmek istemeyeceği türden bir dostsunuz. " +
                                "Kimseyi incitmemek için kendinizi incittiğiniz bile oluyor. Siz genellikle olaylar karşısında olgun ve sakin" +
                                "bir tavır takınırsınız. \n Tavsiye : Herkes göründüğü gibi değildir bunu unutmayın. Biraz kurnaz olun.";
            }

            if (toplam >= 35 && toplam <= 42)
            {
                textBox1.Text = "Siz iflah olmaz bir romantiksiniz. Şarap, kırmızı güller bunlar sizin yaşam tarzınız. Söz verirsiniz ve o " +
                                "sözü ne olursa olsun yerine getirirsiniz. Ailenize çok bağlısınız. Annenizi her hafta sonu ararsınız. Özel " +
                                "günleri asla unutmazsınız.\n Tavsiye : Fazla romantizmin sizi gerçeklerden uzaklaştırmasına izin vermeyin.";
            }

            if (toplam >= 43 && toplam <= 50)
            {
                textBox1.Text = "Belirgin özelliğiniz hızlı ve doğru karar verebilmeniz. Her olay için kafanızda bir planınız vardır." +
                                "Fiziksel ve zihinsel gücünüz çok fazla. Mantıklı, ılımlı ve yapıcı tavırlarınızla çoğu kişinin kendine " +
                                "örnek aldığı birisiniz. \n Tavsiye : Küçük gibi görünen bazı olayları göz ardı etmeniz ileride büyük " +
                                "sorunlara yol açabilir.";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = true;
            button7.Enabled = false;
            button8.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            soru--;

            if (soru == 1)
            {
                textBox1.Text = "1)Sevgilinizle ya da eşinizle 'mükemmel bir akşam' size aşağıdakilerden hangisini çağrıştırıyor?";
                button1.Text = "Bir rock konserine gitmek";
                button2.Text = "Lunaparka gitmek";
                button3.Text = "Sinemaya gitmek";
                button4.Text = "Mum ışığında romantik bir yemek";
                button5.Text = "Arabayla turlamak";
            }

            if (soru == 2)
            {
                textBox1.Text = "2)En sevdiğiniz müzik türü nedir?";
                button1.Text = "Alternatif";
                button2.Text = "Rock and Roll";
                button3.Text = "Pop";
                button4.Text = "Soft Rock";
                button5.Text = "Klasik";
            }

            if (soru == 3)
            {
                textBox1.Text = "3)En çok hangi film türünü seversiniz?";
                button1.Text = "Korku";
                button2.Text = "Komedi";
                button3.Text = "Müzikal";
                button4.Text = "Romantik";
                button5.Text = "Belgesel";
            }

            if (soru == 4)
            {
                textBox1.Text = "4)Aşağıdaki mesleklerden birini seçmeniz gerekseydi hangisi olurdunuz  ?";
                button1.Text = "Barmen/Barmaid";
                button2.Text = "Polis";
                button3.Text = "Öğretmen";
                button4.Text = "Garson";
                button5.Text = "Futbolcu";
            }

            if (soru == 5)
            {
                textBox1.Text = "5)Bir saat boş vaktinizi değerlendirmek için hangisi size daha uygun?";
                button1.Text = "TV izlemek";
                button2.Text = "İnternete girmek";
                button3.Text = "Uyumak";
                button4.Text = "Kitap okumak";
                button5.Text = "Dışarıda gezmek";
            }

            if (soru == 6)
            {
                textBox1.Text = "6)Aşağıdaki renklerden birini seçiniz.";
                button1.Text = "Sarı";
                button2.Text = "Kahverengi";
                button3.Text = "Mavi";
                button4.Text = "Mor";
                button5.Text = "Kırmızı";
            }

            if (soru == 7)
            {
                textBox1.Text = "7)Şuan önünüzde aşağıdaki yiyeceklerden hangisi olsa dayanamayıp yersiniz?";
                button1.Text = "Sushi";
                button2.Text = "Pizza";
                button3.Text = "Dondurma";
                button4.Text = "Makarna";
                button5.Text = "Salata";
            }

            if (soru == 8)
            {
                textBox1.Text = "8)En sevdiğiniz tatil, bayram ya da özel gün hangisidir?";
                button1.Text = "23 Nisan Çocuk Bayramı";
                button2.Text = "Yılbaşı Tatili";
                button3.Text = "Ramazan Bayramı";
                button4.Text = "Sevgililer Günü";
                button5.Text = "Kurban Bayramı";
            }

            if (soru == 9)
            {
                textBox1.Text = "9)Şuan aşağıdakilerden hangisinde olmak isterdiniz?";
                button1.Text = "Lav Vegas'ta";
                button2.Text = "Hawaii'de";
                button3.Text = "Hollywood'da";
                button4.Text = "Paris'te";
                button5.Text = "İspanya'da";
            }

            if (soru == 10)
            {
                textBox1.Text = "10)Nasıl biriyle vakit geçirmekten hoşlanırsınız?";
                button1.Text = "Bir parti canavarıyla";
                button2.Text = "Güzel/yakışıklı biriyle";
                button3.Text = "Komik biriyle";
                button4.Text = "Duygusal biriyle";
                button5.Text = "Akıllı biriyle";
            }

            if (soru == 11)
            {
                label2.Text = toplam.ToString();
                button7.Enabled = true;
                button7.Visible = true;
            }
        }
    }
}
