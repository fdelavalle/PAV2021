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
    public partial class Form_ObjetivosPorCurso : Form_Plantilla
    {
        GestorCursos oGestorCurso;
        GestorObjetivos oGestorObjetivos;
        GestorObjetivosCursos oGestorObjetivosCursos;
        public Form_ObjetivosPorCurso()
        {
            InitializeComponent();
            oGestorCurso = new GestorCursos();
            oGestorObjetivos = new GestorObjetivos();
            oGestorObjetivosCursos = new GestorObjetivosCursos();
            Titulo.Text = "Actualización de objetivos por curso";
            LlenarCombo(comboBoxCursos, oGestorCurso.ObtenerTodos(), "nombre", "id_curso");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form_MenuPrincipal frm = new Form_MenuPrincipal();
            frm.Show();
            this.Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            // Dictionary: Representa una colección de claves y valores.
            Dictionary<string, object> parametros = new Dictionary<string, object>();



            if (!string.IsNullOrEmpty(comboBoxCursos.Text))
            {
                var id_curso = comboBoxCursos.SelectedValue.ToString();
                parametros.Add("curso", id_curso);
            }
            IList<Objetivos> listadoObjetivosCurso = oGestorObjetivos.ConsultarObjetivosConFiltro(parametros, false);
            IList<Objetivos> listadosTodosObjetivos = oGestorObjetivos.ObtenerTodos();

            dataGridViewObjetivosCurso.DataSource = listadoObjetivosCurso;

            IList<Objetivos> otrosObjetivos = new List<Objetivos>();
            
            for (int i = 0; i < listadosTodosObjetivos.Count; i++)
            {
                bool estaEnCurso = false;
                int idObj = listadosTodosObjetivos[i].id_objetivo;
                for (int j = 0; i < listadoObjetivosCurso.Count; i++)
                {
                    int idObjCur = listadoObjetivosCurso[j].id_objetivo;
                    if (idObj == idObjCur)
                    {
                        estaEnCurso = true;
                        break;
                    }
                }
                if (!estaEnCurso)
                {
                    otrosObjetivos.Add(listadosTodosObjetivos[i]);
                }
            }
            dataGridViewObjetivos.DataSource = otrosObjetivos;
            if (dataGridViewObjetivosCurso.Rows.Count == 0)
            {
                MessageBox.Show("El curso aún no tiene objetivos registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea quitar estos objetivos del curso?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                List<Objetivos> listadoObjetivosCurso = new List<Objetivos>();
                var id_curso = Convert.ToInt32(comboBoxCursos.SelectedValue.ToString());
                int cantidadAlumnos = dataGridViewObjetivosCurso.Rows.Count;
                for (int i = 0; i < cantidadAlumnos; i++)
                {
                    Objetivos ObjetivosFila = new Objetivos();
                    if (dataGridViewObjetivosCurso.Rows[i].Selected)
                    {
                        ObjetivosFila = (Objetivos)dataGridViewObjetivosCurso.Rows[i].DataBoundItem;
                        listadoObjetivosCurso.Add(ObjetivosFila);
                    }
                }
                oGestorObjetivosCursos.EliminarObjetivosCursos(listadoObjetivosCurso, id_curso);
                buttonAceptar.PerformClick();
            }
        }
   
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea agregar estos objetivos al curso?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                List<Objetivos> listadoObjetivosCurso = new List<Objetivos>();
                var id_curso = Convert.ToInt32(comboBoxCursos.SelectedValue.ToString());
                int cantidadAlumnos = dataGridViewObjetivos.Rows.Count;
                for (int i = 0; i < cantidadAlumnos; i++)
                {
                    Objetivos objetivoCursoFila = new Objetivos();
                    if (dataGridViewObjetivos.Rows[i].Selected)
                    {
                        objetivoCursoFila = (Objetivos)dataGridViewObjetivos.Rows[i].DataBoundItem;
                        listadoObjetivosCurso.Add(objetivoCursoFila);
                    }
                }
                oGestorObjetivosCursos.AgregarObjetivosCursos(listadoObjetivosCurso, id_curso);
                buttonAceptar.PerformClick();
            }

        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maxBtn.Visible = false;
            restoreBtn.Visible = true;
        }
    }
}
