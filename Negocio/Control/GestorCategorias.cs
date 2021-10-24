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

    }
}
