using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorImpostos.TemplateMethod
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        protected TemplateDeImpostoCondicional()
        {
            this.OutroImposto = null; 
        }
        protected TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }

        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxacao(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            else
            {
                return MinimaTaxacao(orcamento);
            }
        }
        // e os três métodos necessários       
        protected abstract bool DeveUsarMaximaTaxacao(Orcamento orcamento);
        protected abstract double MaximaTaxacao(Orcamento orcamento);
        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}
