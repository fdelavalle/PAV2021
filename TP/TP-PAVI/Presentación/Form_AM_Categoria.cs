using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using TP_PAVI.Clases;
using TP_PAVI.Negocio.Control;

namespace TP_PAVI
{
    public partial class Form_AM_Categoria : Form
    {

        private FormMode formMode = FormMode.nuevo;
        //private GestorCursos oGestorCurso;
        private GestorCategorias oGestorCategorias;
        private Categorias oCategoriaSelected;


        public Form_AM_Categoria()
        {
            InitializeComponent();
            
            oGestorCategorias = new GestorCategorias();
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
        private void maxBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maxBtn.Visible = false;
            restoreBtn.Visible = true;

        }
        private void restoreBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restoreBtn.Visible = false;
            maxBtn.Visible = true;
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
        private void maxBtn_MouseEnter(object sender, EventArgs e)
        {
            this.maxBtn.Image = ((System.Drawing.Image)(Properties.Resources.max_p));
        }
        private void maxBtn_MouseLeave(object sender, EventArgs e)
        {
            this.maxBtn.Image = ((System.Drawing.Image)(Properties.Resources.max));
        }
        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            this.closeBtn.Image = ((System.Drawing.Image)(Properties.Resources.close_p));
        }
        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            this.closeBtn.Image = ((System.Drawing.Image)(Properties.Resources.close));
        }
        private void restoreBtn_MouseEnter(object sender, EventArgs e)
        {
            this.restoreBtn.Image = ((System.Drawing.Image)(Properties.Resources.res_p));
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void restoreBtn_MouseLeave(object sender, EventArgs e)
        {
            this.restoreBtn.Image = ((System.Drawing.Image)(Properties.Resources.res));
        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }

        private void Form_AM_Categoria_Load(object sender, EventArgs e)
        {
            // LlenarCombo(comboBoxCategoria, oGestorCategorias.ObtenerTodos(), "nombre", "id_categoria");
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        labelTitulo.Text = "Nueva Categoria";
                        break;
                    }

                case FormMode.actualizar:
                    {
                        labelTitulo.Text = "Actualizar Categoria";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        textBoxNombre.Enabled = true;
                        textBoxDescripcion.Enabled = true;

                        break;
                    }

                case FormMode.eliminar:
                    {
                        MostrarDatos();
                        labelTitulo.Text = "Deshabilitar Categoria";
                        textBoxNombre.Enabled = false;
                        textBoxDescripcion.Enabled = false;

                        break;
                    }
            }

        }

     
        public void InicializarFormulario(FormMode op, Categorias categoriaSelected)
        {
            formMode = op;
            oCategoriaSelected = categoriaSelected;
        }


        private void MostrarDatos()
        {
            if (oCategoriaSelected != null)
            {
                textBoxNombre.Text = oCategoriaSelected.nombreCategoria;
                textBoxDescripcion.Text = oCategoriaSelected.descripcionCategoria;
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (ExisteCategoria() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oCategoria = new Categorias();
                                oCategoria.nombreCategoria = textBoxNombre.Text;
                                oCategoria.descripcionCategoria = textBoxDescripcion.Text;

                                if (oGestorCategorias.CrearCategoria(oCategoria))
                                {
                                    MessageBox.Show("Categoria insertada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de Categoria encontrada!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.actualizar:
                    {
                        if (ValidarCampos())
                        {
                            oCategoriaSelected.nombreCategoria = textBoxNombre.Text;
                            oCategoriaSelected.descripcionCategoria = textBoxDescripcion.Text;

                            if (oGestorCategorias.ActualizarCategoria(oCategoriaSelected))
                            {
                                MessageBox.Show("Categoria actualizada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar Categoria!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("Seguro que desea deshabilitar categoria seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oGestorCategorias.EliminarCategoria(oCategoriaSelected))
                            {
                                MessageBox.Show("Categoria Deshabilitada!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar Categoria!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }

        private bool ValidarCampos()
        {
            // campos obligatorios
            if (textBoxNombre.Text == string.Empty)
            {
                textBoxNombre.BackColor = Color.Red;
                textBoxNombre.Focus();
                return false;
            }
            else
                textBoxNombre.BackColor = Color.White;
                       
            return true;
        }



        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
        private bool ExisteCategoria()
        {
            return oGestorCategorias.ObtenerCategoria(textBoxNombre.Text) != null;
        }
    }
}
