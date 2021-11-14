using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI.Negocio.Entidades;
using TP_PAVI.Presentación.Forms_Categorias;
using TP_PAVI.Presentación.Forms_Cursos;
using TP_PAVI.Presentación.Forms_Reporte;

namespace TP_PAVI.Presentación
{
    public partial class Form_MenuPrincipal : Form_Plantilla
    {
        public Usuario usuarioLogueado;
        public Form_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form_MenuPrincipal_Load(object sender, EventArgs e)
        {
            Titulo.Text = "Menú Principal";
        }

        public Usuario obtenerUsuarioLogueado(Usuario usuarioLogeuado)
        {
            return usuarioLogeuado;
        }

        private void gestiónDeCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_ABMC_Curso formABMCCursos = new Form_ABMC_Curso();
            formABMCCursos.Show();
            this.Close();

        }

        private void actualizaciónAvancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AvancePorCurso frmAvance = new Form_AvancePorCurso();
            frmAvance.Show();
            this.Close();
        }

        private void gestiónDeCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoriasABMC frmCategorias = new FormCategoriasABMC();
            frmCategorias.Show();
            this.Close();
        }

        private void reportesCursosUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteCantidad frmReports = new FormReporteCantidad();
            frmReports.Show();
            this.Close();
        }

      

        private void reporteAvancePromedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReporteAvance frmReports = new FormReporteAvance();
            frmReports.Show();
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maxBtn.Visible = false;
            restoreBtn.Visible = true;

        }
    }
}
