﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Academico
{
    public static class EstudianteDAO
    {
       
        public static string cadenaConexion = @"server=L-PCT-116\SQLEXPRESS2016; database=TI2019; user id=sa; password=Lab123456";
        public static int guardar(Estudiante estudiante)
        {
            
            //segundo paso: definimos un objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);
                
            //tercer paso: creamos la cadena de la tabla
            string sql = "insert into Estudiantes(matricula,apellidos,nombres,genero," +
                "fechaNacimiento,email) values(@matricula,@apellidos,@nombres,@genero," +
                "@fechaNacimiento,@email) ";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);

            //configuramos los parámetros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@matricula", estudiante.Matricula);
            comando.Parameters.AddWithValue("@apellidos", estudiante.Apellidos);
            comando.Parameters.AddWithValue("@nombres", estudiante.Nombres);
            comando.Parameters.AddWithValue("@genero", estudiante.Genero);
            comando.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento.Date);
            comando.Parameters.AddWithValue("@email", estudiante.Correo);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();

            return x;
        }

        public static bool validarEmail(string email)
        {
            String expresion;
            expresion = @"^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9 -]+)*(\.[a-z]{2,4})$";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                { 
                    return true;
                }
                else
                { 
                    return false; 
                }

            }
            else
            {
                return true;
            }
        }


            /// <summary>
            /// Devuelve todas la tabla estudiantes 
            /// </summary>
            /// <returns></returns>
            public static DataTable getDatos()
            {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select matricula,apellidos,nombres,genero," +
                "fechaNacimiento,email from Estudiantes order by apellidos";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
            }
        /// <summary>
        /// obtiene el apellido y nombre de un estudiante mediante la matricula
        /// </summary>
        /// <returns></returns>
        public static DataTable getNombreCompletos()
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select matricula, upper (apellidos + ' ' + nombres) as Estudiante " +
                " from Estudiantes order by apellidos,nombres";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }
        /// <summary>
        /// Obtiene un estudiante por su numero de matricula
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>
        public static DataTable getDatos(String matricula)
        {
            SqlConnection conn = new SqlConnection(cadenaConexion);
            string sql = "select matricula,apellidos,nombres,genero," +
                "fechaNacimiento,email from Estudiantes "+
                "where matricula = @matricula "+
                "order by apellidos,nombres";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            ad.SelectCommand.Parameters.AddWithValue("@matricula",matricula);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            return dt;
        }

        /// <summary>
        /// Eliminar
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>

        public static int eliminar(string matricula)
        {
            
            //segundo paso: definimos un objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //tercer paso: creamos la cadena de la tabla
            string sql = "delete from estudiantes where matricula=@matricula";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);

            //configuramos los parámetros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@matricula",matricula);

            //abrimos conexion
            conn.Open();

            //ejecutamos el comando
            int x = comando.ExecuteNonQuery();

            //cerrmos conexion
            conn.Close();

            return x;
        }

        public static int actualizar(Estudiante estudiante)
        {
            //segundo paso: definimos un objeto conexión
            SqlConnection conn = new SqlConnection(cadenaConexion);

            //tercer paso: creamos la cadena de la tabla
            string sql = "UPDATE Estudiantes SET apellidos=@apellidos,nombres=@nombres,genero=@genero," +
                "fechaNacimiento=@fechaNacimiento,email=@email WHERE matricula=@matricula";

            //definimos un comando
            SqlCommand comando = new SqlCommand(sql, conn);

            //configuramos los parámetros
            comando.CommandType = System.Data.CommandType.Text;
            comando.Parameters.AddWithValue("@matricula", estudiante.Matricula);
            comando.Parameters.AddWithValue("@apellidos", estudiante.Apellidos);
            comando.Parameters.AddWithValue("@nombres", estudiante.Nombres);
            comando.Parameters.AddWithValue("@genero", estudiante.Genero);
            comando.Parameters.AddWithValue("@fechaNacimiento", estudiante.FechaNacimiento.Date);
            comando.Parameters.AddWithValue("@email", estudiante.Correo);
            conn.Open();
            int x = comando.ExecuteNonQuery(); //ejecutamos el comando
            conn.Close();

            return x;
        }
    }
}
