using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorImpostos.Strategy
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }

        public ICMS()
        {
            this.OutroImposto = null;
        }

        public override double Calcula(Orcamento orcamento)
        {
           
            return orcamento.Valor * 0.1;
        }
    }
}
