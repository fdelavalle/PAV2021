using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PAVI.Clases;
using TP_PAVI.Datos.Dao;
namespace TP_PAVI.Negocio.Control
{
    public class GestorCategorias
    {
        private CategoriasDAO oCategoriasDAO;
        public GestorCategorias()
        {
            oCategoriasDAO = new CategoriasDAO();
        }
        public IList<Categorias> ObtenerTodos()
        {
            return oCategoriasDAO.FindAll();
        }

        public IList<Categorias> ConsultarCategoriasConFiltro(Dictionary<string, object> parametros)
        {
            return oCategoriasDAO.ObtenerCategoriasPorFiltro(parametros);
        }
        internal object ObtenerCategoria(string categoria)
        {
            return oCategoriasDAO.GetCategoria(categoria);
        }

        internal bool CrearCategoria(Categorias oCategoria)
        {
            return oCategoriasDAO.Create(oCategoria);
        }

        internal bool EliminarCategoria(Categorias oCategoriaSelected)
        {
            return oCategoriasDAO.Delete(oCategoriaSelected);
        }


        internal bool ActualizarCategoria(Categorias oCategoriaSelected)
        {
            return oCategoriasDAO.Update(oCategoriaSelected);
        }

    }
}
