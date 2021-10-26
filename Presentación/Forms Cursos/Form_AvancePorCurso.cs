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
    public partial class Form_AvancePorCurso : FormPlantilla
    {
        GestorCursos oGestorCursos;
        GestorUsuariosCursoAvance oGestorUsuariosCursoAvance;
        public Form_AvancePorCurso()
        {
            InitializeComponent();
            InitializeDataGridView();
            oGestorCursos = new GestorCursos();
            oGestorUsuariosCursoAvance = new GestorUsuariosCursoAvance();
            Titulo.Text = "Actualización de avance por curso";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_MenuPrincipal frmMenu = new Form_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void pictureBoxRegresar_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBoxRegresar.Image = ((System.Drawing.Image)(Properties.Resources.exit_p));
        }

        private void pictureBoxRegresar_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBoxRegresar.Image = ((System.Drawing.Image)(Properties.Resources.salir));
        }

        private void Form_AvancePorCurso_Load(object sender, EventArgs e)
        {
            LlenarCombo(comboBoxCursos, oGestorCursos.ObtenerTodos(), "nombre", "id_curso");
        }

        private void checkBoxTodos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTodos.Checked == true)
            {
                foreach (DataGridViewRow row in dataGridViewAlumnos.Rows)
                {
                    row.Selected = true;
                }
            }
            if (checkBoxTodos.Checked == false)
            {
                foreach (DataGridViewRow row in dataGridViewAlumnos.Rows)
                {
                    row.Selected = false;
                }
            }
        }


        private void InitializeDataGridView() //CORREGIR
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dataGridViewAlumnos.ColumnCount = 3;
            dataGridViewAlumnos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dataGridViewAlumnos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewAlumnos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dataGridViewAlumnos.Columns[0].Name = "Nombre";
            dataGridViewAlumnos.Columns[0].DataPropertyName = "usuario.nombre";
            // Definimos el ancho de la columna.

            dataGridViewAlumnos.Columns[1].Name = "Porcentaje de avance";
            dataGridViewAlumnos.Columns[1].DataPropertyName = "porc_avance";

            dataGridViewAlumnos.Columns[2].Name = "Email";
            dataGridViewAlumnos.Columns[2].DataPropertyName = "usuario.Email";


            // Cambia el tamaño de la altura de los encabezados de columna.
            dataGridViewAlumnos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dataGridViewAlumnos.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            // Dictionary: Representa una colección de claves y valores.
            Dictionary<string, object> parametros = new Dictionary<string, object>();
     


            if (!string.IsNullOrEmpty(comboBoxCursos.Text))
            {
                var id_curso = comboBoxCursos.SelectedValue.ToString();
                parametros.Add("id_curso", id_curso);
            }

            IList<UsuariosCursoAvance> listadoUsuariosCursoAvance = oGestorUsuariosCursoAvance.ConsultarConFiltro(parametros);

            dataGridViewAlumnos.DataSource = listadoUsuariosCursoAvance;

            if (dataGridViewAlumnos.Rows.Count == 0)
            {
                MessageBox.Show("El curso aún no tiene alumnos registrados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(maskedTextBoxAvance.Text) >= 0 || Convert.ToInt32(maskedTextBoxAvance.Text) <= 100)
            {
                List<UsuariosCursoAvance> listadoAlumnos = new List<UsuariosCursoAvance>();
                int cantidadAlumnos = dataGridViewAlumnos.Rows.Count;
                for (int i = 0; i < cantidadAlumnos; i++)
                {
                    UsuariosCursoAvance guiaFila = new UsuariosCursoAvance();
                    if (dataGridViewAlumnos.Rows[i].Selected)
                    {
                        guiaFila = (UsuariosCursoAvance)dataGridViewAlumnos.Rows[i].DataBoundItem;
                        listadoAlumnos.Add(guiaFila);
                    }
                }
                int avance = Convert.ToInt32(maskedTextBoxAvance.Text);
                oGestorUsuariosCursoAvance.ActualizarAvance(listadoAlumnos, avance);
                buttonAceptar.PerformClick();
                checkBoxTodos.Checked = false;
            }
            else
            {
                MessageBox.Show("Ingrese un porcentaje de avance válido");
            }
          
        }
    }
}
