using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Negocio.Entidades;


namespace TP_PAVI.Negocio.Entidades
{
    public class Perfil
    {
        public int IdPerfil { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
