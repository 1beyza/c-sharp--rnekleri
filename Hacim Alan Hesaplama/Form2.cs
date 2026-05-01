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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            int yüzeyAlanı = 6 * a * a;
            int kesitAlanı = a * a;
            int hacim = a * a * a;
            label2.Text = "Yüzey alanı:" + Convert.ToString(yüzeyAlanı);
            label3.Text = "Kesit alanı:" + Convert.ToString(kesitAlanı);
            label4.Text = "Hacim:" + Convert.ToString(hacim);
        }
    }
}
