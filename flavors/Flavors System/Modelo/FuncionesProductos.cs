using Flavors_System.Controlador;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flavors_System.Modelo
{
    internal class FuncionesProductos
    {
        public static DataTable MostrarProductos()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT id_producto, id_tipo_producto, nombre_producto, precio_producto, descripcion_producto FROM tbProductos";
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
        public static int AgregarProducto(ConstructorProductos producto)
        {
            int retorno = 0;
            try
            {
                string agregarproducto = "INSERT INTO tbProductos(id_tipo_producto, nombre_producto, precio_producto, descripcion_producto) VALUES(@tipo, @producto, @precio, @descripcion)";
                SqlCommand cmd = new SqlCommand(agregarproducto, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@tipo", producto.id_tipo_producto);
                cmd.Parameters.AddWithValue("@producto", producto.nombre_producto);
                cmd.Parameters.AddWithValue("@precio", producto.precio_producto);
                cmd.Parameters.AddWithValue("@descripcion", producto.descripcion_producto);
                retorno = cmd.ExecuteNonQuery();

                //mensaje sobre el resultado de la inserción
                if (retorno >= 1)
                {
                    MessageBox.Show("Producto añadido correctamente", "Producto ingresado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("El producto no ha sido añadido", "Producto no ingresado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }
        public static DataTable MostrarTipos()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT id_tipo_producto, tipo_producto FROM tbTipoProductos";
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
        public static int ActualizarProducto(ConstructorProductos act)
        {
            int retorno = 0;
            try
            {
                string actualizar = "UPDATE tbProductos SET id_tipo_producto = @id_tipo_producto, nombre_producto = @nombre_producto, precio_producto = @precio_producto, descripcion_producto = @descripcion_producto WHERE id_producto = @id_producto";
                SqlCommand cmd = new SqlCommand(actualizar, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@id_producto", act.id_producto);
                cmd.Parameters.AddWithValue("@id_tipo_producto", act.id_tipo_producto);
                cmd.Parameters.AddWithValue("@nombre_producto", act.nombre_producto);
                cmd.Parameters.AddWithValue("@precio_producto", act.precio_producto);
                cmd.Parameters.AddWithValue("@descripcion_producto", act.descripcion_producto);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("El producto se actualizó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("El producto no se actualizó correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable BuscarProducto()
        {
            DataTable table = new DataTable();
            try
            {
                string query = "SELECT e.id_producto, e.tipo_producto, e.nombre_producto, e.precio_producto, e.descripcion, e.direccion FROM tbProductos e";
                SqlDataAdapter da = new SqlDataAdapter(query, Conexion.Conectar());
                da.Fill(table);
                return table;
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos" + e, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return table;
            }
        }
    }
}
