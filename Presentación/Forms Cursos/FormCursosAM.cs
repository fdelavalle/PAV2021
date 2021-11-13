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

namespace TP_PAVI.Presentación.Forms_Cursos
{
    public partial class FormCursosAM : Form_Plantilla
    {
        private FormMode formMode = FormMode.nuevo;
        public Cursos oCurso;
        public GestorCursos oGestorCursos;
        public GestorCategorias oGestorCategorias;
        

        public FormCursosAM()
        {
            InitializeComponent();
            oGestorCategorias = new GestorCategorias();
            oGestorCursos = new GestorCursos();
        }
        public enum FormMode
        {
            nuevo,
            eliminar,
            modificar
        }

        private void FormAM_Load(object sender, EventArgs e)
        {
            LlenarCombo(comboBoxCategoria, oGestorCategorias.ObtenerTodos(), "nombre", "id_categoria");

            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        Titulo.Text = "Nuevo Curso";
                        break;
                    }
                case FormMode.modificar:
                    {
                        Titulo.Text = "Modificar Curso";
                        mostrarDatos();
                        textBoxNombre.Enabled = true;
                        textBoxDescripcion.Enabled = true;
                        maskedTextBoxFecha.Enabled = true;
                        comboBoxCategoria.Enabled = true;
                        break;
                    }
                case FormMode.eliminar:
                    {
                        Titulo.Text = "Eliminar Curso";
                        mostrarDatos();
                        textBoxNombre.Enabled = false;
                        textBoxDescripcion.Enabled = false;
                        maskedTextBoxFecha.Enabled = false;
                        comboBoxCategoria.Enabled = false;
                        break;
                    }
            }
        }

        public void InitializeForm(FormMode op, Object cursoSelected)
        {
            formMode = op;
            oCurso = (Cursos)cursoSelected;
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        //verificamos si exite un curso con ese nombre
                        if (!existeCurso(textBoxNombre.Text))
                        {
                            //validamos los campos
                            if (validarCampos())
                            {
                                var oCurso = new Cursos();
                                oCurso.nombre = textBoxNombre.Text;
                                oCurso.descripcion = textBoxDescripcion.Text;
                                oCurso.fecha_vigencia = Convert.ToDateTime(maskedTextBoxFecha.Text);
                                oCurso.categoria = new Categorias();
                                oCurso.categoria.id_categoria = (int)comboBoxCategoria.SelectedValue;

                                if (oGestorCursos.CrearCurso(oCurso))
                                {
                                    MessageBox.Show("Nuevo curso agregado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Error al registrar el curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }

                            }
                        }

                        break;
                    }
                case FormMode.modificar:
                    {
                        if (validarCampos())
                        {
                            oCurso.nombre = textBoxNombre.Text;
                            oCurso.descripcion = textBoxDescripcion.Text;
                            oCurso.fecha_vigencia = Convert.ToDateTime(maskedTextBoxFecha.Text);
                            oCurso.categoria.id_categoria = (int)comboBoxCategoria.SelectedValue;

                            if (oGestorCursos.ActualizarCurso(oCurso))
                            {
                                MessageBox.Show("Curso actualizado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Error al actualizar el curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    }

                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("Seguro que desea eliminar el curso seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            if (oGestorCursos.EliminarCurso(oCurso))
                            {
                                MessageBox.Show("Curso Eliminado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al eliminar el curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }
        }


        private bool validarCampos()
        {
            if (string.IsNullOrEmpty(textBoxNombre.Text))
            {
                textBoxNombre.Focus();
                MessageBox.Show("Ingrese el nombre del curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textBoxDescripcion.Text))
            {
                textBoxNombre.Focus();
                MessageBox.Show("Ingrese la descripcion del curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!DateTime.TryParse(maskedTextBoxFecha.Text, out DateTime fechaVigencia))
            {
                textBoxNombre.Focus();
                MessageBox.Show("Ingrese la fecha del curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(comboBoxCategoria.Text))
            {
                textBoxNombre.Focus();
                MessageBox.Show("Seleccione la categoria del curso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private bool existeCurso(String cursoNombre)
        {
            return oGestorCursos.ExisteCurso(cursoNombre);
        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void mostrarDatos()
        {
            if (oCurso != null)
            {
                textBoxNombre.Text = oCurso.nombre;
                textBoxDescripcion.Text = oCurso.descripcion;
                maskedTextBoxFecha.Text = oCurso.fecha_vigencia.ToString("dd/MM/yyyy");
                comboBoxCategoria.Text = oCurso.categoria.nombre;
            }
        }

        private void pictureBoxRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maxBtn.Visible = false;
            restoreBtn.Visible = true;
        }
    }
}
