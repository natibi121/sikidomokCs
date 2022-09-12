using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sikidomok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a = numA.Value;
            decimal b = numB.Value;
            decimal K = 2 * a + 2 * b;
            decimal T = a * b;
            numK.Value = K;
            numT.Value = T;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            decimal r = korA.Value;
            decimal K = 2 * r * (decimal)Math.PI;
            decimal T = r * r * (decimal)Math.PI;
            korK.Value = K;
            korT.Value = T;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            decimal a = negyzetA.Value;
            decimal K = 4 * a;
            decimal T = a * a;
            negyzetK.Value = K;
            negyzetT.Value = T;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal a = haromszogA.Value;
            decimal b = haromszogB.Value;
            decimal c = haromszogC.Value;
            decimal k = a + b + c;
            decimal s = k / 2;
            decimal t = (decimal)Math.Sqrt((double)(s * (s - a) * (s - b) * (s - c)));
            haromszogK.Value = k;
            haromszogT.Value = t;
        }
    }
}
