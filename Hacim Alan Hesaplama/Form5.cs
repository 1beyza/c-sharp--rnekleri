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
    public partial class Form5 : Form
    {
        public Form5()
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
            int a = Convert.ToInt32(textBox1.Text);
            int h = Convert.ToInt32(textBox2.Text);
            int r = Convert.ToInt32(textBox3.Text);
            double pi = Math.PI;
            double tabanAlanı = pi * r * r;
            double yanalAlanı = pi * r * a;
            double toplamYüzeyAlanı = (pi * r * r) + (pi * r * a);
            double hacim = (pi * r * r * h)/3;
            label2.Text = "Taban alanı:" + Convert.ToString(tabanAlanı);
            label3.Text = "Yanal alanı:" + Convert.ToString(yanalAlanı);
            label4.Text = "Toplam yüzey alanı:" + Convert.ToString(toplamYüzeyAlanı);
            label8.Text = "Hacim" + Convert.ToString(hacim);
       }
    }
}
