﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD.Adm
{
    public partial class Frmusuario : Form
    {
        public Frmusuario()
        {
            InitializeComponent();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Frmusuario_Load(object sender, EventArgs e)
        {
            encerar();
            cargarGridUsuario();
        }
        private void cargarGridUsuario()
        {
            this.dtusuario.DataSource = Academico.UsuarioDAO.getDatos();
        }
        private void encerar()
        {
            this.id.Text = "0";
            this.nombre.Text = String.Empty;
            this.login.Text = String.Empty;
            this.clave.Text = String.Empty;
            this.tiposusu.Text = "Secretaria";
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Guardar Registro
        private void toolStripLabel1_Click_1(object sender, EventArgs e)
        {
            int x = 0;
            if (this.nombre.Text.Length==0)
            {
                MessageBox.Show("Por favor ingresa el nombre completo...!!");
                this.nombre.Focus();
                return;
            }
            if (this.login.Text.Length==0)
            {
                MessageBox.Show("Por favor ingresa el login ...!!");
                this.login.Focus();
                return;
            }
            if (this.clave.Text.Length==0)
            {
                MessageBox.Show("Por favor ingresa la clave...!!");
                this.clave.Focus();
                return;
            }
            if (this.tiposusu.Text.Length==0) {

                MessageBox.Show("Seleccione una opcion!!");
                this.tiposusu.Focus();
                return;

            }
            //creamos instancia de la clase Estudiante
            Academico.Usuario usuario = new Academico.Usuario();
            //pasamos los valores de la cajas de texto a cada items
            usuario.nombreCompleto = this.nombre.Text;
            usuario.login = this.login.Text;
            usuario.clave = this.clave.Text;
            usuario.tipoUsuario = this.tiposusu.Text;

            
                x = Academico.UsuarioDAO.guardar(usuario);
            if (x>0)
            {
                cargarGridUsuario();
                MessageBox.Show("Usuario Agregado con exito...!");
            }
            else
            {
                MessageBox.Show("No se puede agregar el Usuario");
            }
        }
    }
}