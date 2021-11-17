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
            
            Objetivos oObjetivo = new Objetivos();
            oObjetivo.id_objetivo = Convert.ToInt32(row["oId_objetivo"].ToString());
            oObjetivo.nombre_corto = row["oNombre_corto"].ToString();
            oObjetivo.nombre_largo = row["oNombre_largo"].ToString();
            oObjetivo.borrado = Convert.ToBoolean(row["oBorrado"].ToString());
            return oObjetivo;
        }

        public bool CrearObjetivo(Objetivos objetivo)
        {
            String sentencia_sql = " INSERT INTO Objetivos (id_objetivo, nombre_corto, nombre_largo, borrado) " +
                " VALUES (@id_objetivo, @nombre_corto, @nombre_largo, 0) ";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_objetivo", ObtenerUltimoId());
            parametros.Add("nombre_corto", objetivo.nombre_corto);
            parametros.Add("nombre_largo", objetivo.nombre_largo);


            return (DBHelper.getDBHelper().EjecutarSQL2(sentencia_sql, parametros) == 1);

        }

        private int ObtenerUltimoId()
        {
            int id = 0;
            string str_sql = "SELECT MAX(id_objetivo) FROM OBJETIVOS";
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(str_sql);
            id = int.Parse(tabla.Rows[0][0].ToString());
            return id + 1;
        }


      





        public bool ActualizarObjetivo(Objetivos objetivo)
        {

            String sentencia_sql = string.Concat("UPDATE Objetivos ",
                                                 "SET ",
                                                 "nombre_corto = @nombre_corto, ",
                                                 "nombre_largo = @nombre_largo ",
                                                 "WHERE id_objetivo = @id_objetivo");

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_objetivo", objetivo.id_objetivo);
            parametros.Add("nombre_corto", objetivo.nombre_corto);
            parametros.Add("nombre_largo", objetivo.nombre_largo);

            return (DBHelper.getDBHelper().EjecutarSQL2(sentencia_sql, parametros) == 1);
        }


        public bool EliminarObjetivo(Objetivos objetivo)
        {
            String sentencia_sql = " UPDATE Objetivos SET borrado = 1 WHERE id_objetivo = @id_objetivo";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_objetivo", objetivo.id_objetivo);

            return (DBHelper.getDBHelper().EjecutarSQL2(sentencia_sql, parametros) == 1);
        }


        public IList<Objetivos> ObtenerObjetivosConFiltro(Dictionary<string, object> parametros, bool incluirBorrados = false)
        {
            List<Objetivos> listaObjetivos = new List<Objetivos>();
           
            String strSql = string.Concat("SELECT O.id_objetivo as oId_objetivo, O.nombre_corto as oNombre_corto, O.nombre_largo as oNombre_largo," +
                " O.borrado as oBorrado FROM Objetivos O ");


            if (!incluirBorrados)
            {
                strSql += "WHERE (O.borrado = 0) ";
            }
            else
            {
                strSql += "WHERE (O.borrado = 0 OR o.borrado = 1) ";
            }

            

            if (parametros.ContainsKey("nombre_corto"))
            {
                strSql += "AND O.nombre_corto LIKE '%' + @nombre_corto  + '%' ";
            }
            if (parametros.ContainsKey("nombre_largo"))
            {
                strSql += "AND O.nombre_largo LIKE '%' + @nombre_largo  + '%'  ";
            }

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQLFacu(strSql, parametros);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listaObjetivos.Add(ObjectMapping(row));
            }

            return listaObjetivos;
        }


    }
}
