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
    internal class FuncionesClientes
    {
        public static DataTable MostrarClientesActivos()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT e.id_cliente, e.nombre_cliente,  e.correo, e.direccion, e.telefono, es.estado_cliente FROM tbClientes e, tbEstadoClientes es WHERE e.id_estado_cliente = 1 AND e.id_estado_cliente = es.id_estado_cliente";
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

        public static DataTable MostrarClientes() 
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM tbClientes";
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

        public static DataTable MostrarClientesInactivos()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT e.id_cliente, e.nombre_cliente, e.correo, e.direccion, e.telefono, es.estado_cliente FROM tbClientes e, tbEstadoClientes es WHERE e.id_estado_cliente= es.id_estado_cliente AND e.id_estado_cliente = 2";
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

        public static int IngresarClientes(ConstructorClientes add)
        {
            int retorno = 0;
            try
            {
                string verificar = "SELECT * FROM tbClientes WHERE telefono = @telefono";
                SqlCommand check = new SqlCommand(verificar, Conexion.Conectar());
                check.Parameters.AddWithValue("@telefono", add.telefono);
                retorno = Convert.ToInt32(check.ExecuteScalar());
                if (retorno == 0)
                {
                    string insertar = "INSERT INTO tbClientes (nombre_cliente, correo,  direccion, telefono, id_estado_cliente) VALUES (@nombre_cliente,  @correo, @direccion, @telefono, 1)";
                    SqlCommand cmd = new SqlCommand(insertar, Conexion.Conectar());
                    cmd.Parameters.AddWithValue("@nombre_cliente", add.nombre_cliente);
                    cmd.Parameters.AddWithValue("@correo", add.correo);
                    cmd.Parameters.AddWithValue("@direccion", add.direccion);
                    cmd.Parameters.AddWithValue("@telefono", add.telefono);
                    cmd.Parameters.AddWithValue("@id_estado_cliente", add.id_estado_cliente);
                    retorno = cmd.ExecuteNonQuery();
                    if (retorno >= 1)
                    {
                        MessageBox.Show("El cliente se registró correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return retorno;
                    }
                    else
                    {
                        MessageBox.Show("El cliente no se registró correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return retorno;
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un registro con el mismo telefono, ingrese un dato diferente", "Duplicidad de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int ActualizarClientes(ConstructorClientes act)
        {
            int retorno = 0;
            try
            {
                string actualizar = "UPDATE tbClientes SET nombre_cliente = @nombre_cliente, correo = @correo,  direccion = @direccion, telefono = @telefono, id_estado_cliente = @id_estado_cliente WHERE id_cliente = @id_cliente";
                SqlCommand cmd = new SqlCommand(actualizar, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@nombre_cliente", act.nombre_cliente);
                cmd.Parameters.AddWithValue("@correo", act.correo);
                cmd.Parameters.AddWithValue("@direccion", act.direccion);
                cmd.Parameters.AddWithValue("@telefono", act.telefono);
                cmd.Parameters.AddWithValue("@id_cliente", act.id_cliente);
                cmd.Parameters.AddWithValue("@id_estado_cliente", act.id_estado_cliente);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("El cliente se actualizó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("El cliente no se actualizó correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static DataTable BuscarClientes()
        {
            DataTable table = new DataTable();
            try
            {
                string query = "SELECT e.id_cliente, e.nombre_cliente,   e.direccion,e.telefono, es.estado_cliente FROM tbClientes e, tbEstadoClientes es WHERE e.id_estado_cliente = es.id_estado_cliente";
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

        public static int EliminarClientes(ConstructorClientes eli)
        {
            int retorno = 0;
            try
            {
                string eliminar = "UPDATE tbClientes SET id_estado_cliente = 2 WHERE id_cliente = @id_cliente";
                SqlCommand cmd = new SqlCommand(eliminar, Conexion.Conectar());
                cmd.Parameters.AddWithValue("id_cliente", eli.id_cliente);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("El cliente se inhabilitó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("El cliente no se inhabilitó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int ReactivarClientes(ConstructorClientes eli)
        {
            int retorno = 0;
            try
            {
                string eliminar = "UPDATE tbClientes SET id_estado_cliente = 1 WHERE id_cliente = @id_cliente";
                SqlCommand cmd = new SqlCommand(eliminar, Conexion.Conectar());
                cmd.Parameters.AddWithValue("id_cliente", eli.id_cliente);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("El cliente se habilitó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("El cliente no se habilitó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static DataTable CargarEstadoClientes()
        {
            DataTable dt = new DataTable();
            try
            {
                string cmd = "SELECT * FROM tbEstadoClientes";
                SqlDataAdapter cmdselect = new SqlDataAdapter(cmd, Conexion.Conectar());
                cmdselect.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos" + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }
    }
}

