/*Criar uma aplicação de console que irá avaliar alguns dados de diversos arrays, reutilizar código para os diversos arrays que serão testados:
Conforme o array de inteiros que for informado, o programa deverá avaliar se o array não está vazio, se estiver imprimir uma mensagem informando, caso tenha números inteiros imprimir no console:
Soma de todos os números
Maior número
Menor número
Média dos valores
Mediana dos valores
*/

using TrabalhandoComArrayNaClasse.src.Entities;

Console.WriteLine("Quantos arrays serão testados?: ");
int n = int.Parse(Console.ReadLine());
ArrayUsuario array = new ArrayUsuario();

for (int i = 1; i <= n; i++)
{
    string[] dados;
    Console.WriteLine($"Array #{i}:");
    Console.WriteLine("Digite os dados separando por espaço");
    dados = Console.ReadLine().Split(' ');
    int[] entradasUsuario = new int[dados.Length];
    for (int j = 0; j < dados.Length; j++)
    {
        entradasUsuario[j] = int.Parse(dados[j]);
    }
    array.EntradasUsuario = entradasUsuario;

    if (entradasUsuario.FirstOrDefault() > 0)
    {

        Console.WriteLine();
        Console.WriteLine("-------------------------------");
        Console.WriteLine($"Seu array:{String.Join(", ", array.EntradasUsuario)} ");
        Console.WriteLine($"A soma de todos os numeros: {array.EntradasUsuario.Sum()}");
        Console.WriteLine($"O maior número é o: {array.EntradasUsuario.Max()}");
        Console.WriteLine($"O menor número é o: {array.EntradasUsuario.Min()}");
        Console.WriteLine($"A média desses números é: {array.EntradasUsuario.Average()}");
        Console.WriteLine($"Seus valores em ordem crescente: {String.Join(", ", array.OrdemCrescente())}");
        Console.WriteLine(String.Join(", ", array.Mediana()));
        Console.WriteLine("-------------------------------");
        Console.WriteLine();
    }
    else
    {
        Console.WriteLine("Seu Array está vazio!!!");
    }

}
Console.WriteLine("Finalizando aplicação...");
Console.WriteLine("Obrigado!");