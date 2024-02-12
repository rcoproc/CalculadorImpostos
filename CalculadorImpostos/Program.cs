// See https://aka.ms/new-console-template for more information
using CalculadorImpostos;

//Console.WriteLine("Calculador de Imposto");


//var ICMS = new ICMS();
//var ISS = new ISS();
//var ICCC = new ICCC();

//var orcamento = new Orcamento(3001.0);
//CalculadorDeImpostos calculador = new CalculadorDeImpostos();

//// Calculando o ISS
//calculador.RealizaCalculo(orcamento, ISS);

//// Calculando o ICMS
//calculador.RealizaCalculo(orcamento, ICMS);

//// Calculando o ICCC;
//calculador.RealizaCalculo(orcamento, ICCC);


Console.WriteLine("Calculador de Descontos");

CalculadorDeDescontos calculador = new CalculadorDeDescontos();

Orcamento orcamento = new Orcamento(270.0);
orcamento.AdicionaItem(new Item("CANETA", 20.0));
orcamento.AdicionaItem(new Item("LAPIS", 250.0));
//orcamento.AdicionaItem(new Item("APAGADOR", 50.0));
//orcamento.AdicionaItem(new Item("CADERNO", 250.0));
//orcamento.AdicionaItem(new Item("MOCHILA", 750.0));
//orcamento.AdicionaItem(new Item("ESTOJO", 250.0));

double desconto = calculador.Calcula(orcamento);

Console.WriteLine(desconto);

Console.ReadLine();
