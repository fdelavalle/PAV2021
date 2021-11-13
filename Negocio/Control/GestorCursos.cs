using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Clases;
using TP_PAVI.Datos.Dao;

namespace TP_PAVI.Negocio.Control
{
    public class GestorCursos
    {
        private CursosDAO oCursosDAO;
        public GestorCursos()
        {
            oCursosDAO = new CursosDAO();
        }
        public IList<Cursos> ObtenerTodos()
        {
            return oCursosDAO.FindAll();
        }

        public IList<Cursos> ConsultarCursosConFiltro(Dictionary<string, object> parametros, bool dadosBaja)
        {
            return oCursosDAO.ObtenerCursosPorFiltro(parametros, dadosBaja);
        }

        internal object ObtenerCurso(string usuario)
        {
            return oCursosDAO.GetCurso(usuario);
        }

        internal bool CrearCurso(Cursos oCursos)
        {
            return oCursosDAO.Create(oCursos);
        }

        internal bool ActualizarCurso(Cursos oCursoSelected)
        {
            return oCursosDAO.Update(oCursoSelected);
        }

        internal bool EliminarCurso(Cursos oCursoSelected)
        {
            return oCursosDAO.Delete(oCursoSelected);
        }

        internal int ObtenerUltimoId()
        {
            return oCursosDAO.ObtenerUltimoId();
        }

        internal bool ExisteCurso(string oCursoSelected)
        {
            return oCursosDAO.Exist(oCursoSelected);
        }


    }
}
