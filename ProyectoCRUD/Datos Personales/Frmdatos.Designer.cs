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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ver = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbdatos = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsEstudiantes = new ProyectoCRUD.ds.dsEstudiantes();
            this.estudiantes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantes1TableAdapter = new ProyectoCRUD.ds.dsEstudiantesTableAdapters.Estudiantes1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantes1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ver
            // 
            this.ver.Location = new System.Drawing.Point(133, 148);
            this.ver.Name = "ver";
            this.ver.Size = new System.Drawing.Size(75, 23);
            this.ver.TabIndex = 0;
            this.ver.Text = "Ver";
            this.ver.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(246, 148);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 1;
            this.exit.Text = "Salir";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(361, 45);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccione el Estudiante";
            // 
            // cmbdatos
            // 
            this.cmbdatos.FormattingEnabled = true;
            this.cmbdatos.Location = new System.Drawing.Point(157, 107);
            this.cmbdatos.Name = "cmbdatos";
            this.cmbdatos.Size = new System.Drawing.Size(121, 21);
            this.cmbdatos.TabIndex = 3;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.estudiantes1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoCRUD.Datos Personales.datosPersonales.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 189);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(513, 260);
            this.reportViewer1.TabIndex = 4;
            // 
            // dsEstudiantes
            // 
            this.dsEstudiantes.DataSetName = "dsEstudiantes";
            this.dsEstudiantes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // estudiantes1BindingSource
            // 
            this.estudiantes1BindingSource.DataMember = "Estudiantes1";
            this.estudiantes1BindingSource.DataSource = this.dsEstudiantes;
            // 
            // estudiantes1TableAdapter
            // 
            this.estudiantes1TableAdapter.ClearBeforeFill = true;
            // 
            // Frmdatos
            // 
            this.ClientSize = new System.Drawing.Size(514, 461);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cmbdatos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ver);
            this.Name = "Frmdatos";
            this.Text = "Frmdatos";
            this.Load += new System.EventHandler(this.Frmdatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantes1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}