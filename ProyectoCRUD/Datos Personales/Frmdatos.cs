using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Datos_Personales
{
    public partial class Frmdatos : Form
    {
        public Frmdatos()
        {
            InitializeComponent();
        }

        private void Frmdatos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void Frmdatos_Load_1(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dsEstudiantes1.Estudiantes' Puede moverla o quitarla según sea necesario.
            this.estudiantesTableAdapter.Fill(this.dsEstudiantes1.Estudiantes);

            this.reportViewer2.RefreshReport();
        }
    }
}
