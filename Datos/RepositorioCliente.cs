using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioCliente : Archivo
    {
        public RepositorioCliente() : base()
        {
            ruta = "Clientes.txt";
        }
        public List<Cliente> GetAll()
        {
            bool seguir = true;

            List<Entidades.Cliente> ListaClientes = new List<Entidades.Cliente>();
            do
            {
                try
                {
                    StreamReader sr = new StreamReader(ruta);

                    while (!sr.EndOfStream)
                    {
                        ListaClientes.Add(Mapear(sr.ReadLine()));

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
            return ListaClientes;
        }
        Entidades.Cliente Mapear(string lineadatos)
        {
            Cliente cliente = new Cliente();
            cliente.Cedula = int.Parse(lineadatos.Split(';')[0]);
            cliente.Nombre = lineadatos.Split(';')[1];
            cliente.Telefono = lineadatos.Split(';')[2];
            cliente.Direccion = lineadatos.Split(';')[3];
            cliente.Correo = lineadatos.Split(';')[4];
            return cliente;

        }

        public string Actualizar(List<Cliente> clientes, bool modo)
        {
            StreamWriter escritor = new StreamWriter(ruta, modo);
            foreach (var item in clientes)
            {
                escritor.WriteLine(item.ToString());
            }
            escritor.Close();
            return "Proceso Terminado";
        }

    }
}
