using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Producto
    {
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public double ValorVenta { get; set; }

        public override string ToString()
        {
            return string.Format(Codigo + ";" + Nombre + ";" + Descripcion + ";" + ValorVenta);
        }
    }
}