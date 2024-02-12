# Design Patterns

## Strategy

## Chain of Responsability 

## Template Method

## Decorator


## Projeto: CalculadorImpostos

### Linguagem: csharp dotnet 6.0

### Autor: Ricardo Oliveira

### Data Inicial: Fevereiro/2024


Para rodar esse projeto : 

`dotnet build`

`dotnet run`

Arquivo de Startup

**Program.cs**


### Classes de Strategy

CalculadorDeImpostos
___

### Impostos

1. Icms

2. Iss

3. ICCC



### Classes de Chain Of Responsability
___

CalculadorDeDescontos

#### Descontos

1. DescontoPorCincoItens

2. DescontoPorMaisDeQuinhentosReais

3. DescontoPorVendaCasada

4. SemDescontos


### Classes de TemplateMethod

---

TemplateDeIpostoCondicional

Pasta /Relatorio

#### Impostos

1. ICPP

2. IHIT

3. IKCV


### Classes de Decorator

Sempre que percebemos que temos comportamentos que podem ser compostos por comportamentos de outras classes envolvidas em uma mesma hierarquia, como foi o caso dos impostos, que podem ser composto por outros impostos. O Decorator introduz a flexibilidade na composição desses comportamentos, bastando escolher no momento da instanciação, quais instancias serão utilizadas para realizar o trabalho.

**Program.cs**

#### Impostos

1. ISS


2. ICMS
3. ICPP
