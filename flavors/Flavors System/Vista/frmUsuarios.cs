using Flavors_System.Controlador;
using Flavors_System.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flavors_System.Vista
{
    public partial class frmUsuarios : Form
    {
        ConstructorUsuarios us = new ConstructorUsuarios();

        public static frmUsuarios instancia;

        public static frmUsuarios Instancia
        {
            get { return instancia; }
        }
        public frmUsuarios()
        {
            InitializeComponent();
            instancia = this;
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            LlenarEmpleados();
            LlenarEstadoUsuario();
            LlenarTipoUsuarios();
            MostrarDatos();
        }

        private void LlenarEmpleados()
        {
            cmbEmpleado.DataSource = FuncionesUsuarios.CargarEmpleados();
            cmbEmpleado.DisplayMember = "nombre_empleado";
            cmbEmpleado.ValueMember = "id_empleado";
        }

        //En estos dos elementos se llema el cmbTipoUsuarios pero se oculta el primer elemento que corresponde al usuario ROOT.
        private void LlenarTipoUsuarios() 
        {
            cmbTipo.DataSource = FuncionesUsuarios.CargarTipoUsuario();
            cmbTipo.DisplayMember = "tipo_usuario";
            cmbTipo.ValueMember = "id_tipo_usuario";
        }

        private void LlenarEstadoUsuario() 
        {
            cmbEstado.DataSource = FuncionesUsuarios.CargarEstado();
            cmbEstado.DisplayMember = "estado_usuario";
            cmbEstado.ValueMember = "id_estado_usuario";
        }

        private void MostrarDatosActivos() 
        {
            dtUsuarios.RowHeadersVisible = false;
            dtUsuarios.DataSource = FuncionesUsuarios.MostrarUsuariosActivos();
            dtUsuarios.Columns[0].Visible = false;
            dtUsuarios.Columns[1].HeaderText = "Usuario";
            dtUsuarios.Columns[2].HeaderText = "Empleado";
            dtUsuarios.Columns[3].HeaderText = "Tipo de usuario";
            dtUsuarios.Columns[4].HeaderText = "Estado";
        }
        private void MostrarDatosInactivos()
        {
            dtUsuarios.RowHeadersVisible = false;
            dtUsuarios.DataSource = FuncionesUsuarios.MostrarUsuariosInactivos();
            dtUsuarios.Columns[0].Visible = false;
            dtUsuarios.Columns[1].HeaderText = "Usuario";
            dtUsuarios.Columns[2].HeaderText = "Empleado";
            dtUsuarios.Columns[3].HeaderText = "Tipo de usuario";
            dtUsuarios.Columns[4].HeaderText = "Estado";
        }
        private void MostrarDatos() 
        {
            dtUsuarios.RowHeadersVisible = false;
            dtUsuarios.DataSource = FuncionesUsuarios.BuscarUsuarios();
            dtUsuarios.Columns[0].Visible = false;
            dtUsuarios.Columns[1].HeaderText = "Usuario";
            dtUsuarios.Columns[2].HeaderText = "Empleado";
            dtUsuarios.Columns[3].HeaderText = "Tipo de usuario";
            dtUsuarios.Columns[4].HeaderText = "Estado";
        }
        private void BuscarUsuario()
        {
            DataView view = FuncionesUsuarios.BuscarUsuarios().DefaultView;
            view.RowFilter = string.Format("usuario LIKE '%{0}%' OR nombre_empleado LIKE '%{0}%'", txtBuscar.Text);
            dtUsuarios.DataSource = view.ToTable();
            dtUsuarios.RowHeadersVisible = false;
        }

        private void IngresarUsuario() 
        {

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                us.usuario = txtUsuario.Text;
                us.id_empleado = Convert.ToInt16(cmbEmpleado.SelectedValue);
                us.id_estado_usuario = Convert.ToInt16(cmbEstado.SelectedValue);
                us.id_tipo_usuario = Convert.ToInt16(cmbTipo.SelectedValue);
                FuncionesUsuarios.IngresarUsuario(us);
                MostrarDatos();
            }
        }

        private void ReiniciarUsuario() 
        {
            us.usuario = txtUsuario.Text;
            ConstructorUsuarios.id_usuario = Convert.ToInt16(txtIDUsuario.Text);
            FuncionesUsuarios.ReiniciarUsuario(us);
            MostrarDatos();
        }

        private void ActualizarUsuario() 
        {
            us.usuario = txtUsuario.Text;
            ConstructorUsuarios.id_usuario = Convert.ToInt16(txtIDUsuario.Text);
            us.id_tipo_usuario = Convert.ToInt16(cmbTipo.SelectedValue);
            us.id_estado_usuario = Convert.ToInt16(cmbEstado.SelectedValue);
            FuncionesUsuarios.ActualizarUsuario(us);
            MostrarDatos();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            IngresarUsuario();
            MostrarDatos();
        }

        private void dtUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDUsuario.Text = dtUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtUsuario.Text = dtUsuarios.CurrentRow.Cells[1].Value.ToString();
            cmbEmpleado.SelectedValue = Validaciones.BuscarIDCombo("id_empleado","nombre_empleado",FuncionesUsuarios.CargarEmpleados(), dtUsuarios.CurrentRow.Cells[2].Value.ToString());
            cmbTipo.SelectedValue = Validaciones.BuscarIDCombo("id_tipo_usuario", "tipo_usuario", FuncionesUsuarios.CargarTipoUsuario(), dtUsuarios.CurrentRow.Cells[3].Value.ToString());
            cmbEstado.SelectedValue = Validaciones.BuscarIDCombo("id_estado_usuario", "estado_usuario", FuncionesUsuarios.CargarEstado(), dtUsuarios.CurrentRow.Cells[4].Value.ToString());
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarUsuario();
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            MostrarDatosActivos();
        }

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            MostrarDatosInactivos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarUsuario();
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            ReiniciarUsuario();
        }
    }
}
