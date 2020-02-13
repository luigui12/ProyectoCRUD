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
    public partial class frmRecordAcad_SelecEstudiantes : Form
    {
        public static String Matricula;

        public frmRecordAcad_SelecEstudiantes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.cmbMatricula.SelectedValue.ToString().Length == 0){
                MessageBox.Show("Pro favor debe seleccionar un estudiante");
                this.cmbMatricula.Focus();//ubicar enfoque en el combo matricula
                return; //Abandonar la ejecucion
            }
            Matricula = this.cmbMatricula.SelectedValue.ToString();
            Informes.frmRecordAcad_MostrarRecord2 frm1 = new Informes.frmRecordAcad_MostrarRecord2();
            frm1.Show();
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

        private void cmbMatricula_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
