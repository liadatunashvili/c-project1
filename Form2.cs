using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formula
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(textBox1.Text);
            double R = double.Parse(textBox2.Text);

            string answer = $" { n / 2 * R * R * Math.Sin((360 / n) * 3.14 / 180)} ";
            Form3 form3 = new Form3(answer);
            form3.Show();
        }
    }
}
