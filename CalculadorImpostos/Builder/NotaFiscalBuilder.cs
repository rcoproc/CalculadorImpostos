using CalculadorImpostos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class NotaFiscalBuilder
    {
        private String RazaoSocial;
        private String Cnpj;
        private double ValorTotal;
        private double Impostos;
        private DateTime Data;
        private IList<ItemDaNota> todosItens = new List<ItemDaNota>();
        private String Observacoes;

        public NotaFiscalBuilder()
        {
            this.Data = DateTime.Now;
        }

        public NotaFiscalBuilder ParaEmpresa(String razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }

        public NotaFiscalBuilder ComCnpj(String cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }

        public NotaFiscalBuilder ComItem(ItemDaNota item)
        {
            todosItens.Add(item);
            ValorTotal += item.Valor;
            Impostos += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder NaData(DateTime novaData)
        { 
      
            this.Data = novaData;
            return this;
        }

        public NotaFiscalBuilder ComObservacoes(String observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }

        public NotaFiscal constroi()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, Data, ValorTotal, Impostos, todosItens, Observacoes);
        }
    }

    public class ItemDaNotaBuilder
    {
        public string Produto { get; private set; }
        public double Valor { get; private set; }
        public ItemDaNotaBuilder ComProduto(string produto)
        {
            Produto = produto;
            return this;
        }
        public ItemDaNotaBuilder ComValor(double valor)
        {
            Valor = valor;
            return this;
        }

        public ItemDaNota Constroi()

        {
            return new ItemDaNota(this.Produto, this.Valor);    
        }
    }

    public class ItemDaNota
    {
        public string Produto { get; private set; }
        public double Valor { get; private set; }
        public ItemDaNota(string produto, double valor)
        {
            this.Produto = produto;
            this.Valor = valor;
            
        }
    }
}
