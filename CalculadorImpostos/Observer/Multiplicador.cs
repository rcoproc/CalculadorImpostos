using DesignPatterns.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Observer
{
    public class Multiplicador : AcoesAposGerarNota
    {
        public double Fator { get; private set; }

        public Multiplicador(double fator)
        {
            this.Fator = fator;
        }

        public void Executa(NotaFiscal notaFiscal)
        {
            double valorNotaMultiplicado = notaFiscal.ValorBruto * this.Fator;
            Console.WriteLine($"Total da Nota Fiscal = ${notaFiscal.ValorBruto} multiplicado por {this.Fator} = {valorNotaMultiplicado}");
        }
    }
}
