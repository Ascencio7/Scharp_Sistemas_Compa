using Flavors_System.Controlador;
using Flavors_System.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flavors_System.Vista
{
    public partial class frmCrearPedidos : Form
    {
        ConstructorPedidos cv = new ConstructorPedidos();
        public frmCrearPedidos()
        {
            InitializeComponent();
        }
        private void frmCrearPedidos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarMesas();
            CargarClientes();
            CargarTipos();
            txtPedido.Text = FuncionesPedidos.ContarPedidos().ToString();
            txtTotal.Text = "0.00";
        }

        private void CrearPedido() 
        {
            frmPrincipal pr = new frmPrincipal();
            ConstructorPedidos cr = new ConstructorPedidos();
            cr.id_mesa = Convert.ToInt32(cmbMesa.SelectedValue);
            cr.id_cliente = Convert.ToInt32(cmbCliente.SelectedValue);
            cr.id_tipo_pedido = Convert.ToInt32(cmbTipo.SelectedValue);
            cr.fechahora = dtFecha.Value;
            FuncionesPedidos.CrearPedido(cr);
            btnCrearPedido.Text = "Cerrar";
        }

        private void AgregarDetalle() 
        {
            ConstructorDetalles d = new ConstructorDetalles();

            d.id_pedido = Convert.ToInt32(txtPedido.Text);
            d.id_producto = Convert.ToInt16(cmbProducto.SelectedValue);
            d.cantidad = Convert.ToInt16(numCantidad.Value);
            d.precio = Convert.ToDecimal(txtPrecio.Text);
            FuncionesPedidos.IngresarDetalle(d);
            txtTotal.Text = FuncionesPedidos.CalcularTotal(cv).ToString();
        }
        private void MostrarDetalles() 
        {
            dtDetalle.RowHeadersVisible = false;
            cv.id_pedido = Convert.ToInt16(txtPedido.Text);
            dtDetalle.DataSource = FuncionesPedidos.MostrarDetalles(cv);
            dtDetalle.Columns[0].HeaderText = "Producto";
            dtDetalle.Columns[1].HeaderText = "Cantidad";
            dtDetalle.Columns[2].HeaderText = "Subtotal";
        }

        private void CargarProductos() 
        {
            cmbProducto.DataSource = FuncionesPedidos.MostrarProductos();
            cmbProducto.DisplayMember = "nombre_producto"; //nombre del producto
            cmbProducto.ValueMember = "id_producto"; //mandar id
        }
        private void CargarMesas() 
        {
            cmbMesa.DataSource = FuncionesMesas.MostrarMesas();
            cmbMesa.DisplayMember = "mesa";
            cmbMesa.ValueMember = "id_mesa"; //mandar id
        }

        private void CargarClientes() 
        {
            cmbCliente.DataSource = FuncionesClientes.MostrarClientes();
            cmbCliente.DisplayMember = "nombre_cliente";
            cmbCliente.ValueMember = "id_cliente";
        }

        private void CargarTipos() 
        {
            cmbTipo.DataSource = FuncionesPedidos.MostrarTipos();
            cmbTipo.DisplayMember = "tipo_pedido";
            cmbTipo.ValueMember = "id_tipo_pedido";
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            if (btnCrearPedido.Text == "Crear pedido")
            {
                CrearPedido();
                MostrarDetalles();
            }
            else
            {
                CerrarPedido();
            }
            
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            ConstructorProductos p = new ConstructorProductos();
            p.id_producto = Convert.ToInt16(cmbProducto.SelectedValue);
            txtPrecio.Text = FuncionesPedidos.CargarPrecio(p).ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarDetalle();
            MostrarDetalles();
        }

        private void CerrarPedido() 
        {
            MessageBox.Show("La venta fue cerrada, inicie la siguiente", "Venta cerrada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtTotal.Text = "0.00";
            txtPedido.Text = FuncionesPedidos.ContarPedidos().ToString();
            dtDetalle.DataSource = null;
        }
    }
}
