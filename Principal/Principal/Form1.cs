using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String n1 = textBox1.Text;
            String n2 = textBox2.Text;
            String n3 = textBox3.Text;
            String n4 = textBox4.Text;

            Cliente c = new Cliente(n1, n2, n3, n4);
            c.insertarCliente(c);

        }
    }
}
