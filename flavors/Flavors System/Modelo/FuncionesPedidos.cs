using Flavors_System.Controlador;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Flavors_System.Modelo
{
    internal class FuncionesPedidos
    {
        //Mostrar las ventas realizadas
        public static DataTable MostrarPedidos()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM tbPedidos";
                SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }

        public static DataTable MostrarProductos()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM tbProductos";
                SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }

        public static DataTable MostrarTipos() 
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM tbTipoPedidos";
                SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }

        public static int ContarPedidos() 
        {
            int retorno = 0;
            try
            {
                string query = "SELECT COUNT (*) FROM tbPedidos";
                SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
                retorno = Convert.ToInt32(cmd.ExecuteScalar());
                return retorno + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int CrearPedido(ConstructorPedidos cr) 
        {
            int retorno = 0;
            try
            {
                string crear = "INSERT INTO tbPedidos (id_mesa, id_cliente, id_tipo_pedido, fechahora, total) VALUES (@id_mesa, @id_cliente, @id_tipo_pedido, @fechahora, 0)";
                SqlCommand cmd = new SqlCommand(crear, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@id_mesa", cr.id_mesa);
                cmd.Parameters.AddWithValue("@id_usuario", cr.id_usuario);
                cmd.Parameters.AddWithValue("@id_cliente", cr.id_cliente);
                cmd.Parameters.AddWithValue("@id_tipo_pedido", cr.id_tipo_pedido);
                cmd.Parameters.AddWithValue("@fechahora", cr.fechahora);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("El pedido ha sido creado exitosamente, ingrese productos al detalle", "Pedido creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("El pedido no fue creado correctamente", "Pedido no creado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static DataTable MostrarDetalles(ConstructorPedidos m)
        {
            DataTable data = new DataTable();
            try
            {
                string mostrar = "SELECT p.nombre_producto, d.cantidad, d.subtotal FROM tbDetallePedidos d, tbProductos p WHERE d.id_producto = p.id_producto AND id_pedido = @id_pedido";
                SqlCommand cmd = new SqlCommand(mostrar, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@id_pedido", m.id_pedido);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(data);
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return data;
            }
        }

        public static decimal CargarPrecio(ConstructorProductos p) 
        {
            decimal retorno = 0;
            try
            {
                string mostrar = "SELECT precio_producto FROM tbProductos WHERE id_producto = @id_producto";
                SqlCommand cmd = new SqlCommand(mostrar, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@id_producto", p.id_producto);
                retorno = Convert.ToDecimal(cmd.ExecuteScalar());
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int IngresarDetalle(ConstructorDetalles d)
        {
            int retorno = 0;
            try
            {

                string query = "INSERT INTO tbDetallePedidos (id_pedido, id_producto, cantidad, subtotal) VALUES (@id_pedido, @id_producto, @cantidad, 0)";
                SqlCommand cmd = new SqlCommand(query, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@id_pedido", d.id_pedido);
                cmd.Parameters.AddWithValue("@id_producto", d.id_producto);
                cmd.Parameters.AddWithValue("@cantidad", d.cantidad);
                cmd.Parameters.AddWithValue("subtotal", d.subtotal);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    string getid = "SELECT id_detalle_pedido FROM tbDetallePedidos WHERE id_pedido = @id_pedido AND id_producto = @id_producto AND cantidad = @cantidad";
                    SqlCommand get = new SqlCommand(getid, Conexion.Conectar());
                    get.Parameters.AddWithValue("@id_pedido", d.id_pedido);
                    get.Parameters.AddWithValue("@id_producto", d.id_producto);
                    get.Parameters.AddWithValue("@cantidad", d.cantidad);
                    retorno = Convert.ToInt32(get.ExecuteScalar());
                    string setsub = "UPDATE tbDetallePedidos SET subtotal = @subtotal WHERE id_detalle_pedido = @id_detalle_pedido";
                    SqlCommand set = new SqlCommand(setsub, Conexion.Conectar());
                    d.subtotal = d.cantidad * d.precio;
                    set.Parameters.AddWithValue("@subtotal", d.subtotal);
                    set.Parameters.AddWithValue("@id_detalle_pedido", retorno);
                    retorno = Convert.ToInt32(set.ExecuteNonQuery());
                    if (retorno >= 1)
                    {
                        return retorno;
                    }
                    else
                    {
                        MessageBox.Show("El producto fue ingresado pero sin subtotal", "Producto agregado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return retorno;
                    }
                }
                else
                {
                    MessageBox.Show("El producto no fue agregado al detalle", "Producto no agregado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static decimal CalcularTotal(ConstructorPedidos p) 
        {
            decimal retorno = 0;
            try
            {
                string calcular = "SELECT SUM(subtotal) FROM tbDetallePedidos WHERE id_pedido = @id_pedido";
                SqlCommand cmd = new SqlCommand(calcular, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@id_pedido", p.id_pedido);
                retorno = Convert.ToDecimal(cmd.ExecuteScalar());
                if (retorno >= 1)
                {
                    string upd = "UPDATE tbPedidos SET total = @total WHERE id_pedido = @id_pedido";
                    SqlCommand cmd2 = new SqlCommand(upd, Conexion.Conectar());
                    cmd2.Parameters.AddWithValue("@total", retorno);
                    cmd2.Parameters.AddWithValue("@id_pedido", p.id_pedido);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("No se pudo calcular el total", "Error de calculo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
