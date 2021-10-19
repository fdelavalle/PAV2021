using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Negocio.Entidades;

namespace TP_PAVI.Clases
{
    class UsuariosCurso
    {
        public Usuario usuario { get; set; }
        public Cursos curso { get; set; }
        public int puntuacion { get; set; }
        public string observaciones { get; set; }
        public DateTime fecha_inicioUsuariosCurso { get; set; }
        public DateTime fecha_finUsuariosCurso { get; set; }
        
    }
}
