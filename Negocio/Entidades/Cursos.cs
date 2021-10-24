using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI.Clases
{
    public class Cursos
    {
        public int id_curso { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public DateTime fecha_vigencia { get; set; }
        public Categorias categoria  { get; set; }
        public bool borrado { get; set; }

        public Cursos()
        {

        }
    }
}
