namespace ProyectoCRUD.Datos_Personales
{
    partial class Frmdatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Frmdatos
            // 
            this.ClientSize = new System.Drawing.Size(519, 355);
            this.Name = "Frmdatos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vista;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ver;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbdatos;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource estudiantes1BindingSource;
        private ds.dsEstudiantes dsEstudiantes;
        private ds.dsEstudiantesTableAdapters.Estudiantes1TableAdapter estudiantes1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private ds.dsEstudiantes dsEstudiantes1;
        private System.Windows.Forms.BindingSource estudiantesBindingSource;
        private ds.dsEstudiantesTableAdapters.EstudiantesTableAdapter estudiantesTableAdapter;
    }
}