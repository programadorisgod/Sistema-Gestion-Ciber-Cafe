using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Cliente : Persona
    {
       public String Correo
        {
            get => default;
            set
            {
            }
        }

        public String Direccion
        {
            get => default;
            set
            {
            }
        }
        public override string ToString()
        {
            return string.Format(Cedula+";"+Nombre+";"+Telefono+";"+Direccion+";"+Correo+";");
        }
    }
}