using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Logica
{
    public class ServicioCliente : IserviceCliente<Cliente>
    {
        
        List<Cliente> clienteList;
        RepositorioCliente repositorioCliente = new RepositorioCliente();
        public ServicioCliente()
        {
            clienteList = new List<Cliente>();
            clienteList = repositorioCliente.GetAll();
           
        }
        public string Delete(int indice)
        {
            try
            {
                clienteList.RemoveAt(indice);
                repositorioCliente.Actualizar(clienteList, false);
                return "El cliente fue eliminado correctamente";

            }
            catch (Exception)
            {

                return "El cliente no fue eliminado correctamente";
            }
        }


        public string Edit(Cliente Cliente_new)
        {
            Cliente cliente_actual = GetByAll(Cliente_new);
            try
            {
                if (cliente_actual == null)
                {
                    return "Contacto no existe";
                }
                else
                {
                    cliente_actual.Cedula = Cliente_new.Cedula;
                    cliente_actual.Nombre = Cliente_new.Nombre;
                    cliente_actual.Telefono = Cliente_new.Telefono;
                    cliente_actual.Direccion = Cliente_new.Direccion;
                    cliente_actual.Correo = Cliente_new.Correo;
                    return repositorioCliente.Actualizar(clienteList, false);

                }
            }
            catch (Exception)
            {
                return "Cliente no editado";
            }
            
        }

        public bool Exists(Cliente Cliente)
        {
            foreach (var item in clienteList)
            {
                if (item.Cedula.Equals(Cliente.Cedula))
                {
                    return true;
                }

            }
            return false;
        }

        public List<Cliente> GetAll()
        {
            return repositorioCliente.GetAll();
        }

        public string Guardar(Cliente Cliente)
        {
            string Guardado = string.Empty;
            try
            {
                if (GetByAll(Cliente) == null)
                {
                    Guardado = repositorioCliente.Guardar(Cliente);
                    return Guardado;
                }
                else
                {
                    return "Ya existe un cliente con esa cedula";
                }

            }
            catch (Exception)
            {
                return "Se ha prodciono un error, el contacto no fue guardado";

            }
        }
       

        public Cliente GetByAll(Cliente cliente)
        {
            foreach (Cliente item in clienteList)
            {
                if (item.Cedula == cliente.Cedula || item.Nombre == cliente.Nombre 
                    || item.Telefono == cliente.Telefono || item.Correo == cliente.Correo)
                {
                    return item;
                }
            }
            return null;
        }
    }
}