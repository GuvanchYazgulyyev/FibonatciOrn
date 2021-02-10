using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonatci_Orn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int a = 1;
            int b = 1;
            int c;

            listBox1.Items.Add(a);
            listBox1.Items.Add(b);

            for(int i = 1; i <= 8; i++)
            {
                c = a + b;

                a = b;
                b = c;
                listBox1.Items.Add(c);
            }
        }
    }
}
