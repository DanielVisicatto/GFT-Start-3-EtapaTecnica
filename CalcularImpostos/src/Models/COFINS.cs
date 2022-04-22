using CalcularImpostos.src.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularImpostos.src.Models
{
    internal class COFINS : IImposto
    {
        public double TaxaCofins { get; set; }

        public COFINS()
        {
        }

        public COFINS(double taxaCofins)
        {
            TaxaCofins = taxaCofins;
        }

        public double CalculaImposto(double valor)
        {
            
            if(valor <= 17000)
            {
                return TaxaCofins = 0;
            }
            else
            {
                return TaxaCofins = valor * 0.08;
            }
        }

        public override string ToString()
        {
            return $"COFINS: {CalculaImposto}";
        }
    }
}
