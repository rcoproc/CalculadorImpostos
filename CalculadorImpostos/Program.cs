﻿// See https://aka.ms/new-console-template for more information
using CalculadorImpostos;
using CalculadorImpostos.Strategy;

Imposto impostoSimples = new ISS();
Imposto impostoComplexo = new ISS(new ICMS());
Imposto impostoComplexo2 = new ICMS(new ICCC(new ISS()));
Imposto impostoMuitoAlto = new ImpostoMuitoAlto(new ICMS());


Orcamento orcamento = new Orcamento(1000.0);


double valorSimples = impostoSimples.Calcula(orcamento);

double valor = impostoComplexo.Calcula(orcamento);

double valor2 = impostoComplexo2.Calcula(orcamento);

double valorAlto = impostoMuitoAlto.Calcula(orcamento);

Console.WriteLine($"Imposto  Simples: {valorSimples}");
Console.WriteLine($"Imposto  Complexo: {valor}");
Console.WriteLine($"Imposto2 Complexo: {valor2}");
Console.WriteLine($"Imposto2 Muito Alto: {valorAlto}");
Console.ReadKey();

