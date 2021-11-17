using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Clases;

namespace TP_PAVI.Datos.Dao
{
    public class ObjetivosDAO
    {
        public List<Objetivos> FindAll()
        {
            List<Objetivos> listadoObjetivos = new List<Objetivos>();
            var strSql = "";
            strSql = String.Concat("SELECT id_objetivo as oId_objetivo, nombre_corto as oNombre_corto, " +
                                   "nombre_largo as oNombre_largo, borrado as oBorrado FROM Objetivos");
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(strSql);
            foreach (DataRow row in tabla.Rows)
            {
                listadoObjetivos.Add(ObjectMapping(row));
            }
            return listadoObjetivos;
        }

        public IList<Objetivos> ObtenerCursosPorFiltro(Dictionary<string, object> parametros, bool dadosBaja)
        {
            List<Objetivos> listadoObjetivos = new List<Objetivos>();
            var strSql = "";
            if (dadosBaja)
            {
                strSql = String.Concat("SELECT o.id_objetivo as oId_objetivo, o.nombre_corto as oNombre_corto, " +
                                       "o.nombre_largo as oNombre_largo, o.borrado as oBorrado FROM Objetivos o " +
                                       "JOIN ObjetivosCursos oc ON oc.id_objetivo = o.id_objetivo ");
                if (parametros.ContainsKey("curso"))
                    strSql += " WHERE (oc.id_curso = @curso) ";
            }
            else
            {
                strSql = String.Concat("SELECT o.id_objetivo as oId_objetivo, o.nombre_corto as oNombre_corto, " +
                                       "o.nombre_largo as oNombre_largo, o.borrado as oBorrado FROM Objetivos o " +
                                       "JOIN ObjetivosCursos oc ON oc.id_objetivo = o.id_objetivo " +
                                       "WHERE o.borrado = 0 ");
                if (parametros.ContainsKey("curso"))
                    strSql += " AND (oc.id_curso = @curso) ";
            }
            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQLFacu(strSql, parametros);
            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoObjetivos.Add(ObjectMapping(row));
            }
            return listadoObjetivos;
        }

        private Objetivos ObjectMapping(DataRow row)
        {
            // HAY QUE CAMBIAR TODOS LOS PARÁMETROS ROW[<<parametro>>]
            Objetivos oObjetivo = new Objetivos();
            oObjetivo.id_objetivo = Convert.ToInt32(row["oId_objetivo"].ToString());
            oObjetivo.nombre_corto = row["oNombre_corto"].ToString();
            oObjetivo.nombre_largo = row["oNombre_largo"].ToString();
            oObjetivo.borrado = Convert.ToBoolean(row["oBorrado"].ToString());
            return oObjetivo;
        }
    }
}
