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
    public partial class FormObjetivosABMC : Form_Plantilla_ABMC
    {
        private GestorObjetivos oGestorObjetivos;
        public FormObjetivosABMC()
        {
            InitializeComponent();
            InitializeDataGridView();
            oGestorObjetivos = new GestorObjetivos();
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;
            Titulo.Text = "Gestión de Objetivos";
           

        }
        private void InitializeDataGridView()
        {

            dgvObjetivos.ColumnCount = 3;
            dgvObjetivos.ColumnHeadersVisible = true;

          
            dgvObjetivos.AutoGenerateColumns = false;

            
            DataGridViewCellStyle columnHeaderStyle = new DataGridViewCellStyle();

            columnHeaderStyle.BackColor = Color.Beige;
            columnHeaderStyle.Font = new Font("Verdana", 8, FontStyle.Bold);
            dgvObjetivos.ColumnHeadersDefaultCellStyle = columnHeaderStyle;

            
            dgvObjetivos.Columns[0].Name = "Id";
            dgvObjetivos.Columns[0].DataPropertyName = "id_objetivo";

            dgvObjetivos.Columns[1].Name = "Nombre Corto";
            dgvObjetivos.Columns[1].DataPropertyName = "nombre_corto";

            dgvObjetivos.Columns[2].Name = "Nombre Largo";
            dgvObjetivos.Columns[2].DataPropertyName = "nombre_largo";

            

           
            dgvObjetivos.AutoResizeColumnHeadersHeight();

            dgvObjetivos.AutoResizeRows(
                DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders);
        }

       

        

        private void dgvObjetivos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            FormObjetivosAM formABM = new FormObjetivosAM();
            Objetivos objetivoSelected = (Objetivos)dgvObjetivos.CurrentRow.DataBoundItem;
            formABM.InitializeForm(FormObjetivosAM.FormMode.eliminar, objetivoSelected);
            formABM.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            FormObjetivosAM formABM = new FormObjetivosAM();
            Objetivos objetivoSelected = (Objetivos)dgvObjetivos.CurrentRow.DataBoundItem;
            formABM.InitializeForm(FormObjetivosAM.FormMode.modificar, objetivoSelected);
            formABM.ShowDialog();

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            var filtros  = new Dictionary<string, object>();
            bool dadosBaja;
            if (checkBoxDadosBaja.Checked)
            {
                dadosBaja = true;
            }
            else
            {
                dadosBaja = false;
            }

            if (!string.IsNullOrEmpty(textBoxNombreCorto.Text))
            {
                filtros.Add("nombre_corto", textBoxNombreCorto.Text);
            }

            if (!string.IsNullOrEmpty(textBoxNombreLargo.Text))
            {
                filtros.Add("nombre_largo", textBoxNombreLargo.Text);
            }

            IList<Objetivos> listadoObjetivos = oGestorObjetivos.ConsultarSoloObjetivosConFiltro(filtros, dadosBaja);

            dgvObjetivos.DataSource = listadoObjetivos;

            if (dgvObjetivos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnEliminar.Enabled = true;
                btnModificar.Enabled = true;
            }


        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            FormObjetivosAM formABM = new FormObjetivosAM();
            formABM.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form_MenuPrincipal frmMenu = new Form_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void infoNombreCorto_MouseHover(object sender, EventArgs e)
        {
            toolTipNombreCorto.Show("Dejar en blanco para ignorar filtro de nombre corto", infoNombreCorto);
        }

        private void infoNombreLargo_MouseHover(object sender, EventArgs e)
        {
            toolTipNombreLargo.Show("Dejar en blanco para ignorar filtro de nombre largo", infoNombreLargo);
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maxBtn.Visible = false;
            restoreBtn.Visible = true;
        }
    }





  
    
}
