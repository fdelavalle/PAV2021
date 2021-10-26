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
            List<Categorias> listadoCategoria = new List<Categorias>();

            var strSql = "SELECT * from Categorias";

            var resultadoConsulta = (DataRowCollection)DBHelper.getDBHelper().ConsultaSQL(strSql).Rows;

            if (resultadoConsulta.Count > 0)
            {
                foreach (DataRow row in resultadoConsulta)
                {
                    listadoCategoria.Add(ObjectMapping(row));

                    /*Categorias aux = new Categorias();
                    aux.id_categoria = Int32.Parse(filas[0].ToString());
                    aux.nombreCategoria = filas[1].ToString();
                    aux.descripcionCategoria = filas[2].ToString();
                    catego.Add(aux);
                    */
                }
            }           
           
            return listadoCategoria;
        }

        public IList<Categorias> ObtenerCategoriasPorFiltro(Dictionary<string, object> parametros)
        {
            List<Categorias> listadoCategoria = new List<Categorias>();

            //FALTA MODIFICAR ESTE MÉTODO
            var strSql = String.Concat("select c.id_categoria,c.nombre ,c.descripcion, c.borrado from categorias c where c.borrado=0");

            if (parametros.ContainsKey("nombre"))
                strSql += " AND (c.nombre = @nombre) ";

            var resultadoConsulta = (DataRowCollection)DBHelper.getDBHelper().ConsultaSQL2(strSql, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoCategoria.Add(ObjectMapping(row));
            }
            return listadoCategoria;
        }
        public Categorias GetCategoria(string nombreCategoria)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT * FROM CATEGORIAS WHERE nombre = @nombre");

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombreCategoria);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.getDBHelper().ConsultaSQL2(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }


      

        internal bool Create(Categorias oCategoria)
        {
            string str_sql = "     INSERT INTO Categorias (id_categoria, nombre, descripcion, borrado)" +
                             "     VALUES (@id_categoria, @nombre, @descripcion, 0)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_categoria", ObtenerUltimoId());
            parametros.Add("nombre", oCategoria.nombreCategoria);
            parametros.Add("descripcion", oCategoria.descripcionCategoria);
            

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(str_sql, parametros) == 1);
        }


        internal bool Delete(Categorias oCategoria)
        {
            string str_sql = "  UPDATE Categorias" +
                            "     SET borrado = 1" +
                            "   WHERE id_categoria = @id_categoria";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_categoria", oCategoria.id_categoria);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(str_sql, parametros) == 1);
        }

        private int ObtenerUltimoId()
        {
            int id = 0;
            string str_sql = "SELECT MAX(id_categoria) FROM CATEGORIAS";
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(str_sql);
            id = int.Parse(tabla.Rows[0][0].ToString());
            return id + 1;
        }

        private Categorias ObjectMapping(DataRow row)
        {
            Categorias aux1 = new Categorias();
            {
                aux1.id_categoria = Convert.ToInt32(row[0].ToString());
                aux1.nombreCategoria = row[1].ToString();
                aux1.descripcionCategoria = row[2].ToString();
                aux1.borradoCategoria = Convert.ToBoolean(row[3].ToString());
                

            }
            return aux1;
        }

        internal bool Update(Categorias oCategoria)
        {
            string str_sql = "  UPDATE Categorias" +
                            "     SET nombre = @nombre," +
                            "         descripcion = @descripcion, " +                   
                            "         id_categoria = @id_categoria" +
                            "   WHERE id_categoria = @id_categoria";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_categoria", oCategoria.id_categoria);
            parametros.Add("nombre", oCategoria.nombreCategoria);
            parametros.Add("descripcion", oCategoria.descripcionCategoria);

            // cambiar
            // cambiar     parametros.Add("id_categoria", oCursos.id_categoria);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(str_sql, parametros) == 1);
        }


    }
}
