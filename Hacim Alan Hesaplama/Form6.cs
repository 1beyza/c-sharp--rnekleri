using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace beyzaWindowsFormsApplication2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
            int r = Convert.ToInt32(textBox1.Text);
            double pi = Math.PI;
            double yüzeyAlanı = 4 * pi * r * r;
            double kesitAlanı = pi * r * r;
            double hacim = (pi * r * r * r)*4/3;
            label2.Text = "Yüzey alanı:" + Convert.ToString(yüzeyAlanı);
            label3.Text = "Kesit alanı:" + Convert.ToString(kesitAlanı);
            label4.Text = "Hacim:" + Convert.ToString(hacim);
        }
    }
}
