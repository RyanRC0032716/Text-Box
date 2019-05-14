using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i = 3;
            richTextBox1.AppendText(i.ToString()+"\n");
            double pi = 3.141592653589793;
            richTextBox1.AppendText(pi.ToString()+"\n");
            double d1 = 5e6;
            richTextBox1.AppendText(d1.ToString() + "\n");
            richTextBox1.AppendText(d1.ToString("N") + "\n");
            richTextBox1.AppendText(d1.ToString("N3") + "\n");
            richTextBox1.AppendText(d1.ToString("N0") + "\n");
            richTextBox1.AppendText(d1.ToString("0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.0E0") + "\n");
            richTextBox1.AppendText(d1.ToString("0.00E00") + "\n");
            pi = 3.141592653589793;
            richTextBox1.AppendText(pi.ToString("N3") + "\n");
            richTextBox1.AppendText(pi.ToString("N5") + "\n");
            richTextBox1.AppendText(pi.ToString("N15") + "\n");
            double c = 299792458;
            richTextBox1.AppendText(c.ToString() + "\n");
            richTextBox1.AppendText(c.ToString("N0") + "\n");
            richTextBox1.AppendText(c.ToString("0.000000000000000E00") + "\n");
            richTextBox1.AppendText(c.ToString("0.00E00") + "\n");
        }
    }
}
