using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logeo
{
    public static class UsuarioDAO
    {
        public static string cadenaConexion = @"server=L-PCT-103\SQLEXPRESS2016; database=TI2019; user id=sa; password=Lab123456";
        public static int guardar(Usuario usuario)
        {

            //segundo paso: definimos un objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //tercer paso: creamos la cadena de la tabla
            string sql = "insert into usuario (matricula,apellidos,nombres,genero," +
                "fechaNacimiento,email) values(@matricula,@apellidos,@nombres,@genero," +
                "@fechaNacimiento,@email) ";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);

            //configuramos los parámetros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@nombreCompleto", usuario.idLogin);
            comando.Parameters.AddWithValue("@apellidos", usuario.nombreCompleto);
            comando.Parameters.AddWithValue("@nombres", usuario.login);
            comando.Parameters.AddWithValue("@clave", usuario.clave);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();

            return x;
        }

    }
}
