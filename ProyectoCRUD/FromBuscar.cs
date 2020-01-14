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
    public partial class FromBuscar : Form
    {
        public FromBuscar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void FromEliminar_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombreCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getDatos(this.cmbMatricula.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                foreach(DataRow fila in dt.Rows)
                {
                    this.apellidos.Text = fila["apellidos"].ToString();
                    this.nombre.Text = fila["nombres"].ToString();
                    this.cmbgenero.Text = fila["genero"].ToString();
                    this.nacimiento.Text = fila["fechaNacimiento"].ToString();
                    this.correo.Text = fila["email"].ToString();
                }
            }
            else
            {
                MessageBox.Show("EL estudiante no existe...");
            }
        }

        private void apellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
