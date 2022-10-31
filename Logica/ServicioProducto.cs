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
                if (GetByCode(producto, -1) == null)
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
        public string Delete(int row)
        {
            try
            {
                ListaProductos.RemoveAt(row);
                repositorioProducto.Actualizar(ListaProductos, false);
                return "El producto fue eliminado correctamente";

            }
            catch (Exception)
            {

                return "El producto no fue eliminado correctamente";
            }
        }
        public string Edit(Producto productonuevo, int row)
        {
            Producto productoviejo = GetByCode(productonuevo, row);
            try
            {
                if (productoviejo != null)
                {
                    return "Ya existe un producto con este codigo";
                }
                else
                {
                    ListaProductos[row] = productonuevo;
                    return repositorioProducto.Actualizar(ListaProductos, false);

                }
            }
            catch (Exception)
            {
                return "Producto no editado";
            }

        }
        public Producto GetByCode(Producto producto, int row)
        {
            ListaProductos = GetAll();
            if (row == -1)
            {
                foreach (Producto item in ListaProductos)
                {
                    if (item.Codigo == producto.Codigo)
                    {
                        return item;
                    }
                }
            }
            else
            {
                for (int i = 0; i < ListaProductos.Count; i++)
                {
                    if (ListaProductos[i].Codigo == producto.Codigo && i != row)
                    {
                        return ListaProductos[i];
                    }
                }
            }
            
            return null;
        }
    }
}
