using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI.Clases
{
    class ObjetivosCursos
    {
        public int id_objetivo { get; set; }
        public Cursos curso { get; set; }
        public int puntos { get; set; }
        public bool borrado { get; set; }
    }
}
