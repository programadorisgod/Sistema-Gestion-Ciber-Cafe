using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioUsuario:Archivo
    {
        public RepositorioUsuario():base()
        {
            ruta = "Usuarios.txt";
        }
        public List<Usuario> GetAll()
        {
            bool seguir = true;

            List<Entidades.Usuario> ListaUsuarios = new List<Entidades.Usuario>();
            do
            {
                try
                {
                    StreamReader sr = new StreamReader(ruta);

                    while (!sr.EndOfStream)
                    {
                        ListaUsuarios.Add(Mapear(sr.ReadLine()));

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

            return ListaUsuarios;
        }
        Entidades.Usuario Mapear(string linea)
        {
            var usuario = new Entidades.Usuario();
            usuario.Username = linea.Split(';')[0];
            usuario.Password = linea.Split(';')[1];
            return usuario;
        }
       
        }
}
