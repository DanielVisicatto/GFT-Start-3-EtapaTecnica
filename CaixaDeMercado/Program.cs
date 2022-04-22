/* Utilizando os conceitos de POO implemente o programa abaixo:Crie uma classe chamada “Produto” com os seguintes atributos:
• Nome (Tipo string)
• Valor (Tipo double)
• Tipo (Tipo inteiro, que pode ser 1,2 ou 3)
Crie uma classe chamada “Caixa” com um método chamado: “calculaValorFinal”, que retorna um tipo double e recebe os seguintes parâmetros Produto e Quantidade, nesse método, multiplique o Valor contido no objeto Produto pela Quantidade.
Se o produto for:
• Tipo 1: Aplique 10% de desconto no valor final
• Tipo 2: Aplique 20% de desconto no valor final
• Tipo 3: Aplique 10% de desconto no valor final, se a quantidade for maior que 5.
Crie uma classe com método Main, instancie os objetos “Produto” conforme a tabela abaixo e imprima nome e valor total de cada produto.
Atenção:
• A Quantidade só deve ser passada no método “calculaValorFinal” da classe Caixa.
• Somente UM objeto Caixa deverá ser instanciado.
• Não é necessário input do usuário, crie os objetos abaixo em código.*/

using CaixaDeMercado.src.Entities;
using System.Globalization;


Produto banana = new ( "Banana", 0.99, 2 );
Produto energetico = new ( "Energético", 5.49, 3 );
Produto arroz = new ( "Arroz", 20.00, 1 );
Produto chocolate = new ( "Chocolate", 4.50, 1 );
Produto leite = new ( "Leite", 3.73, 3 );
Produto abacaxi = new ( "Abacaxi", 2.40, 2 );

Caixa caixa = new ();

Console.WriteLine("------------------------------");
Console.WriteLine($"banana: {caixa.CalculaValorFinal(banana, 3).ToString("F2",CultureInfo.InvariantCulture)}");
Console.WriteLine($"energético: {caixa.CalculaValorFinal(energetico, 7).ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"arroz: {caixa.CalculaValorFinal(arroz, 1).ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"chocolate: {caixa.CalculaValorFinal(chocolate, 12).ToString("F2", CultureInfo.InvariantCulture)}") ;
Console.WriteLine($"leite: {caixa.CalculaValorFinal(leite, 5).ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine($"abacaxi: {caixa.CalculaValorFinal(abacaxi, 2).ToString("F2", CultureInfo.InvariantCulture)}");
Console.WriteLine();
Console.WriteLine("-------------------------------");
