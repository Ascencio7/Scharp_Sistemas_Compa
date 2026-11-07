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
    internal class FuncionesUsuarios
    {
        public static DataTable CargarEmpleados() 
        {
            DataTable dt = new DataTable();
            try
            {
                string cmd = "SELECT id_empleado, nombre_empleado FROM tbEmpleados";
                SqlDataAdapter cmdselect = new SqlDataAdapter(cmd,Conexion.Conectar());
                cmdselect.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error al obtener los datos" + ex, "Error de conexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return dt;
            }
        }

        public static DataTable CargarTipoUsuario() 
        {
            DataTable dt = new DataTable();
            try
            {
                string cmd = "SELECT * FROM tbTipoUsuarios WHERE id_tipo_usuario != 1";
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

        public static DataTable CargarEstado() 
        {
            DataTable dt = new DataTable();
            try
            {
                string cmd = "SELECT * FROM tbEstadoUsuarios";
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

        public static DataTable BuscarUsuarios()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT u.id_usuario, u.usuario, em.nombre_empleado, t.tipo_usuario, e.estado_usuario FROM tbUsuarios u, tbEstadoUsuarios e, tbTipoUsuarios t, tbEmpleados em WHERE u.id_empleado = em.id_empleado AND u.id_tipo_usuario = t.id_tipo_usuario AND u.id_estado_usuario = e.id_estado_usuario";
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

        public static DataTable MostrarUsuariosActivos() 
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT u.id_usuario, u.usuario, em.nombre_empleado, t.tipo_usuario, e.estado_usuario FROM tbUsuarios u, tbEstadoUsuarios e, tbTipoUsuarios t, tbEmpleados em WHERE u.id_empleado = em.id_empleado AND u.id_tipo_usuario = t.id_tipo_usuario AND u.id_estado_usuario = e.id_estado_usuario AND u.id_estado_usuario = 1";
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

        public static DataTable MostrarUsuariosInactivos()
        {
            DataTable data = new DataTable();
            try
            {
                string query = "SELECT u.id_usuario, u.usuario, em.nombre_empleado, t.tipo_usuario, e.estado_usuario FROM tbUsuarios u, tbEstadoUsuarios e, tbTipoUsuarios t, tbEmpleados em WHERE u.id_empleado = em.id_empleado AND u.id_tipo_usuario = t.id_tipo_usuario AND u.id_estado_usuario = e.id_estado_usuario AND u.id_estado_usuario = 2";
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

        public static int IngresarUsuario(ConstructorUsuarios add) 
        {
            int retorno = 0;
            string usuario = "";
            try
            {
                string verificar = "SELECT * FROM tbUsuarios WHERE usuario = @usuario OR id_empleado = @id_empleado";
                SqlCommand ver = new SqlCommand(verificar, Conexion.Conectar());
                ver.Parameters.AddWithValue("@usuario", add.usuario);
                ver.Parameters.AddWithValue("@id_empleado", add.id_empleado);
                usuario = add.usuario;
                retorno = Convert.ToInt16(ver.ExecuteScalar());
                if (retorno == 0)
                {
                    string insert = "INSERT INTO tbUsuarios (id_tipo_usuario, id_estado_usuario, id_empleado, usuario) VALUES (@id_tipo_usuario, @id_estado_usuario, @id_empleado, @usuario)";
                    SqlCommand cmd = new SqlCommand(insert, Conexion.Conectar());
                    cmd.Parameters.AddWithValue("@id_tipo_usuario", add.id_tipo_usuario);
                    cmd.Parameters.AddWithValue("@id_estado_usuario", add.id_estado_usuario);
                    cmd.Parameters.AddWithValue("@id_empleado", add.id_empleado);
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    retorno = cmd.ExecuteNonQuery();
                    if (retorno >= 1)
                    {
                        string getid = "SELECT id_usuario FROM tbUsuarios WHERE usuario = @usuario";
                        SqlCommand get = new SqlCommand(getid, Conexion.Conectar());
                        get.Parameters.AddWithValue("@usuario", usuario);
                        retorno = Convert.ToInt16(get.ExecuteScalar());
                        string setpass = "UPDATE tbUsuarios SET contrasenia = @usuario + '1234' WHERE id_usuario = @id_usuario";
                        SqlCommand set = new SqlCommand(setpass, Conexion.Conectar());
                        set.Parameters.AddWithValue("@usuario", usuario);
                        set.Parameters.AddWithValue("@id_usuario", retorno);
                        retorno = set.ExecuteNonQuery();
                        if (retorno >= 1)
                        {
                            MessageBox.Show("El usuario fue creado correctamente, el usuario tiene una contraseña predeterminada (usuario + 1234)", "Proceso completado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return retorno;
                        }
                        else
                        {
                            MessageBox.Show("El usuario fue creado pero no se asigno la contraseña", "Error al asignar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return retorno;
                        }
                    }
                    else
                    {
                        MessageBox.Show("El usuario no fue creado correctamente", "Proceso no completado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return retorno;
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no puede ser creado por duplicidad de datos, intente cambiar el nombre de usuario o el empleado", "Duplicidad de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int ActualizarUsuario(ConstructorUsuarios act) 
        {
            
            int idusuario = ConstructorUsuarios.id_usuario;
            int retorno = 0;
            try
            {
                string verificar = "SELECT * FROM tbUsuarios WHERE usuario = @usuario AND id_empleado = @id_empleado AND id_estado_usuario = @id_estado_usuario";
                SqlCommand ver = new SqlCommand(verificar, Conexion.Conectar());
                ver.Parameters.AddWithValue("@usuario", act.usuario);
                ver.Parameters.AddWithValue("@id_empleado", act.id_empleado);
                ver.Parameters.AddWithValue("@id_estado_usuario", act.id_estado_usuario);
                retorno = Convert.ToInt16(ver.ExecuteScalar());
                if (retorno == 0)
                {
                    string actualizar = "UPDATE tbUsuarios SET usuario = @usuario, id_tipo_usuario = @id_tipo_usuario, id_estado_usuario = @id_estado_usuario WHERE id_usuario = @id_usuario";
                    SqlCommand actu = new SqlCommand(actualizar, Conexion.Conectar());
                    actu.Parameters.AddWithValue("@usuario", act.usuario);
                    actu.Parameters.AddWithValue("@id_tipo_usuario", act.id_tipo_usuario);
                    actu.Parameters.AddWithValue("@id_estado_usuario", act.id_estado_usuario);
                    actu.Parameters.AddWithValue("@id_usuario", idusuario);
                    retorno = actu.ExecuteNonQuery();
                    if (retorno >= 1)
                    {
                        MessageBox.Show("El usuario fue actualizado correctamente", "Proceso completado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return retorno;
                    }
                    else
                    {
                        MessageBox.Show("El usuario no fue actualizado correctamente", "Proceso no completado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return retorno;
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no puede ser creado por duplicidad de datos, intente cambiar el nombre de usuario o el empleado", "Duplicidad de datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int ReiniciarUsuario(ConstructorUsuarios res)
        {
            int idusuario = ConstructorUsuarios.id_usuario;
            int retorno = 0;
            try
            {
                string setpass = "UPDATE tbUsuarios SET contrasenia = @usuario + '1234', id_estado_usuario = 1 WHERE id_usuario = @id_usuario";
                SqlCommand set = new SqlCommand(setpass, Conexion.Conectar());
                set.Parameters.AddWithValue("@usuario", res.usuario);
                set.Parameters.AddWithValue("@id_usuario", idusuario);
                retorno = set.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("El usuario fue reiniciado correctamente, el usuario tiene una contraseña predeterminada (usuario + 1234)", "Proceso completado correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return retorno;
                }
                else
                {
                    MessageBox.Show("El usuario no fue reiniciado correctamente", "Error al asignar contraseña", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retorno;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }

        public static int[] IniciarSesion(ConstructorUsuarios log) 
        {
            int[] retornos = new int[4];
            retornos[0] = 0;
            try
            {
                string existencia = "SELECT * FROM tbUsuarios WHERE usuario = @usuario";
                SqlCommand cmd = new SqlCommand(existencia, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@usuario", log.usuario);
                retornos[0] = Convert.ToInt16(cmd.ExecuteScalar());
                if (retornos[0] >= 1)
                {
                    string estado = "SELECT * FROM tbUsuarios WHERE usuario = @usuario AND id_estado_usuario = 1";
                    SqlCommand cmdestado = new SqlCommand(estado, Conexion.Conectar());
                    cmdestado.Parameters.AddWithValue("@usuario", log.usuario);
                    retornos[0] = Convert.ToInt16(cmdestado.ExecuteScalar());
                    if (retornos[0] >= 1)
                    {
                        string login = "SELECT * FROM tbUsuarios WHERE usuario = @usuario AND contrasenia = @contrasenia";
                        SqlCommand cmdlogin = new SqlCommand(login, Conexion.Conectar());
                        cmdlogin.Parameters.AddWithValue("@usuario", log.usuario);
                        cmdlogin.Parameters.AddWithValue("@contrasenia", log.contrasenia);
                        retornos[1] = Convert.ToInt16(cmdlogin.ExecuteScalar());
                        if (retornos[1] >= 1)
                        {
                            string contra = "SELECT id_usuario FROM tbUsuarios WHERE usuario = @usuario AND contrasenia = usuario + '1234'";
                            SqlCommand cmdcontra = new SqlCommand(contra, Conexion.Conectar());
                            cmdcontra.Parameters.AddWithValue("@usuario", log.usuario);
                            retornos[1] = Convert.ToInt16(cmdcontra.ExecuteScalar());
                            if (retornos[1] >= 1)
                            {
                                retornos[0] = 2;
                                MessageBox.Show("Es necesario hacer un cambio de contraseña, cambie su contraseña por favor", "Cambio de contraseña requerido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return retornos;
                            }
                            else
                            {
                                retornos[0] = 3;
                                string capturar = "SELECT id_usuario, id_tipo_usuario FROM tbUsuarios WHERE usuario = @usuario AND contrasenia = @contrasenia";
                                SqlCommand cmdcapturar = new SqlCommand(capturar, Conexion.Conectar());
                                cmdcapturar.Parameters.AddWithValue("@usuario", log.usuario);
                                cmdcapturar.Parameters.AddWithValue("@contrasenia", log.contrasenia);
                                SqlDataReader reader = cmdcapturar.ExecuteReader();
                                while (reader.Read())
                                {
                                    retornos[2] = reader.GetInt32(0);
                                    retornos[3] = reader.GetInt32(1);
                                }
                                MessageBox.Show($"Acceso permitido, bienvenido {log.usuario}", "Inicio de sesión completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return retornos;
                            }
                        }
                        else
                        {
                            MessageBox.Show("El usuario o contraseña no son correctas, intentelo de nuevo", "Credenciales incorrectas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return retornos;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lo sentimos este usuario no está habilitado, consulte al administrador", "Usuario inactivo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return retornos;
                    }
                }
                else
                {
                    MessageBox.Show("El usuario no existe en la base de datos, intente con otro usuario", "Usuario no encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return retornos;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retornos;
            }
        }

        public static int CambiarContrasenia(ConstructorUsuarios camb)
        {
            int idusuario = ConstructorUsuarios.id_usuario;
            int retorno = 0;
            try
            {
                string cambio = "UPDATE tbUsuarios SET contrasenia = @contrasenia WHERE id_usuario = @id_usuario";
                SqlCommand cmd = new SqlCommand(cambio, Conexion.Conectar());
                cmd.Parameters.AddWithValue("@contrasenia", camb.contrasenia);
                cmd.Parameters.AddWithValue("@id_usuario", idusuario);
                retorno = cmd.ExecuteNonQuery();
                if (retorno >= 1)
                {
                    MessageBox.Show("La contraseña ha sido actualizada correctamente", "Contraseña actualizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("La contraseña no ha sido actualizado correctamente", "Contraseña no actualizada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return retorno;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error crítico de conexión " + ex, "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return retorno;
            }
        }
    }
}
