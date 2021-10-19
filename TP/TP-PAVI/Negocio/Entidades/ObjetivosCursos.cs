using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Negocio.Entidades;

namespace TP_PAVI.Clases
{
    class ObjetivosCursos
    {
        public Cursos curso { get; set; }
        public Objetivos objetivo { get; set; }
        public int puntos { get; set; }
        public bool borradoObjetivosCursos { get; set; }
    }
}
