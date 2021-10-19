using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI.Negocio.Control;

namespace TP_PAVI
{
    public partial class FormInicioSesion : Form
    {
        private readonly GestorUsuario gestorUsuario;
        public string UsuarioLogueado { get; internal set; }
        public FormInicioSesion()
        {
            InitializeComponent();
            gestorUsuario = new GestorUsuario();
        }

        int m, mx, my;
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }

        }
        private void panelBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }




        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }



        private void minBtn_MouseEnter(object sender, EventArgs e)
        {
            this.minBtn.Image = ((System.Drawing.Image)(Properties.Resources.min_p));
        }
        private void minBtn_MouseLeave(object sender, EventArgs e)
        {
            this.minBtn.Image = ((System.Drawing.Image)(Properties.Resources.min));
        }

      
        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            this.closeBtn.Image = ((System.Drawing.Image)(Properties.Resources.close_p));
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            this.closeBtn.Image = ((System.Drawing.Image)(Properties.Resources.close));
        }





        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario.
            if ((textBoxUsuario.Text == ""))
            {
                MessageBox.Show("Se debe ingresar un usuario.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //Validamos que se haya ingresado una password
            if ((textBoxContraseña.Text == ""))
            {
                MessageBox.Show("Se debe ingresar una contraseña.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            var usr = gestorUsuario.ValidarUsuario(textBoxUsuario.Text, textBoxContraseña.Text);
            //Controlamos que las creadenciales sean las correctas. 
            if (usr != null)
            {
                // Login OK
                UsuarioLogueado = usr.NombreUsuario;
                FormMenu formMenu = new FormMenu();
                formMenu.uLogeado = usr;
                formMenu.Show();
                this.Hide();
            }
            else
            {
                //Limpiamos el campo password, para que el usuario intente ingresar un usuario distinto.
                textBoxContraseña.Text = "";
                // Enfocamos el cursor en el campo password para que el usuario complete sus datos.
                textBoxContraseña.Focus();
                //Mostramos un mensaje indicando que el usuario/password es invalido.
                MessageBox.Show("Debe ingresar usuario y/o contraseña válidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
