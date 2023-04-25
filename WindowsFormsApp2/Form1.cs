using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string msg = msgText.Text;
            
            int msgA = Convert.ToInt32(msgAdet.Text);

            for (int i = 0; i < msgA; i++)
            {
                MessageBox.Show(i + "- " + msg);
            }
        }
    }
}
