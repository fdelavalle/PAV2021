using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI.Clases
{
    class UsuariosCurso
    {
        public int id_usuario { get; set; }
        public int id_curso { get; set; }
        public int puntuacion { get; set; }
        public string observaciones { get; set; }
        public DateTime fecha_inicio { get; set; }
        public DateTime fecha_fin { get; set; }
        public int usuario_curso_avance { get; set; }
    }
}
