// See https://aka.ms/new-console-template for more information
using DesignPatterns.Builder;
using DesignPatterns.Observer;

IList<AcoesAposGerarNota> acoesAposGerarNotas = new List<AcoesAposGerarNota>()
{
    new EnviadorDeEmail(),
    new EnviadorSms(),
    new GravadorNotaFiscalDao(),
    new Multiplicador(3)
};

NotaFiscalBuilder criador = new NotaFiscalBuilder(acoesAposGerarNotas)
    .ParaEmpresa("Caelum")
    .ComCnpj("123.456.789/0001-10")
    .NaData(new DateTime(2024, 02, 13))
    .ComItem(new ItemDaNotaBuilder().ComProduto("item 1").ComValor(100.0).Constroi())
    .ComItem(new ItemDaNotaBuilder().ComProduto("item 2").ComValor(200.0).Constroi())
    .ComItem(new ItemDaNotaBuilder().ComProduto("item 3").ComValor(300.0).Constroi());

//criador.AdicionarAcao(new EnviadorDeEmail());
//criador.AdicionarAcao(new EnviadorSms());
//criador.AdicionarAcao(new GravadorNotaFiscalDao());
//criador.AdicionarAcao(new Multiplicador(3));

NotaFiscal notaFiscal = criador.constroi();

Console.WriteLine($"NOTA FISCAL ---- [{notaFiscal.DataDeEmissao}]");
Console.WriteLine($"Razão Social {notaFiscal.RazaoSocial}");
Console.WriteLine($"CNPJ {notaFiscal.Cnpj}");
Console.WriteLine($"Total de Itens {notaFiscal.Itens.Count}");
Console.WriteLine($"Total {notaFiscal.ValorBruto}");
Console.WriteLine($"Impostos {notaFiscal.Impostos}");
