/*Criar uma aplicação de console que irá avaliar alguns dados de diversos arrays, reutilizar código para os diversos arrays que serão testados:
Conforme o array de inteiros que for informado, o programa deverá avaliar se o array não está vazio, se estiver imprimir uma mensagem informando, caso tenha números inteiros imprimir no console:

Soma de todos os números
Maior número
Menor número
Média dos valores
Mediana dos valores
*/
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Quantos arrays serão testados?: ");
int n = int.Parse(Console.ReadLine());
int?[] arr = null;

for (int i = 1; i <= n; i++)
{

    Console.WriteLine("Digite os dados separados por espaço");

    string[] dados = Console.ReadLine().Split(' ');
    arr = new int?[dados.Length];

    for (int j = 0; j < arr.Length; j++)
    {
        arr[j] = int.Parse(dados[j]);
    }


    if (arr[i] != null)
    {
        Console.WriteLine($"Segue o seu array: {String.Join(", ", arr)}");
        Console.WriteLine($"A soma de todos os numeros: {arr.Sum()}");
        Console.WriteLine($"O maior número é o: {arr.Max()}");
        Console.WriteLine($"O menor número é o: {arr.Min()}");
        Console.WriteLine($"A média desses números é: {arr.Average()}");

        int?[] ordem = arr.OrderBy(x => x).ToArray();
        Console.WriteLine($"Seus valores em ordem crescente: {String.Join(", ", ordem)}");

        if ((ordem.Length % 2) != 0)
        {
            Console.WriteLine($"A mediana dos valores: {ordem[(ordem.Length / 2)]}");
        }
        else
        {
            Console.WriteLine($"A mediana dos valores: {(ordem[(ordem.Length / 2) - 1] + ordem[(ordem.Length / 2)]) / 2} ");
        }
        Console.WriteLine();
        Console.WriteLine("-------------------------------");
        Console.WriteLine();

    }
    else if (arr[i] == null)
    {
        Console.WriteLine("Seu array está vazio!");
    }







}
