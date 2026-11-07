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

namespace Flavors_System.Vista
{
    public partial class frmProductos : Form
    {
        ConstructorProductos cv = new ConstructorProductos();
        public frmProductos()
        {
            InitializeComponent();
        }
        private void MostrarDatos()
        {
            dtProductos.RowHeadersVisible = false;
            dtProductos.DataSource = FuncionesProductos.MostrarProductos();
            dtProductos.Columns[0].Visible = false;
            dtProductos.Columns[1].HeaderText = "Tipo de producto";
            dtProductos.Columns[2].HeaderText = "Producto";
            dtProductos.Columns[3].HeaderText = "Precio";
            dtProductos.Columns[4].HeaderText = "Descripción";
        }
        private void Agregar()
        {
            if (txtProducto.Text == "" || txtPrecio.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cv.id_tipo_producto = Convert.ToInt32(cmbTipo.SelectedValue);
                cv.nombre_producto = Convert.ToString(txtProducto.Text);
                cv.precio_producto = Convert.ToDecimal(txtPrecio.Text);
                cv.descripcion_producto = Convert.ToString(txtDescripcion.Text);
                FuncionesProductos.AgregarProducto(cv);
                MostrarDatos();
            }
        }
        private void ActualizarProductos()
        {
            if (txtProducto.Text == "" || txtPrecio.Text == "" || txtDescripcion.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cv.id_producto = Convert.ToInt32(txtIdProducto.Text);
                cv.id_tipo_producto = Convert.ToInt32(cmbTipo.SelectedValue);
                cv.nombre_producto = txtProducto.Text;
                cv.precio_producto = Convert.ToDecimal(txtPrecio.Text);
                cv.descripcion_producto = txtDescripcion.Text;
                FuncionesProductos.ActualizarProducto(cv);
                MostrarDatos();
                btnGuardar.Enabled = true;
                btnEliminar.Enabled = false;
                btnLimpiar.Enabled = false;
            }
        }
        private void LlenarTipos()
        {
            cmbTipo.DataSource = FuncionesProductos.MostrarTipos();
            cmbTipo.DisplayMember = "tipo_producto";
            cmbTipo.ValueMember = "id_tipo_producto"; //mandar id
            cmbTipo.Text = "Seleccione";

        }
        private void BuscarProducto()
        {
            DataView view = FuncionesProductos.BuscarProducto().DefaultView;
            view.RowFilter = string.Format("nombre_producto LIKE '%{0}%'", txtBuscarProducto.Text);
            dtProductos.DataSource = view.ToTable();
            dtProductos.RowHeadersVisible = false;
            btnLimpiar.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtProducto.Clear();
            txtPrecio.Clear();
            txtDescripcion.Clear();
        }

        private void txtBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            LlenarTipos();
            MostrarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ActualizarProductos();
        }

        private void dtProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdProducto.Text = dtProductos.CurrentRow.Cells[0].Value.ToString();
            cmbTipo.Text = dtProductos.CurrentRow.Cells[1].Value.ToString();
            txtProducto.Text = dtProductos.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dtProductos.CurrentRow.Cells[3].Value.ToString();
            txtDescripcion.Text = dtProductos.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
