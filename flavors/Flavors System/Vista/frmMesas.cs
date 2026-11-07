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
    public partial class frmMesas : Form
    {
        ConstructorMesas cv = new ConstructorMesas();
        public frmMesas()
        {
            InitializeComponent();
        }
        private void BuscarMesa()
        {
            DataView view = FuncionesMesas.MostrarMesas().DefaultView;
            view.RowFilter = string.Format("mesa LIKE '%{0}%'", txtBuscar.Text);
            dtMesas.DataSource = view.ToTable();
            dtMesas.DataSource = view.ToTable();
            dtMesas.RowHeadersVisible = false;
            btnLimpiar.Enabled = true;
        }
        private void Agregar()
        {
            if (txtMesa.Text == "" || txtCapacidad.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cv.id_zona = Convert.ToInt32(cmbZona.SelectedValue);
                cv.mesa = Convert.ToInt32(txtMesa.Text);
                cv.capacidad = Convert.ToInt32(txtCapacidad.Text);
                FuncionesMesas.AgregarMesa(cv);
                MostrarDatos();
            }
        }
        private void MostrarDatos()
        {
            dtMesas.RowHeadersVisible = false;
            dtMesas.DataSource = FuncionesMesas.MostrarMesas();
            dtMesas.Columns[0].Visible = false;
            dtMesas.Columns[1].HeaderText = "Número de mesa";
            dtMesas.Columns[2].HeaderText = "Zona";
            dtMesas.Columns[3].HeaderText = "Capacidad";
        }
        private void LlenarZonas()
        {
            cmbZona.DataSource = FuncionesMesas.MostrarZonas();
            cmbZona.DisplayMember = "zona"; //nombre de la zona
            cmbZona.ValueMember = "id_zona"; //mandar id
            cmbZona.Text = "Seleccione";
        }
        private void ActualizarMesas()
        {
            if (txtMesa.Text == "" || txtCapacidad.Text == "")
            {
                MessageBox.Show("Por favor, llene todos los campos", "Datos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cv.id_mesa = Convert.ToInt32(txtIdMesa.Text);
                cv.id_zona = Convert.ToInt32(cmbZona.SelectedValue);
                cv.mesa = Convert.ToInt32(txtMesa.Text);
                cv.capacidad = Convert.ToInt32(txtCapacidad.Text);
                FuncionesMesas.ActualizarMesas(cv);
                MostrarDatos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMesa.Clear();
            txtCapacidad.Clear();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        { 
                BuscarMesa();  
        }

        private void frmMesas_Load(object sender, EventArgs e)
        {
            LlenarZonas();
            MostrarDatos();
        }

        private void dtMesas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdMesa.Text = dtMesas.CurrentRow.Cells[0].Value.ToString();
            txtMesa.Text = dtMesas.CurrentRow.Cells[1].Value.ToString();
            cmbZona.Text = dtMesas.CurrentRow.Cells[2].Value.ToString();
            txtCapacidad.Text = dtMesas.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarMesas();
        }
    }
}