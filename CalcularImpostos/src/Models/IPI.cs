using CalcularImpostos.src.Interface;
namespace CalcularImpostos.src.Models
{
    internal class IPI : IImposto
    {
        public double TaxaIPI { get; set; }

        public IPI()
        {
        }

        public IPI(double taxaIPI)
        {
            TaxaIPI = taxaIPI;
        }

        public double CalculaImposto(double valor)
        {
            if (valor < 25000)
            {
                return valor * 0.05;
            }
            else
            {
                return valor * 0.10;
            }
        }

        public override string ToString()
        {
            return $"IPI: {CalculaImposto}";
        }
    }
}

