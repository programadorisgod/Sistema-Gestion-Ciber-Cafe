using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Datos
{
    public class Archivo
    {
        protected string ruta;
        public Archivo()
        {
            ruta = "GuardarInformacion.txt";
        }
        public Archivo(string filename)
        {
            ruta = filename;
        }
       
        public string CrearArchivo()
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.Close();
            return "";
        }
        public string Guardar(Persona persona)
        {
            try
            {
                StreamWriter writer = new StreamWriter(ruta, true);
                writer.WriteLine(persona.ToString());   
                writer.Close();
                return $"Informacion almacenada correctamente...{persona.Nombre}";
            }
            catch (Exception)
            {

                return "No se guardaron los datos correctamente";
            }
        }
    }
}
