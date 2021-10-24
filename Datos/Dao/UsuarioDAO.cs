using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Negocio.Entidades;

namespace TP_PAVI.Datos.Dao
{
    public class UsuarioDAO
    {
        public IList<Usuario> GetAll()
        {
            List<Usuario> listadoBugs = new List<Usuario>();

            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil " +
                                          "  WHERE u.borrado = 0 ");

            var resultadoConsulta = DBHelper.getDBHelper().ConsultaSQL(strSql);

            foreach (DataRow row in resultadoConsulta.Rows)
            {
                listadoBugs.Add(ObjectMapping(row));
            }

            return listadoBugs;
        }
        public Usuario GetUser(string nombreUsuario)
        {
            //Construimos la consulta sql para buscar el usuario en la base de datos.
            String strSql = string.Concat(" SELECT id_usuario, ",
                                          "        usuario, ",
                                          "        email, ",
                                          "        password, ",
                                          "        p.id_perfil, ",
                                          "        p.nombre perfil ",
                                          "   FROM Usuarios u",
                                          "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                          "  WHERE usuario = @usuario");

            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", nombreUsuario);
            //Usando el método GetDBHelper obtenemos la instancia unica de DBHelper (Patrón Singleton) y ejecutamos el método ConsultaSQL()
            var resultado = DBHelper.getDBHelper().ConsultaSQL2(strSql, parametros);

            // Validamos que el resultado tenga al menos una fila.
            if (resultado.Rows.Count > 0)
            {
                return ObjectMapping(resultado.Rows[0]);
            }

            return null;
        }

        public IList<Usuario> GetByFilters(Dictionary<string, object> parametros)
        {
            List<Usuario> lst = new List<Usuario>();
            String strSql = string.Concat(" SELECT id_usuario, ",
                                              "        usuario, ",
                                              "        email, ",
                                              "        password, ",
                                              "        p.id_perfil, ",
                                              "        p.nombre perfil ",
                                              "   FROM Usuarios u",
                                              "  INNER JOIN Perfiles p ON u.id_perfil= p.id_perfil ",
                                              "  WHERE u.borrado = 0");

            if (parametros.ContainsKey("idPerfil"))
                strSql += " AND (u.id_perfil = @idPerfil) ";


            if (parametros.ContainsKey("usuario"))
                strSql += " AND (u.usuario LIKE '%' + @usuario + '%') ";

            var resultado = DBHelper.getDBHelper().ConsultaSQL2(strSql, parametros);

            foreach (DataRow row in resultado.Rows)
                lst.Add(ObjectMapping(row));

            return lst;
        }

        internal bool Create(Usuario oUsuario)
        {
            string str_sql = "     INSERT INTO Usuarios (usuario, password, email, id_perfil, borrado)" +
                             "     VALUES (@usuario, @password, @email, @id_perfil, 0)";

            var parametros = new Dictionary<string, object>();
            parametros.Add("usuario", oUsuario.NombreUsuario);
            parametros.Add("password", oUsuario.Password);
            parametros.Add("email", oUsuario.Email);


            // Si una fila es afectada por la inserción retorna TRUE. Caso contrario FALSE
            return (DBHelper.getDBHelper().EjecutarSQL2(str_sql, parametros) == 1);
        }

        internal bool Update(Usuario oUsuario)
        {
            throw new NotImplementedException();
        }

        internal bool Delete(Usuario oUsuario)
        {
            throw new NotImplementedException();
        }


        private Usuario ObjectMapping(DataRow row)
        {
            Usuario oUsuario = new Usuario
            {
                IdUsuario = Convert.ToInt32(row["id_usuario"].ToString()),
                NombreUsuario = row["usuario"].ToString(),
                Email = row["email"].ToString(),
                Password = row.Table.Columns.Contains("password") ? row["password"].ToString() : null,
            };

            return oUsuario;
        }
    }
}
