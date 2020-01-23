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
        public static string cadenaConexion = @"server=L-PCT-103\SQLEXPRESS2016; database=TI2019; user id=sa; password=Lab123456";
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
            string sql = "insert into usuarios (nombreCompleto,login,clave,tiposUsuario) " +
                " values(@nombreCompleto,@login,@clave,@tiposUsuario) ";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);

            //configuramos los parámetros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@nombreCompleto", usuario.nombreCompleto);
            comando.Parameters.AddWithValue("@login", usuario.login);
            comando.Parameters.AddWithValue("@clave", usuario.clave);
            comando.Parameters.AddWithValue("@tiposUsuario", usuario.tipoUsuario);
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
            string sql = "select idLogin,nombreCompleto,login,clave,tiposUsuario "+
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
            string sql = "select login,clave from usuarios " +
               " where login = @login and clave = @clave ";

            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);

            ad.SelectCommand.Parameters.AddWithValue("@login", usuario);
            ad.SelectCommand.Parameters.AddWithValue("@clave", clave);

            DataTable dt = new DataTable();
            ad.Fill(dt);

            if (dt.Rows.Count>0)
            {
                return true;
            }
            return false;
        }

    }
}
