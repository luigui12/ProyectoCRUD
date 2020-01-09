using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            int x = 0;
            //creamos instancia de la clase Estudiante
            Academico.Estudiante estudiante = new Academico.Estudiante();
            //pasamos los valores de la cajas de texto a cada items
            estudiante.Matricula = this.matricula.Text;
            estudiante.Apellidos = this.apellidos.Text;
            estudiante.Nombres = this.nombre.Text;
            estudiante.FechaNacimiento = this.nacimiento.Value;
            estudiante.Correo = this.correo.Text;
            string genero = "F";
            //VALIDAR MENSAJE
            if (Academico.EstudianteDAO.validarEmail(this.correo.Text) == false)
            {
                MessageBox.Show("El Email Ingresado no se encuentra en el Formato Correcto",
                                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                estudiante.Correo = this.correo.Text;
            }
            //GENERO
            if (this.cmbgenero.Text.ToString().Equals("Masculino"))
            {
                genero = "M";
            }
            estudiante.Genero = genero;

            try
            {
                x = Academico.EstudianteDAO.guardar(estudiante);
                cargarGridEstudiantes();
                MessageBox.Show("Filas agregadas: " + x.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarGridEstudiantes();
        }
        private void cargarGridEstudiantes()
        {
            this.dataGridView1.DataSource = Academico.EstudianteDAO.getDatos();
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.matricula.Text = "";
            this.nombre.Text = "";
            this.apellidos.Text = "";
            this.correo.Text = "";
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por visitar...  "+ " Tenga buen dia :) ");
            this.Close();
        }
    }
}
