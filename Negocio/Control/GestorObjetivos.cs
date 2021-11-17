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
        ObjetivosDAO oObjetivosDAO = new ObjetivosDAO();
        public IList<Objetivos> ObtenerTodos()
        {
            return oObjetivosDAO.FindAll();
        }

        public IList<Objetivos> ConsultarObjetivosConFiltro(Dictionary<string, object> parametros, bool dadosBaja)
        {
            return oObjetivosDAO.ObtenerCursosPorFiltro(parametros, dadosBaja);
        }

    }
}
