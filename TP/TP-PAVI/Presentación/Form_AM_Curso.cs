﻿using System;
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
    public partial class Form_AM_Curso : Form
    {

        private FormMode formMode = FormMode.nuevo;
        private GestorCursos oGestorCurso;
        private readonly GestorCategorias oGestorCategorias;
        private Cursos oCursoSelected;


        public Form_AM_Curso()
        {
            InitializeComponent();


            oGestorCurso = new GestorCursos();
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

        /*
        private void Form_AM_Curso_Load(System.Object sender, System.EventArgs e)
        {
            LlenarCombo(comboBoxCategoria, oGestorCategorias.ObtenerTodos(), "nombre", "id_categoria");
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        labelTitulo.Text = "Nuevo Usuario";
                        break;
                    }

                case FormMode.actualizar:
                    {
                        labelTitulo.Text = "Actualizar Usuario";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        textBoxNombre.Enabled = true;
                        textBoxDescripcion.Enabled = true;
                        maskedTextBoxFecha.Enabled = true;
                        comboBoxCategoria.Enabled = true;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        MostrarDatos();
                        labelTitulo.Text = "Habilitar/Deshabilitar Curso";
                        textBoxNombre.Enabled = false;
                        textBoxDescripcion.Enabled = false;
                        maskedTextBoxFecha.Enabled = false;
                        comboBoxCategoria.Enabled = false;
                        break;
                    }
            }
        }

        */

        public void InicializarFormulario(FormMode op, Cursos cursoSelected)
        {
            formMode = op;
            oCursoSelected = cursoSelected;
        }


        private void MostrarDatos()
        {
            if (oCursoSelected != null)
            {
                textBoxNombre.Text = oCursoSelected.nombreCurso;
                textBoxDescripcion.Text = oCursoSelected.descripcionCurso;
                maskedTextBoxFecha.Text = oCursoSelected.fecha_vigenciaCurso.ToString();
                
                comboBoxCategoria.Text = oCursoSelected.categoriaCurso.nombreCategoria.ToString();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (ExisteCurso() == false)
                        {
                            if (ValidarCampos())
                            {
                                Cursos oCurso = new Cursos();
                                Categorias aux = new Categorias();
                                oCurso.nombreCurso = textBoxNombre.Text;
                                oCurso.descripcionCurso = textBoxDescripcion.Text;
                                oCurso.fecha_vigenciaCurso = DateTime.Parse(maskedTextBoxFecha.Text);
                                aux.id_categoria = (int)comboBoxCategoria.SelectedValue;
                                oCurso.categoriaCurso= aux;

                                if (oGestorCurso.CrearCurso(oCurso))
                                {
                                    MessageBox.Show("Curso insertado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                            }
                        }
                        else
                            MessageBox.Show("Nombre de Curso Existente!. Ingrese un nombre diferente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }

                case FormMode.actualizar:
                    {
                        if (ValidarCampos())
                        {
                            oCursoSelected.nombreCurso = textBoxNombre.Text;
                            oCursoSelected.descripcionCurso = textBoxDescripcion.Text;
                            oCursoSelected.fecha_vigenciaCurso = DateTime.Parse(maskedTextBoxFecha.Text);

                            //cambiar 
                            //cambiar oCursoSelected.id_categoria = (int)comboBoxCategoria.SelectedValue;

                            if (oGestorCurso.ActualizarCurso(oCursoSelected))
                            {
                                MessageBox.Show("Curso actualizado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        break;
                    }

                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("Seguro que desea Deshabilitar el Curso seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oGestorCurso.EliminarCurso(oCursoSelected))
                            {
                                MessageBox.Show("Curso Deshabilitado!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                                MessageBox.Show("Error al actualizar el Curso!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (maskedTextBoxFecha.Text == string.Empty)
            {
                maskedTextBoxFecha.BackColor = Color.Red;
                maskedTextBoxFecha.Focus();
                return false;
            }
            else
                maskedTextBoxFecha.BackColor = Color.White;

            if (comboBoxCategoria.Text == string.Empty)
            {
                comboBoxCategoria.BackColor = Color.Red;
                comboBoxCategoria.Focus();
                return false;
            }
            else
                comboBoxCategoria.BackColor = Color.White;
            return true;
        }

        private void Form_AM_Curso_Load(object sender, EventArgs e)
        {
            LlenarCombo(comboBoxCategoria, oGestorCategorias.ObtenerTodos(), "nombreCategoria", "id_categoria");
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        labelTitulo.Text = "Nuevo Curso";
                        break;
                    }

                case FormMode.actualizar:
                    {
                        labelTitulo.Text = "Actualizar Curso";
                        // Recuperar usuario seleccionado en la grilla 
                        MostrarDatos();
                        textBoxNombre.Enabled = true;
                        textBoxDescripcion.Enabled = true;
                        maskedTextBoxFecha.Enabled = true;
                        comboBoxCategoria.Enabled = true;
                        break;
                    }

                case FormMode.eliminar:
                    {
                        MostrarDatos();
                        labelTitulo.Text = "Deshabilitar Curso";
                        textBoxNombre.Enabled = false;
                        textBoxDescripcion.Enabled = false;
                        maskedTextBoxFecha.Enabled = false;
                        comboBoxCategoria.Enabled = false;
                        break;
                    }
            }



        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }
        private bool ExisteCurso()
        {
            return oGestorCurso.ObtenerCurso(textBoxNombre.Text) != null;
        }
    }
}
