using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "4 işlem uygulaması";
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtsayı1.Text);
            int sayi2 = Convert.ToInt32(txtsayı2.Text);

            int toplam = sayi1 + sayi2;

            label3.Text = toplam.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtsayı1.Text);
            int sayi2 = Convert.ToInt32(txtsayı2.Text);

            int toplam = sayi1 * sayi2;

            label3.Text = toplam.ToString();
        }

        private void btnCıkar_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtsayı1.Text);
            int sayi2 = Convert.ToInt32(txtsayı2.Text);

            int toplam = sayi1 - sayi2;

            label3.Text = toplam.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtsayı1.Text);
            int sayi2 = Convert.ToInt32(txtsayı2.Text);

            int toplam = sayi1 / sayi2;

            label3.Text = toplam.ToString();
        }
    }
}
