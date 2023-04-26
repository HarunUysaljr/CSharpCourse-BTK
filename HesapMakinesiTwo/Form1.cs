using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Detaylı işlem";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int numberOne = Convert.ToInt32(number1.Text);
            int numberTwo = Convert.ToInt32(number2.Text);

            if (checkBox1.Checked = true)
            {
                int sonuc = numberOne + numberTwo;
                listBox1.Items.Add(numberOne + "+" + numberTwo  + "=" + sonuc);              
            }

            if (checkBox2.Checked = true)
            {
                int sonuc = numberOne - numberTwo;
                listBox1.Items.Add(numberOne + "-" + numberTwo + "=" + sonuc);
            }

            if (checkBox3.Checked = true)
            {
                int sonuc = numberOne * numberTwo;
                listBox1.Items.Add(numberOne + "*" + numberTwo + "=" + sonuc);
            }

            if (checkBox4.Checked = true)
            {
                int sonuc = numberOne / numberTwo;
                listBox1.Items.Add(numberOne + "/" + numberTwo + "=" + sonuc);
            }

            if (checkBox5.Checked = true)
            {
                int sonuc = numberOne*numberOne;
                listBox1.Items.Add(numberOne + "Karesi"  + "=" + sonuc);
            }

            if (checkBox6.Checked = true)
            {
                int sonuc = (numberOne % numberTwo);
                listBox1.Items.Add(numberOne + "%" + numberTwo + "=" + sonuc);
            }


        }
    }
}
