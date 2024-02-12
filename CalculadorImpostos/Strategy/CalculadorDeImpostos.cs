using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorImpostos.Strategy
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            double valorImposto = imposto.Calcula(orcamento);
            Console.WriteLine(valorImposto);
        }
    }
}
