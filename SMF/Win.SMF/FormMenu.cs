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
    public partial class FormMenu : Form
    {
        private Button currentButton;
        private Form activeForm;

        public FormMenu()
        {
            InitializeComponent();
            CerrarCloseForm.Visible = false;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    CerrarCloseForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    //previousBtn.BackColor = Color.FromArgb(51, 5, 76);

                }
            }
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            Ingresar();
            //var formLogin = new FormLogin();
            //formLogin.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelEscritorio.Controls.Add(childForm);
            this.panelEscritorio.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            Titulo.Text = childForm.Text;
        }

        private void Productos_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormProductos(),sender);
            //var formProductos = new FormProductos();
            //formProductos.MdiParent = this;
            //formProductos.Show();
        }

        private void Clientes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormClientes(), sender);
            //var formClientes = new FormClientes();
            //formClientes.MdiParent = this;
            //formClientes.Show();
        }

        private void Facturacion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormFacturacion(), sender);
            //var formFacturacion = new FormFacturacion();
            //formFacturacion.MdiParent = this;
            //formFacturacion.Show();
        }

        private void Reportes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReporteProducto(), sender);
            //var formReportes = new FormReportes();
            //formReportes.MdiParent = this;
            //formReportes.Show();
        }

        private void Configuracion_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormConfiguracion(), sender);
            //var formConfiguracion = new FormFacturacion();
            //formConfiguracion.MdiParent = this;
            //formConfiguracion.Show();
        }

        private void Titulo_Click(object sender, EventArgs e)
        {
            
        }

        private void panelEscritorio_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void Ingresar()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void panelBarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CerrarCloseForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Resetear();
            }
        }
        private void Resetear()
        {
            DisableButton();
            Titulo.Text = "HOME";
            currentButton = null;
            CerrarCloseForm.Visible = false;
        }
    }
}
