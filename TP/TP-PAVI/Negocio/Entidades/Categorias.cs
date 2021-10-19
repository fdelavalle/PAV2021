using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Negocio.Entidades;

namespace TP_PAVI.Clases
{
    public class Categorias
    {
        public int id_categoria { get; set; }
        public string nombreCategoria { get; set; }
        public string descripcionCategoria { get; set; }
        public bool borradoCategoria { get; set; }

        public override string ToString()
        {
            return nombreCategoria;
        }

    }
}
