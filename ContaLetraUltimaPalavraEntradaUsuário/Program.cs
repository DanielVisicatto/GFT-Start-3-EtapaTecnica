// See https://aka.ms/new-console-template for more information
/*Contar letras da última palavra
Construa uma função que receba uma string e retorne o contagem de caracteres da última palavra. Preparar o retorno com
as strings abaixo:
• "Na minha máquina funciona"
• "Eu posso pular o teste"
• "Isso não deve demorar"
Exemplo
Entrada -> "Acabou o café"
Saída -> 4                  */

string str = Console.ReadLine(); // recebe frase.

static string ContaLetrasDaUltimaPalavra(string str) //método contar letras
{
    return str.Substring(str.LastIndexOf(" ") +1); // divide a string nos espaços e pega o ultimo espaço + 1
}
Console.WriteLine(ContaLetrasDaUltimaPalavra(str).Length); // imprime o que esta depois desse ultimo espaço ou seu tamanho
