using System;
using System.Windows.Forms;

namespace _20170814_1Win_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayi = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            //Kodlar zamana göre çalışmaz. işlemin yapılabilecek en hızlı şekilde yapılması gerekmektedir.
            //bunu bir süreye göre yapmak istersek, Timer kullanmamız gerekmektedir. örn. her saniye sayi değişkeninin 1 arttırıp labele yazmak istersek, Timer nesnesini kullanmak uygun olacaktır.
            //while (true)
            //{
            //    sayi++;
            //    label1.Text = sayi.ToString();
            //    Application.DoEvents(); // normal şartlarda while döngüsü programı kitleyecek ve başka bir işlem yapılmasına izin vermeyecektir. DoEvents metotu sayesinde döngünün yer bir turu bittiğinde programda yapılacak başka bir iş var mı diye kontrol gerçekleştirilir.  
            //}


            //TİMER varsayılan olarak kapalı gelir. açmak için ;
            timer1.Enabled = true; //veya
            timer1.Start(); // kullanılarak timer aktif edilir.
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // burası döngünün içi gibidir. belirtilen interval süresi kadar bekleyerek bu kodlar sürekli olarak çalıştırılacaktır.
            sayi++;
            label1.Text = sayi.ToString();

            //timer multithread işlem yapar. Timer çalıştırıldığı zaman metotu gönderir, tamamlanıp tamamlanmadığını kontrol etmeden interval süresi dolduğunda tekrar çalışır.
            //eğer timer içerisinde yapılan işlem süresi, interval süresinden daha uzun bir sürede biterse, sorun yaşanabilir.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1000; // interval süresi 2 tickleme işlemi arasındaki milisaniye cinsinden bekleme süresidir.
        }
    }
}
