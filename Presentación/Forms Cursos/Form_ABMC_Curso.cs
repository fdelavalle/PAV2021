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
    public partial class Form_ABMC_Curso : Form_Plantilla_ABMC
    {
        private GestorCategorias oGestorCategorias;
        private GestorCursos oGestorCurso;
        public Form_ABMC_Curso()
        {
            InitializeComponent();
            InitializeDataGridView();
            oGestorCategorias = new GestorCategorias();
            oGestorCurso = new GestorCursos();
            this.toolTipInfoFiltros.SetToolTip(this.infoNombre, "Dejar en blanco para ignorar filtro de nombre");
            this.toolTipInfoFiltros.SetToolTip(this.infoCategoría, "Dejar en blanco para ignorar filtro de categoría");
            this.toolTipInfoFiltros.SetToolTip(this.infoFechaVigencia, "Dejar en blanco para ignorar filtro de fecha");
            
        }

        private void InitializeDataGridView()
        {
            // Cree un DataGridView no vinculado declarando un recuento de columnas.
            dataGridViewCursos.ColumnCount = 4;
            dataGridViewCursos.ColumnHeadersVisible = true;

            // Configuramos la AutoGenerateColumns en false para que no se autogeneren las columnas
            dataGridViewCursos.AutoGenerateColumns = false;

            // Cambia el estilo de la cabecera de la grilla.
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dataGridViewCursos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            // Definimos el nombre de la columnas y el DataPropertyName que se asocia a DataSource
            dataGridViewCursos.Columns[0].Name = "Nombre";
            dataGridViewCursos.Columns[0].DataPropertyName = "nombre";
            // Definimos el ancho de la columna.

            dataGridViewCursos.Columns[1].Name = "Descripcion";
            dataGridViewCursos.Columns[1].DataPropertyName = "descripcion";

            dataGridViewCursos.Columns[2].Name = "Categoria";
            dataGridViewCursos.Columns[2].DataPropertyName = "categoria.nombre";

            dataGridViewCursos.Columns[3].Name = "Fecha vigencia";
            dataGridViewCursos.Columns[3].DataPropertyName = "fecha_vigencia";


            // Cambia el tamaño de la altura de los encabezados de columna.
            dataGridViewCursos.AutoResizeColumnHeadersHeight();

            // Cambia el tamaño de todas las alturas de fila para ajustar el contenido de todas las celdas que no sean de encabezado.
            dataGridViewCursos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }


        private void Form_ABMC_Curso_Load(object sender, EventArgs e)
        {
            Titulo.Text = "Gestión de Cursos";
            LlenarCombo(comboBoxCategoria, oGestorCategorias.ObtenerTodos(), "nombre", "id_categoria");
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            // Dictionary: Representa una colección de claves y valores.
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            bool dadosBaja;
            if (checkBoxDadosBaja.Checked)
            {
                dadosBaja = true;
            }
            else
            {
                dadosBaja = false;
            }
            if (!string.IsNullOrEmpty(textBoxNombre.Text))
            {
                parametros.Add("nombre", textBoxNombre.Text);
            }

            DateTime fecha_vigencia;
            if (DateTime.TryParse(maskedTextBoxFecha.Text, out fecha_vigencia))
            {
                parametros.Add("fecha_vigencia", maskedTextBoxFecha.Text);
            }

            if (!string.IsNullOrEmpty(comboBoxCategoria.Text))
            {
                var id_categoria = comboBoxCategoria.SelectedValue.ToString();
                parametros.Add("id_categoria", id_categoria);
            }

            IList<Cursos> listadoCursos = oGestorCurso.ConsultarCursosConFiltro(parametros, dadosBaja);

            dataGridViewCursos.DataSource = listadoCursos;

            if (dataGridViewCursos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form_MenuPrincipal frmMenu = new Form_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form_ModificacionCurso frmModificacionCurso = new Form_ModificacionCurso();
            frmModificacionCurso.oCurso = (Cursos)dataGridViewCursos.CurrentRow.DataBoundItem;
            frmModificacionCurso.Show();
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("¿Seguro que desea eliminar el curso seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {
                oGestorCurso.EliminarCurso((Cursos)dataGridViewCursos.CurrentRow.DataBoundItem);
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Form_AltaCurso frmAltaCurso = new Form_AltaCurso();
            frmAltaCurso.Show();
            this.Close();
        }
    }
}
