using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Clases;
using TP_PAVI.Datos;
using System.Data.SqlClient;

namespace TP_PAVI.Datos.Dao
{
    class CursosDAO
    {
        public List<Cursos> FindAll()      //Listar todos los cursos ordenados alfabéticamente
        {
            List<Cursos> listadoCurso = new List<Cursos>();
            var strSql = "";
            strSql = String.Concat("SELECT c.id_curso as cId, c.nombre as cNombre, " +
                              "c.descripcion as cDescripcion, c.borrado as cBorrado, " +
                              "c.fecha_vigencia as cFecha, " +
                              "ca.id_categoria as caId, ca.nombre as caNombre, " +
                              "ca.Descripcion as caDescripcion, ca.borrado as caBorrado " +
                              "FROM Cursos c JOIN Categorias ca ON ca.id_categoria = c.id_categoria " +
                              "WHERE c.borrado = 0 ORDER BY c.id_curso ");
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(strSql);


            foreach (DataRow row in tabla.Rows)
            {
                listadoCurso.Add(ObjectMapping(row));
            }

            return listadoCurso;
        }


        // MÉTODOS CRUD

        public bool CreateOrUpdate (int id)      //Falta implementar
        {
            throw new NotImplementedException();
        }
        
        public Cursos ReadById (int id)
        {
            Cursos aux = null;
            string query = "SELECT * FROM CURSOS WHERE id_curso = param1";
            DataTable t = DBHelper.getDBHelper().ConsultaSQLConParametros(query, new object[] { id });
            if (t.Rows.Count == 1)
            {
                aux = new Cursos();
                aux.id_curso = Int32.Parse(t.Rows[0][0].ToString());
                aux.descripcion = t.Rows[0][2].ToString();
                aux.fecha_vigencia = DateTime.Parse(t.Rows[0][3].ToString());
                aux.categoria.id_categoria = Int32.Parse(t.Rows[0][4].ToString());
                aux.borrado = bool.Parse(t.Rows[0][5].ToString());
            }
            return aux;
        }


        internal bool Delete(Cursos oCursos)
        {
            string str_sql = "  UPDATE Cursos" +
                            "     SET borrado = 1" +
                            "   WHERE id_curso = @id_curso";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_curso", oCursos.id_curso);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(str_sql, parametros) == 1);
        }

        internal bool Create(Cursos oCursos)
        {
            string str_sql = "     INSERT INTO Cursos (id_curso, nombre, descripcion, fecha_vigencia, id_categoria, borrado)" +
                             "     VALUES (@id_curso, @nombre, @descripcion, @fecha_vigencia, @id_categoria, 0)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_curso", ObtenerUltimoId());
            parametros.Add("nombre", oCursos.nombre);
            parametros.Add("descripcion", oCursos.descripcion);
            parametros.Add("fecha_vigencia", oCursos.fecha_vigencia);
            parametros.Add("id_categoria", oCursos.categoria.id_categoria);

            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(str_sql, parametros) == 1);
        }

        internal bool Update(Cursos oCursos)
        {
            string str_sql = "  UPDATE Cursos" +
                            "     SET nombre = @nombre," +
                            "         descripcion = @descripcion, " +
                            "         fecha_vigencia = @fecha_vigencia, " +
                            "         id_categoria = @id_categoria" +
                            "   WHERE id_curso = @id_curso";

            var parametros = new Dictionary<string, object>();
            parametros.Add("id_curso", oCursos.id_curso);
            parametros.Add("nombre", oCursos.nombre);
            parametros.Add("descripcion", oCursos.descripcion);
            parametros.Add("fecha_vigencia", oCursos.fecha_vigencia);
            parametros.Add("id_categoria", oCursos.categoria.id_categoria);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(str_sql, parametros) == 1);
        }



        public int ObtenerUltimoId()
        {
            int id = 0;
            string str_sql = "SELECT MAX(id_curso) FROM CURSOS";
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(str_sql);
            id = int.Parse(tabla.Rows[0][0].ToString());
            return id + 1;
        }


        public IList<Cursos> ObtenerCursosPorFiltro(Dictionary<string, object> parametros, bool dadosBaja)
        {
            List<Cursos> listadoBugs = new List<Cursos>();

            //FALTA MODIFICAR ESTE MÉTODO ESPECIFICANDO LOS ATRIBUTOS DEL SELECT
            var strSql = "";
            if (dadosBaja)
            {
                strSql = String.Concat("SELECT c.id_curso as cId, c.nombre as cNombre, " +
                                       "c.descripcion as cDescripcion, c.borrado as cBorrado," +
                                       "c.fecha_vigencia as cFecha, " +
                                       "ca.id_categoria as caId, ca.nombre as caNombre, " +
                                       "ca.Descripcion as caDescripcion, ca.borrado as caBorrado " +
                                       "FROM Cursos c INNER JOIN  Categorias ca ON ca.id_categoria = c.id_categoria ");
            }
            else
            {
                strSql = String.Concat("SELECT c.id_curso as cId, c.nombre as cNombre, " +
                                       "c.descripcion as cDescripcion, c.borrado as cBorrado, " +
                                       "c.fecha_vigencia as cFecha, " +
                                       "ca.id_categoria as caId, ca.nombre as caNombre, " +
                                       "ca.Descripcion as caDescripcion, ca.borrado as caBorrado " +
                                       "FROM Cursos c INNER JOIN Categorias ca ON ca.id_categoria = c.id_categoria " +
                                       "WHERE c.borrado = 0");
            }


            if (parametros.ContainsKey("nombre"))
                strSql += " AND (c.nombre LIKE @nombre + '%') ";
            if (parametros.ContainsKey("id_categoria"))
                strSql += " AND (c.id_categoria=@id_categoria)";
            if (parametros.ContainsKey("fecha_vigencia"))
                strSql += " AND (c.fecha_vigencia >= @fecha_vigencia) ";
            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQLFacu(strSql, parametros);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(ObjectMapping(row));
            }
            return listadoBugs;
        }



        private Cursos ObjectMapping(DataRow row)
        {
            // HAY QUE CAMBIAR TODOS LOS PARÁMETROS ROW[<<parametro>>]
            Cursos oCursos = new Cursos();
            oCursos.id_curso = Convert.ToInt32(row["cId"].ToString());
            oCursos.nombre = row["cNombre"].ToString();
            oCursos.descripcion = row["cDescripcion"].ToString();
            oCursos.fecha_vigencia = Convert.ToDateTime(row["cFecha"].ToString());
            oCursos.categoria = new Categorias
            {
                id_categoria = Convert.ToInt32(row["caId"].ToString()),
                borrado = Convert.ToBoolean(row["caBorrado"].ToString()),
                nombre = row["caNombre"].ToString(),
                descripcion = row["caDescripcion"].ToString()
            };
            oCursos.borrado = Convert.ToBoolean(row["cBorrado"].ToString());
            return oCursos;
        }


        public bool Exist(String cursoNombre)
        {

            String consulta = string.Concat("SELECT * FROM Cursos C WHERE C.nombre = @cursoNombre");

            var parametros = new Dictionary<string, object>();
            parametros.Add("cursoNombre", cursoNombre);

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQLFacu(consulta, parametros);

            if (resultadoConsulta.Rows.Count != 0)
                return true;

            return false;
        }


        public Cursos GetCurso(string nombreCurso)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT * FROM CURSOS WHERE nombre = @nombre");

            var parametros = new Dictionary<string, object>();
            parametros.Add("nombre", nombreCurso);
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
