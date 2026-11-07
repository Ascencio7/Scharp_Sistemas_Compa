using Flavors_System.Controlador;
using Flavors_System.Modelo;
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

namespace Flavors_System.Vista
{
    public partial class frmLogin : Form
    {
        ConstructorUsuarios us = new ConstructorUsuarios();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            int[] retornos = new int[4];
            frmCambio cambio = new frmCambio();
            us.usuario = txtUsuario.Text;
            us.contrasenia = txtContraseña.Text;
            retornos = FuncionesUsuarios.IniciarSesion(us);
            txtID.Text = retornos[1].ToString();
            if (retornos[0] == 2)
            {
                cambio.txtID.Text = txtID.Text;
                cambio.Show();
                this.Hide();
            }
            else if (retornos[0] == 3)
            {
                frmPrincipal principal = new frmPrincipal(retornos[3]);
                principal.txtID.Text = retornos[2].ToString();
                principal.txtTipo.Text = retornos[3].ToString();
                principal.Show();
                this.Hide();
            }
        }
    }
}
