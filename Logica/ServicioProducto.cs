using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Datos;

namespace Logica
{
    public class ServicioProducto
    {
        List<Producto> ListaProductos;
        RepositorioProducto repositorioProducto = new RepositorioProducto();
        public ServicioProducto()
        {
            ListaProductos = repositorioProducto.GetAll();
        }
        public List<Producto> GetAll()
        {
            return ListaProductos = repositorioProducto.GetAll();
        }
        public string Guardar(Producto producto)
        {
            string Guardado = string.Empty;
            try
            {
                if (GetByCode(producto) == null)
                {
                    Guardado = repositorioProducto.Guardar(producto);
                    return Guardado;
                }
                else
                {
                    return "Ya existe un producto con este codigo";
                }

            }
            catch (Exception)
            {
                return "Se ha prodciono un error, el producto no fue guardado";

            }
        }
        public Producto GetByCode(Producto producto)
        {
            ListaProductos = GetAll();
            foreach (Producto item in ListaProductos)
            {
                if (item.Codigo == producto.Codigo)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
