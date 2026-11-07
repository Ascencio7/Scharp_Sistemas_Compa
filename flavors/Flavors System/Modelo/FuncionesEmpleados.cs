using Flavors_System.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flavors_System.Modelo
{
    internal class FuncionesEmpleados
    {
        public static DataTable MostrarEmpleadosActivos() 
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT e.id_empleado, e.nombre_empleado, e.fecha_nacimiento, e.dui, e.telefono, e.direccion, es.estado_empleado FROM tbEmpleados e, tbEstadoEmpleados es WHERE e.id_estado_empleado = 1 AND e.id_estado_empleado = es.id_estado_empleado";
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

        public static DataTable MostrarEmpleadosInactivos()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT e.id_empleado, e.nombre_empleado, e.fecha_nacimiento, e.dui, e.telefono, e.direccion, es.estado_empleado FROM tbEmpleados e, tbEstadoEmpleados es WHERE e.id_estado_empleado = es.id_estado_empleado AND e.id_estado_empleado = 2";
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

        public static int IngresarEmpleados(ConstructorEmpleados add) 
        {
            int retorno = 0;
            try
            {
                string verificar = "SELECT * FROM tbEmpleados WHERE dui = @dui";
                SqlCommand check = new SqlCommand(verificar, Conexion.Conectar());
                check.Parameters.AddWithValue("@dui", add.dui);
                retorno = Convert.ToInt32(check.ExecuteScalar());
                if (retorno == 0)
                {
                    string insertar = "INSERT INTO tbEmpleados (nombre_empleado, fecha_nacimiento, dui, telefono, direccion, id_estado_empleado) VALUES (@nombre_empleado, @fecha_nacimiento, @dui, @telefono, @direccion, 1)";
                    SqlCommand cmd = new SqlCommand(insertar, Conexion.Conectar());
                    cmd.Parameters.AddWithValue("@nombre_empleado", add.nombre_empleado);
                    cmd.Parameters.AddWithValue("@fecha_nacimiento", add.fecha_nacimiento);
                    cmd.Parameters.AddWithValue("@dui", add.dui);
                    cmd.Parameters.AddWithValue("@telefono", add.telefono);
                    cmd.Parameters.AddWithValue("@direccion", add.direccion);
                    retorno = cmd.ExecuteNonQuery();
                    if (retorno >= 1)
                    {
                        MessageBox.Show("El empleado se registró correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return retorno;
                    }
                    else
                    {
                        MessageBox.Show("El empleado no se registró correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return retorno;
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un registro con el mismo DUI, ingrese un dato diferente", "Duplicidad de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int ActualizarEmpleado(ConstructorEmpleados act)
        {
            int retorno = 0;
            try
            {
                string actualizar = "UPDATE tbEmpleados SET nombre_empleado = @nombre_empleado, fecha_nacimiento = @fecha_nacimiento, dui = @dui, telefono = @telefono, direccion = @direccion WHERE id_empleado = @id_empleado";
                SqlCommand cmd = new SqlCommand(actualizar, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@nombre_empleado", act.nombre_empleado);
                cmd.Parameters.AddWithValue("@fecha_nacimiento", act.fecha_nacimiento);
                cmd.Parameters.AddWithValue("@dui", act.dui);
                cmd.Parameters.AddWithValue("@telefono", act.telefono);
                cmd.Parameters.AddWithValue("@direccion", act.direccion);
                cmd.Parameters.AddWithValue("@id_empleado", act.id_empleado);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("El empleado se actualizó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("El empleado no se actualizó correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static DataTable BuscarEmpleados() 
        {
            DataTable table = new DataTable();
            try
            {
                string query = "SELECT e.id_empleado, e.nombre_empleado, e.fecha_nacimiento, e.dui, e.telefono, e.direccion, es.estado_empleado FROM tbEmpleados e, tbEstadoEmpleados es WHERE e.id_estado_empleado = es.id_estado_empleado";
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

        public static int EliminarEmpleado(ConstructorEmpleados eli) 
        {
            int retorno = 0;
            try
            {
                string eliminar = "UPDATE tbEmpleados SET id_estado_empleado = 2 WHERE id_empleado = @id_empleado";
                SqlCommand cmd = new SqlCommand(eliminar, Conexion.Conectar());
                cmd.Parameters.AddWithValue("id_empleado", eli.id_empleado);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("El empleado se inhabilitó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("El empleado no se inhabilitó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int ReactivarEmpleado(ConstructorEmpleados eli)
        {
            int retorno = 0;
            try
            {
                string eliminar = "UPDATE tbEmpleados SET id_estado_empleado = 1 WHERE id_empleado = @id_empleado";
                SqlCommand cmd = new SqlCommand(eliminar, Conexion.Conectar());
                cmd.Parameters.AddWithValue("id_empleado", eli.id_empleado);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("El empleado se habilitó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("El empleado no se habilitó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
