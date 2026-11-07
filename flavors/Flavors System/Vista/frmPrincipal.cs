using Flavors_System.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flavors_System
{
    public partial class frmPrincipal : Form
    {
        private Size formSize;

        public frmPrincipal(int id_tipo_usuario)
        {
            InitializeComponent();
            if (id_tipo_usuario == 1)
            {

            }
            else if (id_tipo_usuario == 2)
            {

            }
            else if (id_tipo_usuario == 3)
            {
                btnUsuarios.Visible = false;
                btnEmpleados.Visible = false;
                btnMesas.Visible = false;
                btnClientes.Visible = false;
            }
        }

        public frmPrincipal()
        {
            InitializeComponent();
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        //Mover formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void CollapseMenu()
        {
            if (this.pnlMenu.Width > 199) //Collapse menu
            {
                pnlMenu.Width = 100;
                btnMenu.Dock = DockStyle.Top;
                lblLogo.Visible = false;
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = "";
                    menuButton.ImageAlign = ContentAlignment.MiddleCenter;
                }
            }
            else
            { //Expand menu
                pnlMenu.Width = 200;
                btnMenu.Dock = DockStyle.None;
                lblLogo.Visible = true;
                foreach (Button menuButton in pnlMenu.Controls.OfType<Button>())
                {
                    menuButton.Text = menuButton.Tag.ToString();
                    menuButton.ImageAlign = ContentAlignment.MiddleLeft;
                }
            }
        }

        private void AbrirForm(object formHija)
        {
            if (pnlContenedor.Controls.Count > 0)
            {
                this.pnlContenedor.Controls.RemoveAt(0);
            }

            Form fh = formHija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlContenedor.Controls.Add(fh);
            this.pnlContenedor.Tag = fh;
            fh.Show();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            CollapseMenu();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                formSize = this.ClientSize;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            this.WindowState = FormWindowState.Normal;
            this.Size = formSize;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlControles_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios us = new frmUsuarios();
            AbrirForm(us);
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados emp = new frmEmpleados();
            AbrirForm(emp);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            AbrirForm(clientes);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmCrearPedidos CrearPedidos = new frmCrearPedidos();
            AbrirForm(CrearPedidos);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            frmProductos productos = new frmProductos();
            AbrirForm(productos);
        }

        private void btnMesas_Click(object sender, EventArgs e)
        {
            frmMesas mesas = new frmMesas();
            AbrirForm(mesas);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Show();
            this.Hide();
        }
        //private void btnHistorial_Click(object sender, EventArgs e)
        //{
        //    frmHistorialPedidos historial = new frmHistorialPedidos();
        //    AbrirForm (historial);
        //}
    }
}
