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
    internal class FuncionesMesas
    {
        public static DataTable MostrarMesas()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT * FROM tbMesas";
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
        public static int AgregarMesa(ConstructorMesas mesa)
        {
            int retorno = 0;
            try
            {
                string agregarmesa = "INSERT INTO tbMesas(id_zona, mesa, capacidad) VALUES(@zona, @mesa, @capacidad)";
                SqlCommand cmd = new SqlCommand(agregarmesa, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@zona", mesa.id_zona);
                cmd.Parameters.AddWithValue("@mesa", mesa.mesa);
                cmd.Parameters.AddWithValue("@capacidad", mesa.capacidad);
                retorno = cmd.ExecuteNonQuery();

                //mensaje sobre el resultado de la inserción
                if (retorno >= 1)
                {
                    MessageBox.Show("Mesa añadida correctamente", "Mesa ingresada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("La mesa no ha sido añadida", "Mesa no ingresada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return retorno;
            }
        }
        public static DataTable MostrarZonas()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT id_zona, zona FROM tbZonas";
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
        public static int ActualizarMesas(ConstructorMesas act)
        {
            int retorno = 0;
            try
            {
                string actualizar = "UPDATE tbMesas SET id_zona = @id_zona, mesa = @mesa, capacidad = @capacidad WHERE id_mesa = @id_mesa";
                SqlCommand cmd = new SqlCommand(actualizar, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@id_mesa", act.id_mesa);
                cmd.Parameters.AddWithValue("@id_zona", act.id_zona);
                cmd.Parameters.AddWithValue("@mesa", act.mesa);
                cmd.Parameters.AddWithValue("@capacidad", act.capacidad);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("La mesa se actualizó correctamente", "Proceso completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("La mesa no se actualizó correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
        public static DataTable BuscarMesa()
        {
            DataTable table = new DataTable();
            try
            {
                string query = "SELECT e.id_mesa, e.id_zona, e.mesa, e.capacidad FROM tbMesas e";
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
