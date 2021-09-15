using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Clases;

namespace TP_PAVI.Datos.Dao
{
    class CursosDAO
    {
        public List<Cursos> FindAll()                                       //Listar todos los cursos ordenados alfabéticamente
        {
            List<Cursos> lst = new List<Cursos>();
            string query = "SELECT * FROM CURSOS ORDER BY nombre";
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(query);
            
            foreach (DataRow filas in tabla.Rows)
            {
                Cursos aux = new Cursos();
                aux.id_curso = Int32.Parse(filas[0].ToString());            //Como se usa un Int32 hay que validar que en el textbox_id no se puedan ingresar más de 32 dígitos
                aux.nombre = filas[1].ToString();
                aux.descripcion = filas[2].ToString();
                aux.fecha_vigencia = DateTime.Parse(filas[3].ToString());
                aux.id_categoria = Int32.Parse(filas[4].ToString());
                aux.borrado = bool.Parse(filas[5].ToString());
            } 

            return lst;
        }


        // MÉTODOS CRUD

        public bool CreateOrUpdate (int id)             //Falta implementar
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
                aux.id_categoria = Int32.Parse(t.Rows[0][4].ToString());
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
            parametros.Add("id_categoria", oCursos.id_categoria);

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
            parametros.Add("id_categoria", oCursos.id_categoria);

            // Si una fila es afectada por la actualización retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(str_sql, parametros) == 1);
        }



        private int ObtenerUltimoId()
        {
            int id = 0;
            string str_sql = "SELECT MAX(id_curso) FROM CURSOS";
            DataTable tabla = DBHelper.getDBHelper().ConsultaSQL(str_sql);
            id = int.Parse(tabla.Rows[0][0].ToString());
            return id+1;
        }


        public IList<Cursos> ObtenerCursosPorFiltro(Dictionary<string, object> parametros)
        {
            List<Cursos> listadoBugs = new List<Cursos>();
           
                //FALTA MODIFICAR ESTE MÉTODO
            var strSql = String.Concat("SELECT * FROM Cursos WHERE borrado = 0");

            if (parametros.ContainsKey("nombre"))
                strSql += " AND (nombre = @nombre) ";
            if (parametros.ContainsKey("id_categoria"))
                strSql += " AND (id_categoria=@id_categoria)";
            if (parametros.ContainsKey("fecha_vigencia"))
                strSql += " AND (fecha_vigencia >= @fecha_vigencia) ";
            var resultadoConsulta = (DataRowCollection)DBHelper.getDBHelper().ConsultaSQL2(strSql, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoBugs.Add(ObjectMapping(row));
            }
            return listadoBugs;
        }



        private Cursos ObjectMapping(DataRow row)
        {
            Cursos oCursos = new Cursos();
            oCursos.id_curso = Convert.ToInt32(row["id_curso"].ToString());
            oCursos.nombre = row["nombre"].ToString();
            oCursos.descripcion = row["descripcion"].ToString();
            oCursos.fecha_vigencia = Convert.ToDateTime(row["fecha_vigencia"].ToString());
            oCursos.id_categoria = Convert.ToInt32(row["id_categoria"].ToString());
            oCursos.borrado = Convert.ToBoolean(row["borrado"].ToString());

            //HAY QUE CAMBIAR id_categoria de int a tipo Categoria

            return oCursos;
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
