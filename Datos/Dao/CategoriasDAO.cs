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

            var strSql = "SELECT * FROM Categorias where borrado=0";

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

        public IList<Categorias> ObtenerCategoriasPorFiltro(Dictionary<string, object> parametros)
        {
            List<Categorias> listadoCategoria = new List<Categorias>();

            
            var strSql = String.Concat("select c.id_categoria,c.nombre ,c.descripcion, c.borrado from categorias c where c.borrado=0");

            if (parametros.ContainsKey("nombre"))
            {
                strSql += "AND (c.nombre LIKE '%' + @nombre + '%')";
            }

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQLFacu(strSql, parametros);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoCategoria.Add(ObjectMapping(row));
            }
            return listadoCategoria;
        }
        internal bool crearCategorias(Categorias categoria)
        {
            string str_sql = "     INSERT INTO Categorias (id_categoria, nombre, descripcion, borrado)" +
                             "     VALUES (@id_categoria, @nombre, @descripcion, 0)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_categoria", ObtenerUltimoId());
            parametros.Add("nombre", categoria.nombre);
            parametros.Add("descripcion", categoria.descripcion);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(str_sql, parametros) == 1);

        }

        internal bool actualizarCategorias(Categorias categoriaSelected)
        {
            string strSql = "UPDATE Categorias SET nombre = @nombre, descripcion = @descripcion WHERE id_categoria = @id_categoria";
            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", categoriaSelected.nombre);
            parametros.Add("descripcion", categoriaSelected.descripcion);
            parametros.Add("id_categoria", categoriaSelected.id_categoria);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(strSql, parametros) == 1);

        }

        private int ObtenerUltimoId()
        {
            int id = 0;
            string str_sql = "SELECT MAX(id_categoria) FROM CATEGORIAS";
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(str_sql);
            id = int.Parse(tabla.Rows[0][0].ToString());
            return id + 1;
        }



        internal bool eliminarCategorias(Categorias categoriaSelected)
        {
            string strSql = "UPDATE Categorias SET borrado = 1 WHERE id_categoria = @id_categoria";
            var parametros = new Dictionary<string, object>();
            parametros.Add("id_categoria", categoriaSelected.id_categoria);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(strSql, parametros) == 1);

        }

        internal Categorias obtenerCategoria(string nombreCategoria)
        {
            String strSql = string.Concat("SELECT id_categoria, nombre, descripcion FROM Categorias WHERE nombre = @nombre");
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


    }
}
