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
    public partial class FormCategorias : FormPlantilla
    {

        //obtener categorias y eso
        private GestorCategorias oGestorCategoria;


        public FormCategorias()
        {
            InitializeComponent();
            InitializeDataGridView();
            oGestorCategoria = new GestorCategorias();
            btnModificarCategoria.Enabled = false;
            btnEliminarCategoria.Enabled = false;
        }

       

        private void InitializeDataGridView()
        {
            //defino la cantiddad de columnas
            dgvCategorias.ColumnCount = 2;
            dgvCategorias.ColumnHeadersVisible = true;


            //para qe no se autogeneren las columnas
            dgvCategorias.AutoGenerateColumns = false;

            // definicion de los nombres de las columnas y el datapropertyname
            // que se asocia a dataSource


            dgvCategorias.Columns[0].Name = "Nombre";
            dgvCategorias.Columns[0].DataPropertyName = "nombre";

            dgvCategorias.Columns[1].Name = "Descripción";
            dgvCategorias.Columns[1].DataPropertyName = "descripcion";

            //Cambia el tamaño de la altura de los ancabezados de columna

            dgvCategorias.AutoResizeColumnHeadersHeight();

            // ajustar el contenio de las celdas que no sean encabezado
            // cambia el tamaño de todas las alturas de fila


            dgvCategorias.AutoResizeColumns(DataGridViewAutoSizeColumnsMo‌​de.AllCells);
        }

        private void ckdCategorias_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxCategorias.Checked)
            {
                txtBoxCategoria.Enabled = false;
            }
            else
            {
                txtBoxCategoria.Enabled = true;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
           
            var filtros = new Dictionary<string, object>();
            if (!checkboxCategorias.Checked)
            {
                if (txtBoxCategoria.Text != string.Empty)
                {
                    filtros.Add("nombre", txtBoxCategoria.Text);
                }

                if (filtros.Count > 0)
                {
                    //codificar obtenerconfiltros
                    dgvCategorias.DataSource = oGestorCategoria.obtenerConFiltros(filtros);
                    if (dgvCategorias.Rows.Count == 0)
                    {
                        MessageBox.Show("No se han encontrado resultados para tu búsqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    }
                    else
                    {
                        btnEliminarCategoria.Enabled = true;
                        btnModificarCategoria.Enabled = true;
                    }
                }


            }
            else
            {
                dgvCategorias.DataSource = oGestorCategoria.ObtenerTodos();
                btnEliminarCategoria.Enabled = true;
                btnModificarCategoria.Enabled = true;
            }
        }

       
        

       
       

       
        

        private void btnCrearCategoria_Click(object sender, EventArgs e)
        {
             
            //falta crear form de abmc
            FormCategoriasAM fmCategoriaAlta = new FormCategoriasAM();
            fmCategoriaAlta.ShowDialog();

            //forzar para que se actualice la grilla
            btnConsultar_Click(sender, e);
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            FormCategoriasAM formulario = new FormCategoriasAM();

            //para obtener la categoria que selecciono en la grilla y modificarla:
            var categoria = (Categorias)dgvCategorias.CurrentRow.DataBoundItem;

            //cargar el formulario
            formulario.InitializeForm(FormCategoriasAM.FormMode.eliminar, categoria);

            //mostrar
            formulario.ShowDialog();

            //esto es para que se actualice la grilla
            btnConsultar_Click(sender, e);
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            //falta crear form abmc
            FormCategoriasAM formulario = new FormCategoriasAM();

            // para obtener la categoria que selecciono en la grilla y modificarla:
            var categoria = (Categorias)dgvCategorias.CurrentRow.DataBoundItem;

            //cargar el formulario
            formulario.InitializeForm(FormCategoriasAM.FormMode.actualizar, categoria);

            //mostrar
            formulario.ShowDialog();

            // esto es para que se actualice la grilla
            btnConsultar_Click(sender, e);
        }
    }
}
