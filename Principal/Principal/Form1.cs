using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Principal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        
        //codigo del boton restaurar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
            
        }

        //codigo del boton minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        //codigo del boton restaurar
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        //codigo para mover la GUI desde la barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String n1 = txtNombre1.Text;
            String n2 = txtNombre2.Text;
            String n3 = txtApellido1.Text;
            String n4 = txtApellido2.Text;

            Cliente c = new Cliente(n1, n2, n3, n4);

            MessageBox.Show("Registrado con éxito");
            c.insertarCliente(c);
            txtNombre1.Text = "";
            txtNombre2.Text = "";
            txtApellido1.Text = "";
            txtApellido2.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }
    }
}
