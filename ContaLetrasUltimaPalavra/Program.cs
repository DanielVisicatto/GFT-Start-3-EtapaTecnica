/*Construa uma função que receba uma string e retorne o contagem de caracteres da última palavra. Preparar o retorno com as strings abaixo:
• "Na minha máquina funciona"
• "Eu posso pular o teste"
• "Isso não deve demorar"
Exemplo
Entrada -> "Acabou o café"
Saída -> 4
*/

String fraseExemplo = "Acabou o café";
String primeiraFrase = "Na minha máquina funciona";
String segundaFrase = "Eu posso pular o teste";
String terceiraFsrase = "Isso não deve demorar";


static string contaCharUltimaPalavra(string str)
{
    return str.Substring (str.LastIndexOf(" ") + 1);
}
Console.WriteLine($"A ultima palavra da frase exemplo tem: {contaCharUltimaPalavra(fraseExemplo).Length} letras");
Console.WriteLine($"A ultima palavra primeira frase tem: {contaCharUltimaPalavra(primeiraFrase).Length} letras");
Console.WriteLine($"A ultima palavra da segunda frase tem: {contaCharUltimaPalavra(segundaFrase).Length} letras");
Console.WriteLine($"A ultima palavra da terceira frase tem: {contaCharUltimaPalavra(terceiraFsrase).Length} letras");