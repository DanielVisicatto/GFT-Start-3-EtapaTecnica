using CalcularImpostos.src.Interface;
using CalcularImpostos.src.Models;

namespace CalcularImpostos.src.Models
{
    internal class ICMS : IImposto
    {
        public double TaxaICMS { get; set; }

        public ICMS()
        {
        }

        public ICMS(double taxaICMS)
        {
            TaxaICMS = taxaICMS;
        }
                
        public double CalculaImposto(double valor)
        {
            TaxaICMS = valor * 30 / 100;
            return TaxaICMS;
        }
        public override string ToString()
        {
            return $"ICMS: {CalculaImposto}";
        }
    }
}
