using System;
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
            DataGridViewButtonColumn btnseleccionar = new DataGridViewButtonColumn();
            btnseleccionar.Name = "Seleccionar";

            DataGridViewButtonColumn btneliminar1 = new DataGridViewButtonColumn();
            btneliminar1.Name = "Eliminar";

            dtusuario.Columns.Add(btnseleccionar);
            dtusuario.Columns.Add(btneliminar1);
            cargarGridUsuario();
            encerar();
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
            Academico.Usuario usuario = new Academico.Usuario(); //Creando instancia
            int a = int.Parse(this.id.Text);
            if (a > 0)
            {
                usuario.idLogin = a;
                usuario.nombreCompleto = this.nombre.Text;
                usuario.loguin = this.login.Text;
                usuario.clave = this.clave.Text;
                usuario.tipoUsuario = this.tiposusu.Text;
                int x = Academico.UsuarioDAO.actualizar(usuario);
                if (x > 0)
                {
                    MessageBox.Show("Usuario actualizado con éxito...");
                    cargarGridUsuario();
                    encerar();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar al usuario...");
                }
            }
            else
            {
                usuario.nombreCompleto = this.nombre.Text;
                usuario.loguin = this.login.Text;
                usuario.clave = this.clave.Text;
                usuario.tipoUsuario = this.tiposusu.Text;
                int x = Academico.UsuarioDAO.guardar(usuario);
                cargarGridUsuario();
                if (x > 0)
                {
                    MessageBox.Show("Usuario guardado con éxito...");
                    cargarGridUsuario(); 
                    encerar();
                }
                else
                {
                    MessageBox.Show("No se pudo agregar al usuario...");
                }

            }
        }
        // para crear el botón dentro del Datagridview//
        
        private void dtusuario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && this.dtusuario.Columns[e.ColumnIndex].Name == "Seleccionar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celboton = this.dtusuario.Rows[e.RowIndex].Cells["Seleccionar"] as DataGridViewButtonCell;
                Icon icoSeleccionar = new Icon(Environment.CurrentDirectory + @"\\seleccion.ico");
                e.Graphics.DrawIcon(icoSeleccionar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dtusuario.Rows[e.RowIndex].Height = icoSeleccionar.Height + 10;
                this.dtusuario.Columns[e.ColumnIndex].Width = icoSeleccionar.Width + 10;

                e.Handled = true;
            }

            if (e.ColumnIndex >= 0 && this.dtusuario.Columns[e.ColumnIndex].Name == "Eliminar" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                DataGridViewButtonCell celboton = this.dtusuario.Rows[e.RowIndex].Cells["Eliminar"] as DataGridViewButtonCell;
                Icon icoSeleccionar = new Icon(Environment.CurrentDirectory + @"\\seleccion2.ico");
                e.Graphics.DrawIcon(icoSeleccionar, e.CellBounds.Left + 3, e.CellBounds.Top + 3);

                this.dtusuario.Rows[e.RowIndex].Height = icoSeleccionar.Height + 10;
                this.dtusuario.Columns[e.ColumnIndex].Width = icoSeleccionar.Width + 10;

                e.Handled = true;
            }
        }
        private void dtusuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dtusuario.Columns[e.ColumnIndex].Name == "Seleccionar")
            {

                id.Text = dtusuario.CurrentRow.Cells[2].Value.ToString();
                nombre.Text = dtusuario.CurrentRow.Cells[3].Value.ToString();
                login.Text = dtusuario.CurrentRow.Cells[4].Value.ToString();
                clave.Text = dtusuario.CurrentRow.Cells[5].Value.ToString();
                tiposusu.Text = dtusuario.CurrentRow.Cells[6].Value.ToString();
                
            }
            else { }

            if (this.dtusuario.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Estas seguro de eliminar registro?"
                 , "eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int x = Academico.UsuarioDAO.eliminar(this.login.Text);

                    this.id.Clear();
                    this.nombre.Clear();
                    this.login.Clear();
                    this.clave.Clear();
                    //this.tiposusu.Clear();
                    DataTable dt = Academico.UsuarioDAO.getDatos();
                    cargarGridUsuario();
                    encerar();
                }
                else { }
            }
        }

        private void dtusuario_CellPainting_1(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}
