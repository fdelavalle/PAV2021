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
    public partial class Form_AltaCurso : Form_Plantilla
    {
        public Cursos oCurso;
        public GestorCursos oGestorCursos;
        public GestorCategorias oGestorCategorias;
        public Form_AltaCurso()
        {
            InitializeComponent();
            oCurso = new Cursos();
            oGestorCursos = new GestorCursos();
            oGestorCategorias = new GestorCategorias();
            Titulo.Text = "Nuevo curso";
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string tipo = this.GetType().ToString();
            if (tipo == "TP_PAVI.Presentación.Forms_Cursos.Form_AltaCurso")
            {
                oCurso.id_curso = obtenerIdUltimoCurso() + 1;
                oCurso.borrado = false;
                oCurso.categoria = (Categorias)comboBoxCategoria.SelectedItem;
                oCurso.descripcion = textBoxDescripcion.Text;
                oCurso.nombre = textBoxNombre.Text;
                oCurso.fecha_vigencia = Convert.ToDateTime(maskedTextBoxFecha.Text);
                oGestorCursos.CrearCurso(oCurso);
            }
            if (tipo == "TP_PAVI.Presentación.Forms_Cursos.Form_ModificacionCurso")
            {
                oGestorCursos.ActualizarCurso(oCurso);
                oCurso.borrado = false;
                oCurso.categoria = (Categorias)comboBoxCategoria.SelectedItem;
                oCurso.descripcion = textBoxDescripcion.Text;
                oCurso.nombre = textBoxNombre.Text;
                oCurso.fecha_vigencia = Convert.ToDateTime(maskedTextBoxFecha.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_ABMC_Curso frm = new Form_ABMC_Curso();
            frm.Show();
            this.Close();
        }

        private int obtenerIdUltimoCurso()
        {
            return oGestorCursos.ObtenerUltimoId() + 1;
        }

        private void Form_AltaCurso_Load(object sender, EventArgs e)
        {
            LlenarCombo(comboBoxCategoria, oGestorCategorias.ObtenerTodos(), "nombre", "id_categoria");
        }
        public void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxRegresar.Image = ((System.Drawing.Image)(Properties.Resources.exit_p));
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxRegresar.Image = ((System.Drawing.Image)(Properties.Resources.salir));
        }
    }
}
