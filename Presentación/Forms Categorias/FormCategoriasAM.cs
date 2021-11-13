using System;
using System.Drawing;
using System.Windows.Forms;
using TP_PAVI.Clases;
using TP_PAVI.Negocio.Control;
using TP_PAVI.Presentación;

namespace TP_PAVI.Presentación.Forms_Categorias
{
    public partial class FormCategoriasAM : Form_Plantilla
    {
        private FormMode formMode = FormMode.nuevo;
        public GestorCategorias oGestorCategorias;
        public Categorias oCategoriaSeleccionada;


        public FormCategoriasAM()
        {
            InitializeComponent();
            oGestorCategorias = new GestorCategorias();
            oCategoriaSeleccionada = new Categorias();
        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }

        private void FormCategoriasAM_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        Titulo.Text = "Nueva Categoria";
                        break;
                    }

                case FormMode.actualizar:
                    {
                        Titulo.Text = "Actualizar Categoria";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        textBoxNombre.Enabled = true;
                        textBoxDescripcion.Enabled = true;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        MostrarDatos();
                        Titulo.Text = "Deshabilitar Categoria";
                        textBoxNombre.Enabled = false;
                        textBoxDescripcion.Enabled = false;
                        break;
                    }

            }
        }

        public void InitializeForm(FormMode op, Categorias categoriaSeleccionada1)
        {
            formMode = op;
            oCategoriaSeleccionada = categoriaSeleccionada1;
        }


        private void MostrarDatos()
        {
            if (oCategoriaSeleccionada != null)
            {
                textBoxNombre.Text = oCategoriaSeleccionada.nombre;
                textBoxDescripcion.Text = oCategoriaSeleccionada.descripcion;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (!existeCategoria())
                        {
                            if (ValidarCampos())
                            {
                                var oCategoria = new Categorias();
                                oCategoria.nombre = textBoxNombre.Text;
                                oCategoria.descripcion = textBoxDescripcion.Text;


                                if (oGestorCategorias.crearCategorias(oCategoria))
                                {
                                    MessageBox.Show("Categoria agregada satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }

                        }
                        else
                            MessageBox.Show("La categoria que desea agregar ya existe. Ingrese un nombre diferente");
                        break;
                    }
                case FormMode.actualizar:
                    {
                        if (ValidarCampos())
                        {
                            oCategoriaSeleccionada.nombre = textBoxNombre.Text;
                            oCategoriaSeleccionada.descripcion = textBoxDescripcion.Text;
                            if (oGestorCategorias.actualizarCategorias(oCategoriaSeleccionada))
                            {
                                MessageBox.Show("Categoria actualizada!", " Informacion");
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar categoria", "Informacion");
                        }
                        break;
                    }
                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("Seguro que desea deshabilitar categoria seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oGestorCategorias.eliminarCategorias(oCategoriaSeleccionada))
                            {
                                MessageBox.Show("Categoria deshabilitada!", "Informacion");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar la categoria indicada");
                            }
                        }
                    }
                    break;

            }
        }


        private bool ValidarCampos()
        {
            //campos obligatorios
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

        private bool existeCategoria()
        {
            return oGestorCategorias.obtenerCategoria(textBoxNombre.Text) != null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void greaterBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maxBtn.Visible = false;
            restoreBtn.Visible = true;
        }
    }
}
