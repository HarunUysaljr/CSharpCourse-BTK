  namespace IfOrnek6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int position1 , position2, position3;
        private void Form1_Load(object sender, EventArgs e)
        {
            btnSifirla.Enabled = false; // butonu t�klanamaz hale getiriyorum.
            position1 = pcbAt1.Left;
            position2 = pcbAt2.Left;
            position3 = pcbAt3.Left;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btnBaslat.Enabled = false;
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            // rastgele say� �retmek i�in gerekli tan�m.

            pcbAt1.Left += rnd.Next(5, 15);
            pcbAt2.Left += rnd.Next(7, 18);
            pcbAt3.Left += rnd.Next(4, 20);
            // Atlar�n sola g�re uzakl�klar�n� rastgele say�ca art�r�yorum.

            string mesaj = "Birinci At �nde.";

            int enOn = pcbAt1.Left;

            if ( pcbAt2.Left > enOn)
            {
                mesaj = "�kinci At �nde.";
                enOn = pcbAt2.Left;
            }

            if(pcbAt3.Left > enOn)
            {
                mesaj = "���nc� At �nde.";
                enOn = pcbAt3.Left;
            }

            lblDurum.Text = mesaj;
            // Atlar�n pozisyonlar�na g�re s�ralanmas� ve mesaj�n de�i�mesi i�lemleri yukar�da.


            // Atlar�m biti� �izgisine varm�� m� diye tek tek kontrol etmem gerekiyor. E�er bir at vard�ysa, lblDurum'da kazanan olarak onu ilan edip. Timer'� durdurmal�y�m ki, atlar ilerlemeye devam etmesin.

            if(pcbAt1.Right >= lblBitis.Left)
            {
                lblDurum.Text = "1.AT YARI�I KAZANDI!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true; // butonu yeniden t�klanabilir hale getirdim.

            }

            if (pcbAt2.Right >= lblBitis.Left)
            {
                lblDurum.Text = "2.AT YARI�I KAZANDI!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true; // butonu yeniden t�klanabilir hale getirdim.

            }

            if (pcbAt3.Right >= lblBitis.Left)
            {
                lblDurum.Text = "3.AT YARI�I KAZANDI!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true; // butonu yeniden t�klanabilir hale getirdim.

            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            pcbAt1.Left = position1;
            pcbAt2.Left = position2;
            pcbAt3.Left = position3;

            lblDurum.Text = "-";
            lblDurum.ForeColor = Color.White;

            btnSifirla.Enabled = false;
            btnBaslat.Enabled = true;

        }
    }
}