using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quiz1 = Convert.ToInt32(textBox1.Text);
            int quiz2 = Convert.ToInt32(textBox2.Text);
            int quiz3 = Convert.ToInt32(textBox3.Text);


            int toplam = ortalama(quiz1, quiz2, quiz3);


            if (toplam >= 50 )
            {
                MessageBox.Show("geçtiniz");
            }
            else
            {
                MessageBox.Show("Kaldınız");
            }

            

        }

        static int ortalama(int number1, int number2, int number3)
        {

            int toplam =  (number1 + number2 +number3) / 3 ;

            return toplam;
        }

    }
}
