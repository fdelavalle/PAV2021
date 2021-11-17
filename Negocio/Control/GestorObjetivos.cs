using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Clases;
using TP_PAVI.Datos.Dao;

namespace TP_PAVI.Negocio.Control
{

    public class GestorObjetivos
    {
        private ObjetivosDAO oObjetivosDAO;

        public GestorObjetivos()
        {
            oObjetivosDAO = new ObjetivosDAO();
        }

        public IList<Objetivos> ObtenerTodos()
        {
            return oObjetivosDAO.FindAll();
        }

        public IList<Objetivos> ConsultarObjetivosConFiltro(Dictionary<string, object> parametros, bool dadosBaja)
        {
            return oObjetivosDAO.ObtenerCursosPorFiltro(parametros, dadosBaja);
        }

        internal bool CrearObjetivos(Objetivos oObjetivo)
        {
            return oObjetivosDAO.CrearObjetivo(oObjetivo);
        }

        public IList<Objetivos> ConsultarSoloObjetivosConFiltro(Dictionary<string, object> parametros, bool dadosBaja)
        {
            return oObjetivosDAO.ObtenerObjetivosConFiltro(parametros, dadosBaja);
        }


        internal bool ActualizarObjetivos(Objetivos oObjetivo)
        {
            return oObjetivosDAO.ActualizarObjetivo(oObjetivo);
        }

        internal bool EliminarObjetivos(Objetivos oObjetivo)
        {
            return oObjetivosDAO.EliminarObjetivo(oObjetivo);
        }



    }
}
