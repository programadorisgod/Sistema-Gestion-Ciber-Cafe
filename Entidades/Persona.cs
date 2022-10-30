using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        public int Cedula { get; set; }

        public string Nombre { get; set; }

        public  string Telefono { get; set; }

        public Persona(int Cedula, string Nombre, string Telefono)
        {
            this.Cedula = Cedula;
            this.Nombre = Nombre;
            this.Telefono = Telefono;
        }
        public Persona()
        {

        }
    }
}