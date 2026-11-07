using Flavors_System.Controlador;
using Flavors_System.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flavors_System.Vista
{
    public partial class frmCambio : Form
    {
        ConstructorUsuarios us = new ConstructorUsuarios();
        public frmCambio()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            if (txtNueva.Text == txtConfirmar.Text)
            {
                ConstructorUsuarios.id_usuario = Convert.ToInt32(txtID.Text);
                us.contrasenia = txtNueva.Text;
                FuncionesUsuarios.CambiarContrasenia(us);
                log.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Los campos no coinciden, revise los datos", "");
            }
        }
    }
}
