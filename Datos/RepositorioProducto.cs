using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Datos
{
    public class RepositorioProducto : Archivo
    {
        public RepositorioProducto() : base()
        {
            ruta = "Productos.txt";
        }
        public string Guardar(Producto producto)
        {
            try
            {
                StreamWriter writer = new StreamWriter(ruta, true);
                writer.WriteLine(producto.ToString());
                writer.Close();
                return $"Informacion almacenada correctamente...{producto.Nombre}";
            }
            catch (Exception)
            {

                return "No se guardaron los datos correctamente";
            }
        }
        public List<Producto> GetAll()
        {
            bool seguir = true;

            List<Entidades.Producto> ListaProductos = new List<Entidades.Producto>();
            do
            {
                try
                {
                    StreamReader sr = new StreamReader(ruta);

                    while (!sr.EndOfStream)
                    {
                        ListaProductos.Add(Mapear(sr.ReadLine()));

                    }
                    sr.Close();
                    seguir = true;
                }
                catch (Exception)
                {
                    CrearArchivo();
                    seguir = false;
                }

            } while (seguir == false);
            return ListaProductos;
        }
        Entidades.Producto Mapear(string lineadatos)
        {
            Producto producto = new Producto();
            producto.Codigo = lineadatos.Split(';')[0];
            producto.Nombre = lineadatos.Split(';')[1];
            producto.Descripcion = lineadatos.Split(';')[2];
            producto.ValorVenta = double.Parse(lineadatos.Split(';')[3]);
            return producto;

        }

        public string Actualizar(List<Producto> productos, bool modo)
        {
            StreamWriter escritor = new StreamWriter(ruta, modo);
            foreach (var item in productos)
            {
                escritor.WriteLine(item.ToString());
            }
            escritor.Close();
            return "Proceso Terminado";
        }
    }
}
