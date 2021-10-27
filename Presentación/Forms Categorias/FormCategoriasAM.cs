using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI.Clases;
using TP_PAVI.Negocio.Control;

namespace TP_PAVI.Presentación.Forms_Categorias
{
    public partial class FormCategoriasAM : FormPlantilla
    {
        public FormMode formMode = FormMode.nuevo;
        public readonly GestorCategorias oGestorCategorias;
        public Categorias categoriaSeleccionada;
        public FormCategoriasAM()
        {
            InitializeComponent();
            oGestorCategorias = new GestorCategorias();
            categoriaSeleccionada = new Categorias();
        }

        public enum FormMode
        {
            nuevo,
            actualizar,
            eliminar
        }

        private void frmCategoriaABMC_Load(object sender, EventArgs e)
        {
            // LlenarCombo(txtCatNueva, oCategoriaService.obtenerTodas(), "nombre", "id_categoria");
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        this.Text = "Nueva Categoria";
                        break;
                    }

                case FormMode.actualizar:
                    {
                        this.Text = "Actualizar Categoria";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        textBoxNombre.Enabled = true;
                        textBoxDescripcion.Enabled = true;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        MostrarDatos();
                        this.Text = "Habilitar/Deshabilitar Usuario";
                        textBoxNombre.Enabled = false;
                        textBoxDescripcion.Enabled = false;
                        break;
                    }
            }

           
        }
        private void MostrarDatos()
        {
            if (categoriaSeleccionada != null)
            {
                textBoxNombre.Text = categoriaSeleccionada.nombre;
                textBoxDescripcion.Text = categoriaSeleccionada.descripcion;
            }
        }

        
        public void InitializeForm(FormMode op, Categorias categoriaSeleccionada1)
        {
            formMode = op;
            categoriaSeleccionada = categoriaSeleccionada1;
        }

        private bool ValidarCampos()
        {
            if (textBoxNombre.Text == string.Empty)
            {
                textBoxNombre.BackColor = Color.Red;
                textBoxNombre.Focus();
                return false;
            }
            else
            {
                textBoxNombre.BackColor = Color.White;

            }
            if (lblDescripcion.Text == string.Empty)
            {
                lblDescripcion.BackColor = Color.Red;
                lblDescripcion.Focus();
                return false;
            }
            else
            {
                lblDescripcion.BackColor = Color.White;
                return true;
            }


        }

        private bool existeCategoria()
        {
            return oGestorCategorias.obtenerCategoria(textBoxNombre.Text) != null;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (existeCategoria() == false)
                        {
                            if (ValidarCampos())
                            {
                                var oCategoria = new Categorias();
                                oCategoria.nombre = textBoxNombre.Text;
                                oCategoria.descripcion = textBoxDescripcion.Text;


                                if (oGestorCategorias.crearCategorias(oCategoria))
                                {
                                    MessageBox.Show(" Categoria agregada", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }

                        }
                        else
                            MessageBox.Show("La categoria insertada ya existe, ingrese otro nuevo");
                        break;
                    }
                case FormMode.actualizar:
                    {
                        if (ValidarCampos())
                        {
                            categoriaSeleccionada.nombre = textBoxNombre.Text;
                            categoriaSeleccionada.descripcion = textBoxDescripcion.Text;
                            if (oGestorCategorias.actualizarCategorias(categoriaSeleccionada))
                            {
                                MessageBox.Show("Categoria actualizada", " Informacion");
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar la categoria", "Informacion");
                        }
                        break;
                    }
                case FormMode.eliminar:
                    {
                        if (MessageBox.Show(" Seguro que desea eliminar/deshabilitar la categoria seleccionada?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oGestorCategorias.eliminarCategorias(categoriaSeleccionada))
                            {
                                MessageBox.Show("Categoria eliminada/deshabilitada", "Informacion");
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
    }
}
