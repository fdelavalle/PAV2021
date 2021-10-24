using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Clases;

namespace TP_PAVI.Datos.Dao
{
    class CategoriasDAO
    {
        public IList<Categorias> FindAll()
        {
            List<Categorias> listadoBugs = new List<Categorias>();

            var strSql = "SELECT id_categoria, nombre, descripcion, borrado from Categorias";

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(ObjectMapping(row));
            }

            return listadoBugs;
        }

        private Categorias ObjectMapping(DataRow row)
        {
            Categorias oCategorias = new Categorias
            {
                id_categoria = Convert.ToInt32(row["id_categoria"].ToString()),
                nombre = row["nombre"].ToString(),
                descripcion = row["descripcion"].ToString(),
                borrado = Convert.ToBoolean(row["borrado"].ToString())
            };

            return oCategorias;
        }


    }
}
