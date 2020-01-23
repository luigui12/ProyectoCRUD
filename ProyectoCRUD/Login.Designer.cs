namespace ProyectoCRUD
{
    partial class Login
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
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.ingresar = new System.Windows.Forms.Button();
            this.cerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña: ";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(113, 86);
            this.usuario.MaxLength = 50;
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(100, 20);
            this.usuario.TabIndex = 2;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(113, 118);
            this.password.MaxLength = 30;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(100, 20);
            this.password.TabIndex = 3;
            // 
            // ingresar
            // 
            this.ingresar.Location = new System.Drawing.Point(39, 178);
            this.ingresar.Name = "ingresar";
            this.ingresar.Size = new System.Drawing.Size(75, 23);
            this.ingresar.TabIndex = 4;
            this.ingresar.Text = "&Ingresar";
            this.ingresar.UseVisualStyleBackColor = true;
            this.ingresar.Click += new System.EventHandler(this.ingresar_Click);
            // 
            // cerrar
            // 
            this.cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cerrar.Location = new System.Drawing.Point(138, 178);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(75, 23);
            this.cerrar.TabIndex = 5;
            this.cerrar.Text = "&Cerrar";
            this.cerrar.UseVisualStyleBackColor = true;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoCRUD.Properties.Resources.usuario__1_;
            this.pictureBox1.Location = new System.Drawing.Point(264, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 71);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AcceptButton = this.ingresar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cerrar;
            this.ClientSize = new System.Drawing.Size(369, 238);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.ingresar);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button ingresar;
        private System.Windows.Forms.Button cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}