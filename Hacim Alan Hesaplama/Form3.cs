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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            int c = Convert.ToInt32(textBox3.Text);
            int yüzeyAlanı = 2 * (a * b + b * c + a * c);
            int kesitAlanı = a * b;
            int hacim = a * b * c;
            label2.Text = "Yüzey alanı:" + Convert.ToString(yüzeyAlanı);
            label3.Text = "Kesit alanı:" + Convert.ToString(kesitAlanı);
            label4.Text = "Hacim:" + Convert.ToString(hacim);
        }
    }
}
