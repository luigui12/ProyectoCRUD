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
    public partial class fromEliminar : Form
    {
        public fromEliminar()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getDatos(this.cmbMatricula.SelectedValue.ToString());
            if (dt.Rows.Count > 0)
            {
                foreach (DataRow fila in dt.Rows)
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

        private void eliminar_Click(object sender, EventArgs e)
        {
            int x = 0;
            Academico.Estudiante matricula= new Academico.Estudiante();
         
            if (MessageBox.Show("¿Estas seguro de eliminar registro de este estudiante?", "eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Academico.EstudianteDAO.eliminar(matricula);
            }
            else
            {

            }
        }

        private void fromEliminar_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombreCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }
    }
}
