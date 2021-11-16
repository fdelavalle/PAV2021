using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Negocio.Entidades;

namespace TP_PAVI.Clases
{
    public class UsuariosCursoAvance
    {
        public Usuario usuario { get; set; }
        public Cursos curso { get; set; }
        public DateTime inicio { get; set; }
        public DateTime fin { get; set; }
        public int porc_avance { get; set; }

        public string Email { get { return usuario.Email; } }
        public string Nombre { get { return usuario.NombreUsuario; } }

    }
}
