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
using TP_PAVI.Negocio.Entidades;

namespace TP_PAVI.Presentación
{
    public partial class Form_InicioSesion : FormPlantilla
    {
        private readonly GestorUsuario oGestorUsuario;
        public Usuario usuarioLogueado;
        public Form_InicioSesion()
        {
            InitializeComponent();
            oGestorUsuario = new GestorUsuario();
            string tipo = this.GetType().ToString();
        }

        private void Form_InicioSesion_Load(object sender, EventArgs e)
        {
            Titulo.Text = "Inicio de Sesión";
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            //Validamos que se haya ingresado un usuario.
            if ((textBoxNombre.Text == ""))
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

            var usr = oGestorUsuario.ValidarUsuario(textBoxNombre.Text, textBoxContraseña.Text);
            //Controlamos que las creadenciales sean las correctas. 
            if (usr != null)
            {
                // Login OK
                usuarioLogueado = usr;
                Form_MenuPrincipal formMenu = new Form_MenuPrincipal();
                formMenu.obtenerUsuarioLogueado(usuarioLogueado);
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
