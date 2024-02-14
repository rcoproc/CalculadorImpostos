using CalculadorImpostos;
using DesignPatterns.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    public class Finalizado : EstadoDeUmOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamentos finalizados não recebem desconto extra!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçcamento já está finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçcamento já está finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçcamento já está finalizado");
        }
    }
}
