using System;
using System.Collections.Generic;
using System.Text;

namespace BusinesLayer
{
    public class Servicios
    {
        public void AgregarOrdenGeneral(Ordenes Objeto)
        {
            Repositorio.Instancia.OrdenesGeneral.Add(Objeto);
        }

        public void AgregarOrdenPorMesas(Ordenes Objeto)
        {
            Repositorio.Instancia.OrdenesPorMesas.Add(Objeto);
        }
    }
}
