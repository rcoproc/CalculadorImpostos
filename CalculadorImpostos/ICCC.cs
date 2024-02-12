using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorImpostos
{
    public class ICCC : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            var valorOrcamento = orcamento.Valor;
            double valorImposto = 0.0;
            if (valorOrcamento < 1000.0)
            { 
                valorImposto = (valorOrcamento * 0.05);
            } else if ((valorOrcamento >= 1000) && (valorOrcamento<= 3000.0))
            {
                valorImposto = (valorOrcamento * 0.07);
            }
            else
            {
                valorImposto = ((valorOrcamento * 0.08) + 30.00);
            }
            Console.WriteLine($"Imposto ICCC = {valorImposto}");
            return valorImposto;
        }
    }
}
