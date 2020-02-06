namespace ProyectoCRUD.Informes
{
    partial class frminformeEstudiantes
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dsEstudiantes1 = new ProyectoCRUD.ds.dsEstudiantes();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantesTableAdapter1 = new ProyectoCRUD.ds.dsEstudiantesTableAdapters.EstudiantesTableAdapter();
            this.dsEstudiantes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Estudiantes";
            this.bindingSource2.DataSource = this.dsEstudiantes1;
            // 
            // dsEstudiantes1
            // 
            this.dsEstudiantes1.DataSetName = "dsEstudiantes";
            this.dsEstudiantes1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dsEstudiantes1BindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ProyectoCRUD.Informes.prtEstudiantes.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(834, 363);
            this.reportViewer2.TabIndex = 0;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Estudiantes";
            this.bindingSource1.DataSource = this.dsEstudiantes1;
            // 
            // estudiantesTableAdapter1
            // 
            this.estudiantesTableAdapter1.ClearBeforeFill = true;
            // 
            // dsEstudiantes1BindingSource
            // 
            this.dsEstudiantes1BindingSource.DataSource = this.dsEstudiantes1;
            this.dsEstudiantes1BindingSource.Position = 0;
            // 
            // frminformeEstudiantes
            // 
            this.ClientSize = new System.Drawing.Size(834, 363);
            this.Controls.Add(this.reportViewer2);
            this.Name = "frminformeEstudiantes";
            this.Load += new System.EventHandler(this.frminformeEstudiantes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ds.dsEstudiantes dsEstudiantes;
        private System.Windows.Forms.BindingSource estudiantesBindingSource;
        private ds.dsEstudiantesTableAdapters.EstudiantesTableAdapter estudiantesTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private ds.dsEstudiantes dsEstudiantes1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ds.dsEstudiantesTableAdapters.EstudiantesTableAdapter estudiantesTableAdapter1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource dsEstudiantes1BindingSource;
    }
}