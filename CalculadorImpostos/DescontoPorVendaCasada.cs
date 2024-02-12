using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorImpostos
{
    internal class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconta(Orcamento orcamento)
        {
            if (aconteceuVendaCasada(orcamento))
                return orcamento.Valor * 0.05;
            else
                return Proximo.Desconta(orcamento);

        }

        private bool aconteceuVendaCasada(Orcamento orcamento)
        {
            return existe("LAPIS", orcamento) && existe("CANETA", orcamento);
        }

        private bool existe(String nomeDoItem, Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeDoItem))
                    return true;
            }
            return false;
        }
    }
}
