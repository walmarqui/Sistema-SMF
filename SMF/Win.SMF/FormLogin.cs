using BL.SMF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.SMF
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Aceptar_Click_1(object sender, EventArgs e)
        {
            string usuario;
            string contrasena;

            usuario = Usuario.Text;
            contrasena = Contraseña.Text;

            Aceptar.Enabled = false;
            Aceptar.Text = "Verificando...";
            Application.DoEvents();

            var usuarioDB = _seguridad.Autorizar(usuario, contrasena);

            if (usuarioDB != null)
            {
                Utils.NombreUsuario = usuarioDB.Nombre;
                //var formLogin = new FormLogin();
                //formLogin.Close();
                //this.Close();
                var formMenu = new FormMenu();
                formMenu.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña inconrrecta");
            }
            Aceptar.Enabled = true;
            Aceptar.Text = "Aceptar";

        }

        private void Usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Usuario.Text != "")
                {
                    Contraseña.Focus();
                }
                
            }
        }

        private void Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (Contraseña.Text != "")
                {
                    Aceptar.PerformClick();
                }
                
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
