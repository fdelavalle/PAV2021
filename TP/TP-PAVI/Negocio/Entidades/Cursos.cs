using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Negocio.Entidades;

namespace TP_PAVI.Clases
{
    public class Cursos
    {
        public int id_curso { get; set; }
        public string nombreCurso { get; set; }
        public string descripcionCurso { get; set; }
        public DateTime fecha_vigenciaCurso { get; set; }

        public bool borradoCurso { get; set; }

       public Categorias categoriaCurso { get; set; }

        public override string ToString()
        {
            return nombreCurso;
        }

       


    }
}
