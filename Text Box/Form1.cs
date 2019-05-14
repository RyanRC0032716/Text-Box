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
            richTextBox1.AppendText(" " + i);
            double pi = 3.14159265;
            richTextBox1.AppendText(pi.ToString());
            richTextBox1.AppendText(3.ToString());
        }
    }
}
