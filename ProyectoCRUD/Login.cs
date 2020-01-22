using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoCRUD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por su visita");
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ingresar_Click(object sender, EventArgs e)
        {
          bool existe = Academico.UsuarioDAO.validaUsuario(this.usuario.Text, this.password.Text);
            if (existe) {
                this.Visible = false;//Ocultar form login
                frmMenu frm1 = new frmMenu();
                frm1.Show();
            }
            else
            {
                MessageBox.Show("Usuario y/o clave incorrecto");
            }
        }
    }
}
