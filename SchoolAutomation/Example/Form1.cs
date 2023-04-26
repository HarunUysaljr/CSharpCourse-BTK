using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            int RastgeleSayi1 = random.Next(100, 200);

            DataGridView1.Rows.Add(textBox_StName.Text, textBox_StSname.Text, textBox1.Text, RastgeleSayi1);

            add();

            label3.Text = textBox_StName.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox_StName.Clear();
            textBox_StSname.Clear();
            textBox1.Clear();
            textBox_Vize.Clear();
            textBox_Final.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.DataGridView1.SelectedRows.Count > 0)
            {
                DataGridView1.Rows.RemoveAt(this.DataGridView1.SelectedRows[0].Index);
            }
        }


        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {


            label3.Text = "";
            label3.Text = DataGridView1.CurrentCell.Value.ToString() + "  Öğrencisinin Vize ve Final notunu gir";
        }


        private void button4_Click(object sender, EventArgs e)
        {


            double vize = Convert.ToDouble(textBox_Vize.Text);
            double final = Convert.ToDouble(textBox_Final.Text);

            double sonuc = StudentSitua(vize, final);


            DataGridViewTextBoxColumn Note = this.sonuc;

            DataGridView1.CurrentRow.Cells[4].Value = sonuc;


            if (sonuc > 90)
            {
                label7.Text = "A";
            }
            else if (sonuc > 80 && sonuc < 90)
            {
                label7.Text = "B";
            }
            else if (sonuc >= 70 && sonuc < 80)
            {
                label7.Text = "c";
            }
            else
            {
                label7.Text = "Sınıf Tekrarı";
            }

        }



        public static double StudentSitua(double Vize, double Final, double toplam = 0)
        {
            toplam = (Vize * 0.40) + (Final * 0.60);
            return toplam;
        }

        static void add()
        {
            MessageBox.Show("Öğrenci Başarıyla Eklendi");
        }

    }
}


/* // Öğrenci 90'dan yüksek not aldıysa A
//         80'den yüksek not aldıysa B
//         70'den yüksek not aldıysa C
//         70'den düşük nok aldıysa "Sınıf Tekrarı" yazdırınız.*/


/* 
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int stNumber = rnd.Next(100, 200);

            label3.Text = textBox_StName.Text;
            label4.Text = textBox_StSname.Text;
            label7.Text = textBox1.Text;
            label5.Text = stNumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double vize, final, toplam=0;

            vize = Convert.ToInt32(textBox2.Text);

            final = Convert.ToInt32(textBox3.Text);

            toplam = (vize*0.40) + (final*0.60);

            label12.Text = toplam.ToString();

            if (toplam>90)
            {
                label11.Text = "A";
            }
            else if (toplam>80 && toplam<90)
            {
                label11.Text = "B";
            }
            else if (toplam > 70 && toplam <80)
            {
                label11.Text = "c";
            }
            else
            {
                label11.Text = "Sınıf Tekrarı";
            }
   
        }

        private void button3_Click(object sender, EventArgs e)
        {
      
        }
    }
}


/* // Öğrenci 90'dan yüksek not aldıysa A
//         80'den yüksek not aldıysa B
//         70'den yüksek not aldıysa C
//         70'den düşük nok aldıysa "Sınıf Tekrarı" yazdırınız.*/
