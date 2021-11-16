using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI.Clases
{
    public class Objetivos
    {
        public int id_objetivo { get; set; }
        public string nombre_corto { get; set; }
        public string nombre_largo { get; set; }
        public bool borrado { get; set; }
        public int objetivos_cursos { get; set; }            //CONSULTAR PROFE


    }
}
