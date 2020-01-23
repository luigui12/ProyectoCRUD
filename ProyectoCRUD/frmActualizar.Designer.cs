namespace ProyectoCRUD
{
    partial class frmActualizar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActualizar));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nacimiento = new System.Windows.Forms.DateTimePicker();
            this.correo = new System.Windows.Forms.TextBox();
            this.cmbgenero = new System.Windows.Forms.ComboBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buscar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMatricula = new System.Windows.Forms.ComboBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nacimiento);
            this.groupBox1.Controls.Add(this.correo);
            this.groupBox1.Controls.Add(this.cmbgenero);
            this.groupBox1.Controls.Add(this.nombre);
            this.groupBox1.Controls.Add(this.apellidos);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(44, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 232);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // nacimiento
            // 
            this.nacimiento.Location = new System.Drawing.Point(140, 147);
            this.nacimiento.Name = "nacimiento";
            this.nacimiento.Size = new System.Drawing.Size(138, 20);
            this.nacimiento.TabIndex = 27;
            // 
            // correo
            // 
            this.correo.Location = new System.Drawing.Point(140, 182);
            this.correo.Name = "correo";
            this.correo.Size = new System.Drawing.Size(247, 20);
            this.correo.TabIndex = 26;
            // 
            // cmbgenero
            // 
            this.cmbgenero.FormattingEnabled = true;
            this.cmbgenero.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.cmbgenero.Location = new System.Drawing.Point(140, 113);
            this.cmbgenero.Name = "cmbgenero";
            this.cmbgenero.Size = new System.Drawing.Size(100, 21);
            this.cmbgenero.TabIndex = 25;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(140, 72);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 20);
            this.nombre.TabIndex = 24;
            // 
            // apellidos
            // 
            this.apellidos.Location = new System.Drawing.Point(140, 31);
            this.apellidos.Name = "apellidos";
            this.apellidos.Size = new System.Drawing.Size(100, 20);
            this.apellidos.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Correo :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha_nacimiento :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Genero :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombres :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Apellidos :";
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(367, 45);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 6;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccion de estudiantes: ";
            // 
            // cmbMatricula
            // 
            this.cmbMatricula.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbMatricula.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMatricula.FormattingEnabled = true;
            this.cmbMatricula.Location = new System.Drawing.Point(201, 45);
            this.cmbMatricula.Name = "cmbMatricula";
            this.cmbMatricula.Size = new System.Drawing.Size(121, 21);
            this.cmbMatricula.TabIndex = 4;
            this.cmbMatricula.SelectedIndexChanged += new System.EventHandler(this.cmbMatricula_SelectedIndexChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(490, 25);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(79, 22);
            this.toolStripButton1.Text = "Actualizar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(59, 22);
            this.toolStripButton2.Text = "Cerrar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // frmActualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 336);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbMatricula);
            this.Name = "frmActualizar";
            this.Text = "Actualizar datos estudiantes";
            this.Load += new System.EventHandler(this.frmActualizar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox correo;
        private System.Windows.Forms.ComboBox cmbgenero;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox apellidos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMatricula;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DateTimePicker nacimiento;
    }
}