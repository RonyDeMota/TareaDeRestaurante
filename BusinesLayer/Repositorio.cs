using System;
using System.Collections.Generic;
using System.Text;

namespace BusinesLayer
{
    public sealed class Repositorio
    {
        public List<Ordenes> OrdenesGeneral { get; set; } = new List<Ordenes>();
        public List<Ordenes> OrdenesPorMesas { get; set; } = new List<Ordenes>();
        public int estado { get; set; } = 0;

        public static Repositorio Instancia { get; } = new Repositorio();

        private Repositorio()
        {

        }
    }
}
