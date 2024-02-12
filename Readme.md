# Design Patterns

## Strategy

## Chain of Responsability 

## Template Method


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

O padrão Strategy é muito útil quando temos um conjunto de algoritmos similares, e precisamos alternar entre eles em diferentes pedaços da aplicação. No exemplo do vídeo, temos diferentes maneira de calcular o imposto, e precisamos alternar entre elas.

O Strategy nos oferece uma maneira flexível para escrever diversos algoritmos diferentes, e de passar esses algoritmos para classes clientes que precisam deles. Esses clientes desconhecem qual é o algoritmo "real" que está sendo executado, e apenas manda o algoritmo rodar. Isso faz com que o código da classe cliente fique bastante desacoplado das implementações concretas de algoritmos, possibilitando assim com que esse cliente consiga trabalhar com N diferentes algoritmos sem precisar alterar o seu código.

CalculadorDeImpostos
___

### Impostos

1. Icms

2. Iss

3. ICCC



### Classes de Chain Of Responsability
___

O padrão Chain of Responsibility cai como uma luva quando temos uma lista de comandos a serem executados de acordo com algum cenário em específico, e sabemos também qual o próximo cenário que deve ser validado, caso o anterior não satisfaça a condição.

Nesses casos, o Chain of Responsibility nos possibilita a separação de responsabilidades em classes pequenas e enxutas, e ainda provê uma maneira flexível e desacoplada de juntar esses comportamentos novamente.

CalculadorDeDescontos

#### Descontos

1. DescontoPorCincoItens

2. DescontoPorMaisDeQuinhentosReais

3. DescontoPorVendaCasada

4. SemDescontos


### Classes de TemplateMethod

Quando temos diferentes algoritmos que possuem estruturas parecidas, o Template Method é uma boa solução. Com ele, conseguimos definir, em um nível mais macro, a estrutura do algoritmo e deixar "buracos", que serão implementados de maneira diferente por cada uma das implementações específicas.

Dessa forma, reutilizamos ao invés de repetirmos código, e facilitamos possíveis evoluções, tanto do algoritmo em sua estrutura macro, quanto dos detalhes do algoritmo, já que cada classe tem sua responsabilidade bem separada.

---

TemplateDeIpostoCondicional

Pasta /Relatorio

#### Impostos

1. ICPP

2. IHIT

3. IKCV


