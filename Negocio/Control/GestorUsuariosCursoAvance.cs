using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Clases;
using TP_PAVI.Datos.Dao;

namespace TP_PAVI.Negocio.Control
{
    public class GestorUsuariosCursoAvance
    {
        UsuariosCursoAvanceDAO oUsuariosCursoAvanceDAO = new UsuariosCursoAvanceDAO();
        public IList<UsuariosCursoAvance> ConsultarConFiltro(Dictionary<string, object> parametros)
        {
            return oUsuariosCursoAvanceDAO.ObtenerPorFiltro(parametros);
        }

        public void ActualizarAvance(IList<UsuariosCursoAvance> listadoAlumnos, int avance)
        {
            oUsuariosCursoAvanceDAO.ActualizarAvance(listadoAlumnos, avance);
        }
    }
}
