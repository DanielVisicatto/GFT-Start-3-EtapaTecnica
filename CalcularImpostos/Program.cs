/*Calcular impostos
Elabore um programa para calcular diferentes impostos:
• Crie uma interface chamada “Imposto” com o método: “calculaImposto(double valor)”
• Crie três classes que implementam a interface Imposto e implemente o método “calculaImposto”, seguindo suas regras.
o ICMS
▪ Incide 30% sobre o valor
o IPI
▪ Incide 5% sobre o valor, desde que seja abaixo de 25000
▪ Incide 10% sobre o valor, se for igual ou maior que 25000
o COFINS
▪ Incide 8% sobre o valor, somente se for maior que 17000
▪ Igual ou abaixo a 17000, não tem incidência
• Crie uma classe com método Main, que receba um valor e retorne ao usuário:
o Quanto cada imposto vai custar
o Qual o valor final com o somatório dos impostos
*/
using CalcularImpostos.src.Models;
using System.Globalization;

ICMS icms = new ICMS();
IPI ipi = new IPI();
COFINS cofins = new COFINS();

Console.Write("Digite um valor:");
double valor = double.Parse(Console.ReadLine());



Console.WriteLine(icms.CalculaImposto(valor).ToString("F2",CultureInfo.InvariantCulture));
Console.WriteLine(ipi.CalculaImposto(valor).ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine(cofins.CalculaImposto(valor).ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine($"Valor Final: {valor + icms.CalculaImposto(valor) + ipi.CalculaImposto(valor) + ipi.CalculaImposto(valor)}");