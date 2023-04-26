using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimasyonTwo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Baslat_Click(object sender, EventArgs e)
        {

            timer1.Start();
            button_Baslat.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();

            pcbAt1.Left += rnd.Next(5,15);
            pcbAt2.Left += rnd.Next(5, 15);
            pcbAt3.Left += rnd.Next(5, 15);


            string mesaj = "birinci at önde";

            int enOn = pcbAt1.Left;

            if (pcbAt2.Left > enOn)
            {
                mesaj = "ikinci at önde";
                enOn = pcbAt2.Left;
            }
            if (pcbAt3.Left > enOn)
            {
                mesaj = "Üçüncü At en önde";
            }



            lblDurum.Text = mesaj;

        }
    }
}
