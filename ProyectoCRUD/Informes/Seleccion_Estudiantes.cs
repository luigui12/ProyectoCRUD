using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Informes
{
    public partial class Seleccion_Estudiantes : Form
    {
        public Seleccion_Estudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Seleccion_Estudiantes_Load(object sender, EventArgs e)
        {
            DataTable dt = Academico.EstudianteDAO.getNombreCompletos();
            this.cmbMatricula.DataSource = dt;
            this.cmbMatricula.DisplayMember = "Estudiante";
            this.cmbMatricula.ValueMember = "Matricula";
        }
    }
}
