using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_PAVI.Datos.Dao
{
    public class ObjetivosCursosDAO
    {
        public void Crear(int id_objetivo, int id_curso)
        {
            string strSql = "INSERT INTO ObjetivosCursos (id_objetivo, id_curso, puntos, borrado) VALUES ('"+id_objetivo+ "','" + id_curso + "', NULL, '0')";
            DBHelper.getDBHelper().EjecutarSQL(strSql);
        }
        public void Eliminar(int id_objetivo, int id_curso)
        {
            string strSql = "DELETE FROM ObjetivosCursos WHERE id_objetivo = " + id_objetivo + " AND id_curso =  " + id_curso + "";
            DBHelper.getDBHelper().EjecutarSQL(strSql);
        }
    }
}
