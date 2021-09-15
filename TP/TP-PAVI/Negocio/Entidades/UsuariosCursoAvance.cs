using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI.Clases
{
    class UsuariosCursoAvance
    {
        public int id_usuario { get; set; }
        public int id_curso { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public int porc_avance { get; set; }

    }
}
