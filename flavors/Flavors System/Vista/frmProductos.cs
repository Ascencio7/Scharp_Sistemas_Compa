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
            dtProductos.DataSource = FuncionesProductos.MostrarProductos()
        }
        private void Agregar()
        {
            cv.id_tipo_producto = Convert.ToInt32(cmbTipo.SelectedValue);
            cv.nombre_producto = Convert.ToString(txtProducto.Text);
            cv.precio_producto = Convert.ToDecimal(txtPrecio.Text);
            cv.descripcion_producto = Convert.ToString(txtDescripcion.Text);
            FuncionesProductos.
            MostrarDatos();
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
            DataView view = FuncionesProductos.MostrarProductos().DefaultView;
            view.RowFilter = string.Format("nombre_producto LIKE '%{0}%', txtBuscarProducto.Text");
            dtProductos.DataSource = view.ToTable();
        }
        private void ActualizarProducto()
        {
            cv.id_tipo_producto = Convert.ToInt32(cmbTipo.SelectedValue);
            cv.nombre_producto = Convert.ToString(txtProducto.Text);
            cv.precio_producto = Convert.ToDecimal(txtPrecio.Text);
            cv.descripcion_producto = Convert.ToString(txtDescripcion.Text);
            FuncionesProductos.ActualizarProducto(cv);
            MostrarDatos();
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

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarProducto();
        }
    }
}
