using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PAVI.Presentación;

namespace TP_PAVI.Presentación
{
    public partial class Form_Plantilla_ABMC : FormPlantilla
    {
        public Form_Plantilla_ABMC()
        {
            InitializeComponent();
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            this.btnExit.Image = ((System.Drawing.Image)(Properties.Resources.exit_p));
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.Image = ((System.Drawing.Image)(Properties.Resources.salir));
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
            this.btnEliminar.Image = ((System.Drawing.Image)(Properties.Resources.eliminar_p));
        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            this.btnEliminar.Image = ((System.Drawing.Image)(Properties.Resources.icons8_delete_64));
        }

        private void btnModificar_MouseEnter(object sender, EventArgs e)
        {
            this.btnModificar.Image = ((System.Drawing.Image)(Properties.Resources.edit_p));
        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            this.btnModificar.Image = ((System.Drawing.Image)(Properties.Resources.icons8_edit_96));
        }

        private void btnCrear_MouseEnter(object sender, EventArgs e)
        {
            this.btnCrear.Image = ((System.Drawing.Image)(Properties.Resources.crear_p));
        }

        private void btnCrear_MouseLeave(object sender, EventArgs e)
        {
            this.btnCrear.Image = ((System.Drawing.Image)(Properties.Resources.icons8_create_90));
        }


    }
}
