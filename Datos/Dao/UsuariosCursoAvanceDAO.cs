using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Clases;
using TP_PAVI.Negocio.Entidades;

namespace TP_PAVI.Datos.Dao
{
    public class UsuariosCursoAvanceDAO
    {
        public IList<UsuariosCursoAvance> ObtenerPorFiltro(Dictionary<string, object> parametros)
        {
            List<UsuariosCursoAvance> listadoBugs = new List<UsuariosCursoAvance>();

            //FALTA MODIFICAR ESTE MÉTODO ESPECIFICANDO LOS ATRIBUTOS DEL SELECT

            var strSql = String.Concat("SELECT ucv.id_usuario as ucvId_usuario, ucv.id_curso as ucvId_curso, " +
                                       "ucv.inicio as ucvInicio, ucv.fin as ucvFin, ucv.porc_avance as ucvPorc_avance," +
                                       "u.id_usuario as uId_usuario, u.usuario as uUsuario, u.email as uEmail, " +
                                       "c.id_curso as cId_curso, c.nombre as cNombre, c.descripcion as cDescripcion " +
                                       "FROM UsuariosCursoAvance ucv JOIN Usuarios u ON u.id_usuario = ucv.id_usuario " +
                                       "JOIN Cursos c ON c.id_curso = ucv.id_curso ");

            if (parametros.ContainsKey("id_curso"))
                strSql += " WHERE (ucv.id_curso = @id_curso ) ";
            var resultadoConsulta = (DataRowCollection)DBHelper.getDBHelper().ConsultaSQL2(strSql, parametros).Rows;

            foreach (DataRow row in resultadoConsulta)
            {
                listadoBugs.Add(ObjectMapping(row));
            }
            return listadoBugs;
        }

        private UsuariosCursoAvance ObjectMapping(DataRow row)
        {
            // HAY QUE CAMBIAR TODOS LOS PARÁMETROS ROW[<<parametro>>]
            UsuariosCursoAvance oUsuariosCursoAvance = new UsuariosCursoAvance();
            oUsuariosCursoAvance.curso = new Cursos()
            {
                id_curso = Convert.ToInt32(row["cId_curso"].ToString()),
                nombre = row["cNombre"].ToString(),
                descripcion = row["cDescripcion"].ToString()
            };
            oUsuariosCursoAvance.usuario = new Usuario()
            {
                IdUsuario = Convert.ToInt32(row["uId_usuario"].ToString()),
                NombreUsuario = row["uUsuario"].ToString(),
                Email = row["uEmail"].ToString(),
            };
            oUsuariosCursoAvance.inicio = Convert.ToDateTime(row["ucvInicio"].ToString());
            oUsuariosCursoAvance.fin = Convert.ToDateTime(row["ucvFin"].ToString());
            oUsuariosCursoAvance.porc_avance = Convert.ToInt16(row["ucvPorc_avance"].ToString());
            return oUsuariosCursoAvance;
        }

        public void ActualizarAvance(IList<UsuariosCursoAvance> listadoAlumnos, int avance)
        {
            int cant = listadoAlumnos.Count;
            for (int i = 0; i < cant; i++)
            {
                int id_usuario = listadoAlumnos[i].usuario.IdUsuario;
                string strSql = "UPDATE UsuariosCursoAvance set porc_avance = " + avance + " WHERE id_usuario = "+id_usuario+" ";
                DBHelper.getDBHelper().EjecutarSQL(strSql);
            }
        }
    }
}
