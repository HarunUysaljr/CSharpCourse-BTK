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
            btnSifirla.Enabled = false; // butonu týklanamaz hale getiriyorum.
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
            // rastgele sayý üretmek için gerekli taným.

            pcbAt1.Left += rnd.Next(5, 15);
            pcbAt2.Left += rnd.Next(7, 18);
            pcbAt3.Left += rnd.Next(4, 20);
            // Atlarýn sola göre uzaklýklarýný rastgele sayýca artýrýyorum.

            string mesaj = "Birinci At Önde.";

            int enOn = pcbAt1.Left;

            if ( pcbAt2.Left > enOn)
            {
                mesaj = "Ýkinci At Önde.";
                enOn = pcbAt2.Left;
            }

            if(pcbAt3.Left > enOn)
            {
                mesaj = "Üçüncü At Önde.";
                enOn = pcbAt3.Left;
            }

            lblDurum.Text = mesaj;
            // Atlarýn pozisyonlarýna göre sýralanmasý ve mesajýn deðiþmesi iþlemleri yukarýda.


            // Atlarým bitiþ çizgisine varmýþ mý diye tek tek kontrol etmem gerekiyor. Eðer bir at vardýysa, lblDurum'da kazanan olarak onu ilan edip. Timer'ý durdurmalýyým ki, atlar ilerlemeye devam etmesin.

            if(pcbAt1.Right >= lblBitis.Left)
            {
                lblDurum.Text = "1.AT YARIÞI KAZANDI!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true; // butonu yeniden týklanabilir hale getirdim.

            }

            if (pcbAt2.Right >= lblBitis.Left)
            {
                lblDurum.Text = "2.AT YARIÞI KAZANDI!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true; // butonu yeniden týklanabilir hale getirdim.

            }

            if (pcbAt3.Right >= lblBitis.Left)
            {
                lblDurum.Text = "3.AT YARIÞI KAZANDI!";
                lblDurum.ForeColor = Color.Red;
                timer1.Stop();
                btnSifirla.Enabled = true; // butonu yeniden týklanabilir hale getirdim.

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