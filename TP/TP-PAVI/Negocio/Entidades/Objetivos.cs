using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Negocio.Entidades;

namespace TP_PAVI.Clases
{
    class Objetivos
    {
        public int id_objetivo { get; set; }
        public string nombre_cortoObjetivo { get; set; }
        public string nombre_largoObjetivo { get; set; }
        public bool borradoObjetivo { get; set; }

        public override string ToString()
        {
            return nombre_largoObjetivo;
        }

    }
}
