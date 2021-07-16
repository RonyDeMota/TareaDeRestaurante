using System;
using System.Collections.Generic;
using System.Text;

namespace BusinesLayer
{
    public class Ordenes
    {

        public string NombreCliente { get; set; }
        public string PlatilloDeEntrada { get; set; }
        public string PlatoFuerte { get; set; }
        public string Postre { get; set; }
        public string Bebida { get; set; }


        public Ordenes(string NombreCliente, string PlatilloDeEntrada, string PlatoFuerte, string Postre, string Bebida)
        {

            this.NombreCliente = NombreCliente;
            this.PlatilloDeEntrada = PlatilloDeEntrada;
            this.PlatoFuerte = PlatoFuerte;
            this.Postre = Postre;
            this.Bebida = Bebida;

        }
    }
}
