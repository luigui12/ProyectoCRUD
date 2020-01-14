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
    public partial class frmActualizar : Form
    {
        public frmActualizar()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            int x = 0;
            //creamos instancia de la clase Estudiante
            Academico.Estudiante estudiante = new Academico.Estudiante();
            //pasamos los valores de la cajas de texto a cada items
            estudiante.Matricula = Convert.ToString(this.cmbMatricula.SelectedValue);
            estudiante.Apellidos = this.apellidos.Text;
            estudiante.Nombres = this.nombre.Text;
            estudiante.FechaNacimiento = this.nacimiento.Value;
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
            //REALIZA EL PROCESO QUE LE ASIGNEMOS Y DEVUELVE ALGUN POSIBLE ERROR
            try
            {
                x = Academico.EstudianteDAO.actualizar(estudiante);
               
                MessageBox.Show("Actualizacion Realizada con exito...! :" + x.ToString());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message.ToString());
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmActualizar_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombreCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            if (buscar1() == false)
            {
                MessageBox.Show("No existe el Registro...");
            }
            
            
        }

        private bool buscar1()
        {
            bool encontrado = false; 
            DataTable dt = Academico.EstudianteDAO.getDatos(this.cmbMatricula.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
                {
                    encontrado = true;
                    this.apellidos.Text = fila["apellidos"].ToString();
                    this.nombre.Text = fila["nombres"].ToString();
                    this.cmbgenero.Text = fila["genero"].ToString();
                    this.nacimiento.Text = fila["fechaNacimiento"].ToString();
                    this.correo.Text = fila["email"].ToString();
                }
            }
            return encontrado;
        }

        private void cmbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.cmbMatricula.SelectedIndex >= 0)
            {
                buscar1();
            }
        }
    }
}
