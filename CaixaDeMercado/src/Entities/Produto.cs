using System;
using CaixaDeMercado.src.Entities;


namespace CaixaDeMercado.src.Entities
{
    internal class Produto 
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public int Tipo { get; set; }
        

        public Produto()
        {
        }

        public Produto(string nome, double valor, int tipo)
        {
            Nome = nome;
            Valor = valor;
            Tipo = tipo;
            
        }
        
    }
}
