﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadorImpostos.Strategy
{
    public class ISS : Imposto
    {
        public ISS(Imposto outroImposto) : base(outroImposto) { }

        public ISS()
        {
            this.OutroImposto = null;
        }

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }


    }
}
