using System;
using System.Collections.Generic;
using System.Text;

namespace BusinesLayer
{
    public class Servicio
    {
        public void AgregarOrdenGeneral(Orden Objeto)
        {
            Repositorio.Instancia.OrdenesGeneral.Add(Objeto);
        }

        public void AgregarOrdenPorMesas(Orden Objeto)
        {
            Repositorio.Instancia.OrdenesPorMesas.Add(Objeto);
        }
    }
}
