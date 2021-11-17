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

namespace TP_PAVI.Presentación.Forms_Objetivos
{
    public partial class FormObjetivosAM : Form_Plantilla
    {
        private FormMode formMode = FormMode.nuevo;
        private GestorObjetivos oGestorObjetivos;
        private Objetivos oObjetivoSeleccionado;

        public FormObjetivosAM()
        {
            InitializeComponent();
            oGestorObjetivos = new GestorObjetivos();
        }

        public enum FormMode
        {
            nuevo,
            eliminar,
            modificar
        }

        private void FormObjetivosAM_Load(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        Titulo.Text = "Nuevo Objetivo";

                        textBoxNombreCorto.Enabled = true;
                        textBoxNombreLargo.Enabled = true;
                        break;
                    }
                case FormMode.modificar:
                    {
                        Titulo.Text = "Modificar Objetivo";
                        mostrarDatos();

                        if (oObjetivoSeleccionado != null)
                        {
                            if (!oObjetivoSeleccionado.borrado)
                            {

                                textBoxNombreCorto.Enabled = false;
                                textBoxNombreLargo.Enabled = false;


                                btnConfirmar.Enabled = false;
                            }
                        }
                        break;
                    }
                case FormMode.eliminar:
                    {
                        this.Text = "Eliminar Objetivo";
                        mostrarDatos();
                        textBoxNombreCorto.Enabled = false;
                        textBoxNombreLargo.Enabled = false;
                        break;
                    }
            }
        }

        public void InitializeForm(FormMode op, Object objetivoSelected)
        {
            formMode = op;
            oObjetivoSeleccionado = (Objetivos)objetivoSelected;
        }

        private void mostrarDatos()
        {
            if (oObjetivoSeleccionado != null)
            {
                textBoxNombreCorto.Text = oObjetivoSeleccionado.nombre_corto;
                textBoxNombreLargo.Text = oObjetivoSeleccionado.nombre_largo;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            switch (formMode)
            {
                case FormMode.nuevo:
                    {
                        if (validarCampos())
                        {
                            var oObjetivo = new Objetivos();
                            oObjetivo.nombre_corto = textBoxNombreCorto.Text;
                            oObjetivo.nombre_largo = textBoxNombreLargo.Text;

                            if (oGestorObjetivos.CrearObjetivos(oObjetivo))
                            {
                                MessageBox.Show("Objetivo registrado satisfactoriamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al registrar el objetivo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    }
                case FormMode.modificar:
                    {
                        if (validarCampos())
                        {
                            oObjetivoSeleccionado.nombre_corto = textBoxNombreCorto.Text;
                            oObjetivoSeleccionado.nombre_largo = textBoxNombreLargo.Text;

                            if (oGestorObjetivos.ActualizarObjetivos(oObjetivoSeleccionado))
                            {
                                MessageBox.Show("Objetivo actualizado satisfactoriamente!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Dispose();
                            }
                            else
                            {
                                MessageBox.Show("Error al actualizar el objetivo!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    }
                case FormMode.eliminar:
                    {
                        if (MessageBox.Show("Seguro que desea eliminar el objetivo seleccionado?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (oGestorObjetivos.EliminarObjetivos(oObjetivoSeleccionado))
                            {
                                MessageBox.Show("Objetivo eliminado satisfactoriamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el objetivo!", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        break;
                    }
            }
        }

        private bool validarCampos()
        {
            if (string.IsNullOrEmpty(textBoxNombreCorto.Text))
            {
                MessageBox.Show("Ingrese nombre corto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombreCorto.Focus();
                return false;

            }

            if (string.IsNullOrEmpty(textBoxNombreLargo.Text))
            {
                MessageBox.Show("Ingrese nombre largo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxNombreLargo.Focus();
                return false;
            }

            return true;
        }
        private void btnSalir_Click(object sender, EventArgs e)
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
