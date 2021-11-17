using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Clases;
using TP_PAVI.Datos.Dao;

namespace TP_PAVI.Negocio.Control
{
    public class GestorObjetivosCursos
    {
        ObjetivosCursosDAO oObjetivosCursosDAO = new ObjetivosCursosDAO();
        public void AgregarObjetivosCursos(IList<Objetivos> listadoObjetivosCursos, int id_curso)
        {
            int cantidadObjetivosCursos = listadoObjetivosCursos.Count;
            for (int i = 0; i < cantidadObjetivosCursos; i++)
            {
                int id_objetivo = listadoObjetivosCursos[i].id_objetivo;
                oObjetivosCursosDAO.Crear(id_objetivo, id_curso);
            }

        }

        public void EliminarObjetivosCursos(IList<Objetivos> listadoObjetivosCursos, int id_curso)
        {
            int cantidadObjetivosCursos = listadoObjetivosCursos.Count;
            for (int i = 0; i < cantidadObjetivosCursos; i++)
            {
                int id_objetivo = listadoObjetivosCursos[i].id_objetivo;
                oObjetivosCursosDAO.Eliminar(id_objetivo, id_curso);
            }
              

        }
    }
}
