using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {

        public string Correo { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return string.Format(Cedula + ";" + Nombre + ";" + Telefono + ";" + Direccion + ";" + Correo + ";");
        }
    }
}