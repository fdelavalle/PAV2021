using Microsoft.Reporting.WinForms;
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
    public partial class FormReporteCantidad : Form_Plantilla
    {
        public FormReporteCantidad()
        {
            InitializeComponent();
        }

        private void FormReportes_Load(object sender, EventArgs e)
        {

            this.rpvCursos.RefreshReport();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form_MenuPrincipal frmMenu = new Form_MenuPrincipal();
            frmMenu.Show();
            this.Close();
        }

        private void btnGenerar1_Click(object sender, EventArgs e)
        {
            string strSql = "SELECT t1.nombre as nombre, count(*) as cantidad " +
                           "FROM Cursos t1, UsuariosCurso t2 " +
                           "WHERE t1.id_curso = t2.id_curso " +
                           "AND t1.fecha_vigencia between @fechaDesde AND @fechaHasta " +
                           "GROUP BY(t1.nombre)";

            Dictionary<string, object> parametros = new Dictionary<string, object>();


            DateTime fechaDesde;
            DateTime fechaHasta;
            if (DateTime.TryParse(txtFechaDesde1.Text, out fechaDesde) &&
                DateTime.TryParse(txtFechaHasta1.Text, out fechaHasta))
            {
                parametros.Add("fechaDesde", txtFechaDesde1.Text);
                parametros.Add("fechaHasta", txtFechaHasta1.Text);

                rpvCursos.LocalReport.SetParameters(new ReportParameter[]{
                    new ReportParameter("prFechaDesde", txtFechaDesde1.Text.ToString()),
                    new ReportParameter("prFechaHasta", txtFechaHasta1.Text.ToString())
                });


                //DATASOURCE
                rpvCursos.LocalReport.DataSources.Clear();
                rpvCursos.LocalReport.DataSources.Add(new ReportDataSource("DSCursos", DBHelper.getDBHelper().ConsultaSQL2(strSql, parametros)));
                rpvCursos.RefreshReport();

            }
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maxBtn.Visible = false;
            restoreBtn.Visible = true;
        }
    }
}