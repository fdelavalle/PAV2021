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

namespace TP_PAVI.Presentación.Forms_Cursos
{
    public partial class Form_ModificacionCurso : Form_AltaCurso
    {
        public Form_ModificacionCurso()
        {
            InitializeComponent();
            Titulo.Text = "Actualizar curso";
        }
    }
}
