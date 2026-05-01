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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)//1.Küp
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)//2.Dikdörtgen
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)//3.Silindir
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)//4.Koni
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }
        private void button5_Click(object sender, EventArgs e)//5.Küre
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)//denklem
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }
        private void button7_Click(object sender, EventArgs e)//kapatma
        {
            this.Close();
        }
    }
}
