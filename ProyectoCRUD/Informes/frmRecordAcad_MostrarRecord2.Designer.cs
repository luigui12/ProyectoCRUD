﻿namespace ProyectoCRUD.Informes
{
    partial class frmRecordAcad_MostrarRecord2
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dsNotas = new ProyectoCRUD.ds.dsNotas();
            this.notasEstudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notasEstudiantesTableAdapter = new ProyectoCRUD.ds.dsNotasTableAdapters.notasEstudiantesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dsNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasEstudiantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.notasEstudiantesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoCRUD.Informes.rptRecordAcademico.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dsNotas
            // 
            this.dsNotas.DataSetName = "dsNotas";
            this.dsNotas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // notasEstudiantesBindingSource
            // 
            this.notasEstudiantesBindingSource.DataMember = "notasEstudiantes";
            this.notasEstudiantesBindingSource.DataSource = this.dsNotas;
            // 
            // notasEstudiantesTableAdapter
            // 
            this.notasEstudiantesTableAdapter.ClearBeforeFill = true;
            // 
            // frmRecordAcad_MostrarRecord2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmRecordAcad_MostrarRecord2";
            this.Text = "frmRecordAcad_MostrarRecord2";
            this.Load += new System.EventHandler(this.frmRecordAcad_MostrarRecord2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dsNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasEstudiantesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource notasEstudiantesBindingSource;
        private ds.dsNotas dsNotas;
        private ds.dsNotasTableAdapters.notasEstudiantesTableAdapter notasEstudiantesTableAdapter;
    }
}