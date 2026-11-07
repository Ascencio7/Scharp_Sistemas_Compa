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
    public partial class frmEmpleados : Form
    {
        ConstructorEmpleados emp = new ConstructorEmpleados();
        public static frmEmpleados instancia;
        public static frmEmpleados Instancia
        {
            get { return instancia; }
        }

        public frmEmpleados()
        {
            instancia = this;
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            MostrarDatosActivos();
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            dtFecha.MaxDate = DateTime.Today.AddYears(-18);
        }

        private void BuscarEmpleado() 
        {
            DataView view = FuncionesEmpleados.BuscarEmpleados().DefaultView;
            view.RowFilter = string.Format("nombre_empleado LIKE '%{0}%' OR dui LIKE '%{0}%'", txtBuscar.Text);
            dtEmpleados.DataSource = view.ToTable();
            dtEmpleados.RowHeadersVisible = false;
        }

        private void MostrarDatosActivos() 
        {
            dtEmpleados.RowHeadersVisible = false;
            dtEmpleados.DataSource = FuncionesEmpleados.MostrarEmpleadosActivos();
            // Configurar una columna con ancho fijo
            dtEmpleados.Columns[1].Width = 140;
            dtEmpleados.Columns[0].Visible = false;
            dtEmpleados.Columns[1].HeaderText = "Nombre del empleado";
            dtEmpleados.Columns[2].HeaderText = "Fecha de nacimiento";
            dtEmpleados.Columns[3].HeaderText = "DUI";
            dtEmpleados.Columns[4].HeaderText = "Teléfono";
            dtEmpleados.Columns[5].Visible = false;
            dtEmpleados.Columns[6].HeaderText = "Estado";
        }

        private void MostrarDatosInactivos()
        {
            dtEmpleados.RowHeadersVisible = false;
            dtEmpleados.DataSource = FuncionesEmpleados.MostrarEmpleadosInactivos();
            // Configurar una columna con ancho fijo
            dtEmpleados.Columns[1].Width = 140;
            dtEmpleados.Columns[0].Visible = false;
            dtEmpleados.Columns[1].HeaderText = "Nombre del empleado";
            dtEmpleados.Columns[2].HeaderText = "Fecha de nacimiento";
            dtEmpleados.Columns[3].HeaderText = "DUI";
            dtEmpleados.Columns[4].HeaderText = "Teléfono";
            dtEmpleados.Columns[5].Visible = false;
            dtEmpleados.Columns[6].HeaderText = "Estado";
        }

        public void InsertarEmpleado() 
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || txtDui.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                emp.nombre_empleado = txtNombre.Text;
                emp.fecha_nacimiento = dtFecha.Value;
                emp.dui = txtDui.Text;
                emp.telefono = txtTelefono.Text;
                emp.direccion = txtDireccion.Text;
                FuncionesEmpleados.IngresarEmpleados(emp);
                MostrarDatosActivos();
                LimpiarCampos();
            }
        }

        public void ActualizarEmpleados() 
        {
            if (txtNombre.Text == "" || txtDireccion.Text == "" || txtDui.Text == "" || txtTelefono.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                emp.id_empleado = Convert.ToInt32(txtIDEmpleado.Text);
                emp.nombre_empleado = txtNombre.Text;
                emp.fecha_nacimiento = dtFecha.Value;
                emp.dui = txtDui.Text;
                emp.telefono = txtTelefono.Text;
                emp.direccion = txtDireccion.Text;
                FuncionesEmpleados.ActualizarEmpleado(emp);
                MostrarDatosActivos();
                btnCrear.Enabled = true;
                btnEliminar.Enabled = false;
                btnActualizar.Enabled = false;
                LimpiarCampos();
            }
        }

        public void DeshabilitarEmpleado() 
        {
            emp.id_empleado = Convert.ToInt32(txtIDEmpleado.Text);
            FuncionesEmpleados.EliminarEmpleado(emp);
            MostrarDatosActivos();
            LimpiarCampos();
        }

        public void HabilitarEmpleado() 
        {
            emp.id_empleado = Convert.ToInt32(txtIDEmpleado.Text);
            FuncionesEmpleados.ReactivarEmpleado(emp);
            MostrarDatosActivos();
            LimpiarCampos();
        }

        private void LimpiarCampos() 
        {
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtBuscar.Clear();
            txtDui.Clear();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            InsertarEmpleado();
        }

        private void dtEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIDEmpleado.Text = dtEmpleados.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dtEmpleados.CurrentRow.Cells[1].Value.ToString();
            txtDui.Text = dtEmpleados.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dtEmpleados.CurrentRow.Cells[4].Value.ToString();
            txtDireccion.Text = dtEmpleados.CurrentRow.Cells[5].Value.ToString();

            btnCrear.Enabled = false;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarEmpleados();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (btnEliminar.Text == "Deshabilitar")
            {
                DeshabilitarEmpleado();
            }
            else if (btnEliminar.Text == "Habilitar")
            {
                HabilitarEmpleado();
            }
            btnCrear.Enabled = true;
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
        }

        private void btnActivos_Click(object sender, EventArgs e)
        {
            btnEliminar.Text = "Deshabilitar";
            MostrarDatosActivos();
        }

        private void btnInactivos_Click(object sender, EventArgs e)
        {
            MostrarDatosInactivos();
            btnEliminar.Text = "Habilitar";
        }
    }
}
