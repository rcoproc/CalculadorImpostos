// See https://aka.ms/new-console-template for more information
using CalculadorImpostos;
using DesignPatterns.State;

Orcamento reforma = new Orcamento(500);

Console.WriteLine(reforma.EstadoAtual);
Console.WriteLine(reforma.Valor);

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);

reforma.Aprova();
reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.EstadoAtual);

reforma.AplicaDescontoExtra();
Console.WriteLine(reforma.Valor);

reforma.Finaliza();
Console.WriteLine(reforma.EstadoAtual);
//reforma.AplicaDescontoExtra();


Console.ReadKey();
