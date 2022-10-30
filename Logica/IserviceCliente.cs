using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica
{
    public interface IserviceCliente<T>
    {
        string Guardar(T Cliente);
        string Delete(int Indice);
        string Edit(T Cedula);
        List<T> GetAll();
        bool Exists(T Cliente);
        T GetByAll(T Cliente);
    }
}