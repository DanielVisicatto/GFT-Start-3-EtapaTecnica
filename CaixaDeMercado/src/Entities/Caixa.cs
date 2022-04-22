/*Utilizando os conceitos de POO implemente o programa abaixo:Crie uma classe chamada “Produto” com os seguintes atributos:
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
• Não é necessário input do usuário, crie os objetos abaixo em código.
*/

using CaixaDeMercado.src.Entities;
using System.Globalization;
using System.Text;

namespace CaixaDeMercado.src.Entities
{
    internal class Caixa
    {
        public Produto Produto { get; set; } = new Produto();
        public int Quantidade { get; protected set; }

        public Caixa()
        {
        }

        public Caixa(Produto produto, int quantidade)
        {
            Produto = produto;
            Quantidade = quantidade;

        }

        public double CalculaValorFinal(Produto produto, int quantidade)
        {
            double valorFinal = produto.Valor * quantidade;
            if (produto.Tipo == 1)
            {
                double desconto = valorFinal * 10 / 100;
                return valorFinal - desconto;
            }

            if (produto.Tipo == 2)
            {
                double desconto = valorFinal * 20 / 100;
                return valorFinal - desconto;
            }
            if (produto.Tipo == 3 && Quantidade > 5)
            {
                double desconto = valorFinal * 10 / 100;
                return valorFinal - desconto;
            }
            return valorFinal;
        }
    }    
}

