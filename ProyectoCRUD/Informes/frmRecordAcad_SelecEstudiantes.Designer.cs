﻿namespace ProyectoCRUD.Informes
{
    partial class frmRecordAcad_SelecEstudiantes
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMatricula = new System.Windows.Forms.ComboBox();
            this.informe = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona el estudiante";
            // 
            // cmbMatricula
            // 
            this.cmbMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMatricula.FormattingEnabled = true;
            this.cmbMatricula.Location = new System.Drawing.Point(170, 78);
            this.cmbMatricula.Name = "cmbMatricula";
            this.cmbMatricula.Size = new System.Drawing.Size(211, 21);
            this.cmbMatricula.TabIndex = 1;
            this.cmbMatricula.SelectedIndexChanged += new System.EventHandler(this.cmbMatricula_SelectedIndexChanged);
            // 
            // informe
            // 
            this.informe.Location = new System.Drawing.Point(387, 76);
            this.informe.Name = "informe";
            this.informe.Size = new System.Drawing.Size(75, 23);
            this.informe.TabIndex = 2;
            this.informe.Text = "Ver Informe";
            this.informe.UseVisualStyleBackColor = true;
            this.informe.Click += new System.EventHandler(this.button1_Click);
            // 
            // cerrar
            // 
            this.cerrar.Location = new System.Drawing.Point(481, 76);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 3;
            this.cerrar.Text = "Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(504, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "INFORME DE RECORD ACADEMICO";
            // 
            // frmRecordAcad_SelecEstudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 280);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.informe);
            this.Controls.Add(this.cmbMatricula);
            this.Controls.Add(this.label1);
            this.Name = "frmRecordAcad_SelecEstudiantes";
            this.Text = "Informe por estudiantes";
            this.Load += new System.EventHandler(this.Seleccion_Estudiantes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMatricula;
        private System.Windows.Forms.Button informe;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.Label label2;
    }
}