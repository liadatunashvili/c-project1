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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R = double.Parse(textBox1.Text);
            string answer = $" {R * R * 3.1415926535897931} ";
            Form3 form3 = new Form3(answer);
            form3.Show();
        }
    }
}
