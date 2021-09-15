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

namespace TP_PAVI
{
    public partial class Form_ABMC_Curso : Form
    {


        private GestorCursos oGestorCurso;
        private readonly GestorCategorias oGestorCategorias;
        public Form_ABMC_Curso()
        {
            InitializeComponent();
            oGestorCurso = new GestorCursos();
            oGestorCategorias = new GestorCategorias();
        }

        private void Form_Curso_Load(object sender, EventArgs e)
        {
            LlenarCombo(comboBoxCategoríaCurso, oGestorCategorias.ObtenerTodos(), "nombre", "id_categoria");
        }




        int m, mx, my;
        private void panelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            mx = e.X;
            my = e.Y;
        }
        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mx, MousePosition.Y - my);
            }

        }
        private void panelBarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }


        private void maxBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            maxBtn.Visible = false;
            restoreBtn.Visible = true;
            
        }

        private void restoreBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            restoreBtn.Visible = false;
            maxBtn.Visible = true;
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult rpta;
            rpta = MessageBox.Show("Seguro que desea salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rpta == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }



        private void minBtn_MouseEnter(object sender, EventArgs e)
        {
            this.minBtn.Image = ((System.Drawing.Image)(Properties.Resources.min_p));
        }
        private void minBtn_MouseLeave(object sender, EventArgs e)
        {
            this.minBtn.Image = ((System.Drawing.Image)(Properties.Resources.min));
        }

        private void maxBtn_MouseEnter(object sender, EventArgs e)
        {
            this.maxBtn.Image = ((System.Drawing.Image)(Properties.Resources.max_p));
        }

        private void maxBtn_MouseLeave(object sender, EventArgs e)
        {
            this.maxBtn.Image = ((System.Drawing.Image)(Properties.Resources.max));
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            this.closeBtn.Image = ((System.Drawing.Image)(Properties.Resources.close_p));
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            this.closeBtn.Image = ((System.Drawing.Image)(Properties.Resources.close));
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Close();
        }



        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            this.btnSalir.Image = ((System.Drawing.Image)(Properties.Resources.salir_p));
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            this.btnSalir.Image = ((System.Drawing.Image)(Properties.Resources.salir));
        }

        private void btnCrearCurso_MouseEnter(object sender, EventArgs e)
        {
            this.btnCrearCurso.Image = ((System.Drawing.Image)(Properties.Resources.crear_p));
        }

        private void btnCrearCurso_MouseLeave(object sender, EventArgs e)
        {
            this.btnCrearCurso.Image = ((System.Drawing.Image)(Properties.Resources.crear));
        }

        private void btnModificarCurso_MouseEnter(object sender, EventArgs e)
        {
            this.btnModificarCurso.Image = ((System.Drawing.Image)(Properties.Resources.editar_p));
        }

        private void btnModificarCurso_MouseLeave(object sender, EventArgs e)
        {
            this.btnModificarCurso.Image = ((System.Drawing.Image)(Properties.Resources.editar));
        }

        private void btnEliminarCurso_MouseEnter(object sender, EventArgs e)
        {
            this.btnEliminarCurso.Image = ((System.Drawing.Image)(Properties.Resources.eliminar_p));
        }

        private void btnEliminarCurso_MouseLeave(object sender, EventArgs e)
        {
            this.btnEliminarCurso.Image = ((System.Drawing.Image)(Properties.Resources.eliminar));
        }

        private void infoNombre_MouseEnter(object sender, EventArgs e)
        {
            groupBoxInfoNombre.Show();
        }

        private void infoNombre_MouseLeave(object sender, EventArgs e)
        {
            groupBoxInfoNombre.Hide();
        }

        private void infoCategorías_MouseEnter(object sender, EventArgs e)
        {
            groupBoxInfoCategoria.Show();
        }

        private void infoCategorías_MouseLeave(object sender, EventArgs e)
        {
            groupBoxInfoCategoria.Hide();
        }

        private void restoreBtn_MouseEnter(object sender, EventArgs e)
        {
            this.restoreBtn.Image = ((System.Drawing.Image)(Properties.Resources.res_p));
        }

        private void restoreBtn_MouseLeave(object sender, EventArgs e)
        {
            this.restoreBtn.Image = ((System.Drawing.Image)(Properties.Resources.res));
        }

        private void infoFecha_MouseEnter(object sender, EventArgs e)
        {
            groupBoxInfoFecha.Show();
        }

        private void infoFecha_MouseLeave(object sender, EventArgs e)
        {
            groupBoxInfoFecha.Hide();
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            Form_AM_Curso formulario = new Form_AM_Curso();

            // Asi obtenemos el item seleccionado de la grilla.
            var curso = (Cursos)dataGridViewCursos.CurrentRow.DataBoundItem;

            formulario.InicializarFormulario(Form_AM_Curso.FormMode.eliminar, curso);
            formulario.ShowDialog();

            //Forzamos el evento Click para actualizar el DataGridView.
            buttonConsultar_Click(sender, e);
        }

        private void btnModificarCurso_Click(object sender, EventArgs e)
        {
            Form_AM_Curso form = new Form_AM_Curso();
            var curso = (Cursos)dataGridViewCursos.CurrentRow.DataBoundItem;
            form.InicializarFormulario(Form_AM_Curso.FormMode.actualizar, curso);
            form.ShowDialog();
            //Forzamos el evento Click para actualizar el DataGridView.
            buttonConsultar_Click(sender, e);
        }

        private void btnCrearCurso_Click(object sender, EventArgs e)
        {
            Form_AM_Curso formulario = new Form_AM_Curso();
            formulario.ShowDialog();
            buttonConsultar_Click(sender, e);
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        // AGREGAR SI SE FILTRAN O NO LOS CURSOS DADOS DE BAJA AGREGANDO OTRO PARÁMETRO
        {
            // Dictionary: Representa una colección de claves y valores.
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            if (!string.IsNullOrEmpty(textBoxNombreCurso.Text))
            {
                parametros.Add("nombre", textBoxNombreCurso.Text);
            }

            DateTime fecha_vigencia;
            if (DateTime.TryParse(maskedTextBoxFecha.Text, out fecha_vigencia))
            {
                parametros.Add("fecha_vigencia", maskedTextBoxFecha.Text);
            }

            if (!string.IsNullOrEmpty(comboBoxCategoríaCurso.Text))
            {
                var id_categoria = comboBoxCategoríaCurso.SelectedValue.ToString();
                parametros.Add("id_categoria", id_categoria);
            }

            IList<Cursos> listadoBugs = oGestorCurso.ConsultarCursosConFiltro(parametros);

            dataGridViewCursos.DataSource = listadoBugs;

            if (dataGridViewCursos.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }



        //https://www.youtube.com/watch?v=kbA8QdHvAQg&ab_channel=Rub%C3%A9nAnibalRomero
        //1:51:00 VER COMO MODIFICAR LA DATAGRIDVIEW
        //2:04:00 PARA CAMBIAR LOS ATRIBUTOS DE TIPO INT A SU CLASE CORRESPONDIENTE

    }
}
