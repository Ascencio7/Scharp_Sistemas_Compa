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
    public partial class frmClientes : Form
    {

        ConstructorClientes client = new ConstructorClientes();
        public static frmClientes instancia;
        public static frmClientes Instancia
        {
            get { return instancia; }
        }

        public frmClientes()
        {
            InitializeComponent();
        }


        private void frmClientes_Load(object sender, EventArgs e)
        {
            MostrarClientesActivos();
            LlenarEstadoClientes();
            btnElminarClientes.Enabled = false;
            btnActualizarClientes.Enabled = false;

        }

        private void BuscarClientes()
        {
            DataView view = FuncionesClientes.BuscarClientes().DefaultView;
            view.RowFilter = string.Format("nombre_cliente LIKE '%{0}%' OR telefono LIKE '%{0}%'", txtBuscarClientes.Text);
            dtClientes.DataSource = view.ToTable();
            dtClientes.RowHeadersVisible = false;
        }


        private void MostrarClientesActivos()
        {
            dtClientes.RowHeadersVisible = false;
            dtClientes.DataSource = FuncionesClientes.MostrarClientesActivos();
            // Configurar una columna con ancho fijo
            dtClientes.Columns[1].Width = 140;
            dtClientes.Columns[0].Visible = false;
            dtClientes.Columns[1].HeaderText = "Nombre del cliente";
            dtClientes.Columns[2].HeaderText = "correo";
            dtClientes.Columns[3].HeaderText = "direccion";
            dtClientes.Columns[4].HeaderText = "Teléfono";
            dtClientes.Columns[5].HeaderText = "Estado";
        }


        private void MostrarClientesInactivos()
        {
            dtClientes.RowHeadersVisible = false;
            dtClientes.DataSource = FuncionesClientes.MostrarClientesInactivos();
            // Configurar una columna con ancho fijo
            dtClientes.Columns[1].Width = 140;
            dtClientes.Columns[0].Visible = false;
            dtClientes.Columns[1].HeaderText = "Nombre del cliente";
            dtClientes.Columns[2].HeaderText = "correo";
            dtClientes.Columns[3].HeaderText = "direccion";
            dtClientes.Columns[4].HeaderText = "Teléfono";
            dtClientes.Columns[5].HeaderText = "Estado";
        }


        public void InsertarClientes()
        {
            if (txtNombreClientes.Text == "" || txtCorreoClientes.Text == "" || txtDireccionCliente.Text == "" || txtTelefonoClientes.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                client.nombre_cliente = txtNombreClientes.Text;
                client.correo = txtCorreoClientes.Text;
                client.direccion = txtDireccionCliente.Text;
                client.telefono = txtTelefonoClientes.Text;
                FuncionesClientes.IngresarClientes(client);
                MostrarClientesActivos();
                LimpiarCampos();
            }
        }


        public void ActualizarClientes()
        {
            if (txtNombreClientes.Text == "" || txtCorreoClientes.Text == "" || txtDireccionCliente.Text == "" || txtTelefonoClientes.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                client.id_estado_cliente = Convert.ToInt32(cmbEstadoCliente.SelectedValue);
                client.id_cliente = Convert.ToInt32(txtIdClientes.Text);
                client.nombre_cliente = txtNombreClientes.Text;
                client.correo = txtCorreoClientes.Text;
                client.direccion = txtDireccionCliente.Text;
                client.telefono = txtTelefonoClientes.Text;
                FuncionesClientes.ActualizarClientes(client);
                MostrarClientesActivos();
                btnAgregarClientes.Enabled = true;
                btnElminarClientes.Enabled = false;
                btnActualizarClientes.Enabled = false;
                LimpiarCampos();
            }
        }


        public void DeshabilitarClientes()
        {
            client.id_cliente = Convert.ToInt32(txtIdClientes.Text);
            FuncionesClientes.EliminarClientes(client);
            MostrarClientesActivos();
            LimpiarCampos();
        }

        public void HabilitarClientes()
        {
            client.id_cliente = Convert.ToInt32(txtIdClientes.Text);
            FuncionesClientes.ReactivarClientes(client);
            MostrarClientesActivos();
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombreClientes.Clear();
            txtCorreoClientes.Clear();
            txtDireccionCliente.Clear();
            txtBuscarClientes.Clear();
            txtTelefonoClientes.Clear();
        }




        private void btnAgregarClientes_Click(object sender, EventArgs e)
        {
            InsertarClientes();
        }


        private void dtClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdClientes.Text = dtClientes.CurrentRow.Cells[0].Value.ToString();
            txtNombreClientes.Text = dtClientes.CurrentRow.Cells[1].Value.ToString();
            txtCorreoClientes.Text = dtClientes.CurrentRow.Cells[2].Value.ToString();
            txtDireccionCliente.Text = dtClientes.CurrentRow.Cells[3].Value.ToString();
            txtTelefonoClientes.Text = dtClientes.CurrentRow.Cells[4].Value.ToString();

            btnAgregarClientes.Enabled = false;
            btnActualizarClientes.Enabled = true;
            btnElminarClientes.Enabled = true;

        }

        private void btnActualizarClientes_Click(object sender, EventArgs e)
        {
            ActualizarClientes();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            btnAgregarClientes.Enabled = true;
        }

        private void txtBuscarClientes_TextChanged(object sender, EventArgs e)
        {
            BuscarClientes();
        }

        private void btnElminarClientes_Click(object sender, EventArgs e)
        {
            if (btnElminarClientes.Text == "Deshabilitar")
            {
                DeshabilitarClientes();
            }
            else if (btnElminarClientes.Text == "Habilitar")
            {
                HabilitarClientes();
            }
            btnAgregarClientes.Enabled = true;
            btnElminarClientes.Enabled = false;
            btnActualizarClientes.Enabled = false;
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            btnElminarClientes.Text = "Deshabilitar";
            MostrarClientesActivos();
        }

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            MostrarClientesInactivos();
            btnElminarClientes.Text = "Habilitar";
        }

        private void LlenarEstadoClientes()
        {
            cmbEstadoCliente.DataSource = FuncionesClientes.CargarEstadoClientes();
            cmbEstadoCliente.DisplayMember = "estado_cliente";
            cmbEstadoCliente.ValueMember = "id_estado_cliente";
        }


    }
}
