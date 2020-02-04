using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academico
{
    public static class UsuarioDAO
    {
        public static string cadenaConexion = @"server=LABORATORIO2\SQLEXPRESS2016; database=TI2019; user id=sa; password=lab123456;";
        /// <summary>
        /// Guardar
        /// </summary>
        /// <param name="estudiante"></param>
        /// <returns></returns>
        public static int guardar(Usuario usuario)
        {

            //segundo paso: definimos un objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //tercer paso: creamos la cadena de la tabla
            string sql = "insert into usuarios (nombreCompleto,loguin,clave,tipoUsuario) " +
                " values(@nombreCompleto,@loguin,@clave,@tipoUsuario) ";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);

            //configuramos los parámetros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@nombreCompleto", usuario.nombreCompleto);
            comando.Parameters.AddWithValue("@loguin", usuario.loguin);
            comando.Parameters.AddWithValue("@clave", usuario.clave);
            comando.Parameters.AddWithValue("@tipoUsuario", usuario.tipoUsuario);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();

            return x;
        }
        /// <summary>
        /// enviar datos
        /// </summary>
        /// <returns></returns>
        public static DataTable getDatos()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select idLogin,nombreCompleto,loguin,clave,tipoUsuario "+
                " from usuarios order by nombreCompleto";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Validar Usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="clave"></param>
        /// <returns></returns>
        public static bool validaUsuario(String usuario, String clave )
        {

            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select loguin,clave from usuarios " +
               " where loguin = @loguin and clave = @clave ";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);

            ad.SelectCommand.Parameters.AddWithValue("@loguin", usuario);
            ad.SelectCommand.Parameters.AddWithValue("@clave", clave);

            DataTable dt = new DataTable();
            ad.Fill(dt);

            if (dt.Rows.Count>0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Eliminar
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        public static int eliminar(string usuario)
        {

            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "delete from usuarios where loguin=@loguin";

            //Definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);
            //configuramos los parámetros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@loguin", usuario);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //Ejeutamos el comando
            conn.Close();

            return x;
        }

    }
}
