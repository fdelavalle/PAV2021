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
            List<Categorias> catego = new List<Categorias>();

            var strSql = "SELECT * from Categorias";

            var resultado = DBHelper.getDBHelper().ConsultaSQL(strSql);

            if (resultado.Rows.Count > 0)
            {
                foreach (DataRow filas in resultado.Rows)
                {
                    Categorias aux = new Categorias();
                    aux.id_categoria = Int32.Parse(filas[0].ToString());
                    aux.nombreCategoria = filas[1].ToString();
                    aux.descripcionCategoria = filas[2].ToString();
                    catego.Add(aux);
                }
            }
            
           

            return catego;
        }

        private Categorias ObjectMapping(DataRow row)
        {
            Categorias oCategorias = new Categorias
            {
                id_categoria = Convert.ToInt32(row["id_categoria"].ToString()),
                nombreCategoria = row["nombre"].ToString()
            };

            return oCategorias;
        }


    }
}
