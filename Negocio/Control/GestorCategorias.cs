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

        public IList<Categorias> obtenerConFiltros(Dictionary<string, object> filtro)
        {
            return oCategoriasDAO.ObtenerCategoriasPorFiltro(filtro);
        }

        internal bool crearCategorias(Categorias oCategoria)
        {
            return oCategoriasDAO.crearCategorias(oCategoria);
        }

        public object obtenerCategoria(string categoria)
        {
            return oCategoriasDAO.obtenerCategoria(categoria);
        }

        internal bool actualizarCategorias(Categorias oCategoria)
        {
            return oCategoriasDAO.actualizarCategorias(oCategoria);
        }

        internal bool eliminarCategorias(Categorias oCategoria)
        {
            return oCategoriasDAO.eliminarCategorias(oCategoria);
        }





    }
}
