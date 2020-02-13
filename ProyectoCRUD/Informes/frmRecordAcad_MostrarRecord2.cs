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
    public partial class frmRecordAcad_MostrarRecord2 : Form
    {
        public frmRecordAcad_MostrarRecord2()
        {
            InitializeComponent();
        }

        private void frmRecordAcad_MostrarRecord2_Load(object sender, EventArgs e)
        {
            string smatricula = frmRecordAcad_SelecEstudiantes.Matricula;
            this.notasEstudiantesTableAdapter.FillxMatricula(dsNotas.notasEstudiantes, smatricula);
            this.reportViewer1.RefreshReport();
        }
    }
}
