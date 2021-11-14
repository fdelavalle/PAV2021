using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI.Datos;

namespace TP_PAVI.Presentación.Forms_Reporte
{
    public partial class FormReporteAvance : Form_Plantilla
    {
        public FormReporteAvance()
        {
            InitializeComponent();
        }

        private void FormReporteAvance_Load(object sender, EventArgs e)
        {

            this.rpvAvances.RefreshReport();

            string strSql = "SELECT Cursos.nombre as nombreCurso, avg(porc_avance) as porcentaje, Cursos.id_curso " +
                            "FROM UsuariosCursoAvance " +
                            "INNER JOIN Cursos ON UsuariosCursoAvance.id_curso = Cursos.id_curso " +
                            "GROUP BY Cursos.id_curso, Cursos.nombre ";

            rpvAvances.LocalReport.DataSources.Clear();
            rpvAvances.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DSCursos", DBHelper.getDBHelper().ConsultaSQL(strSql)));
            rpvAvances.RefreshReport();



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form_MenuPrincipal frmMenu = new Form_MenuPrincipal();
            frmMenu.Show();
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
