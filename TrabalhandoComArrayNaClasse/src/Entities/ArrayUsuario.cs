namespace TrabalhandoComArrayNaClasse.src.Entities
{
    internal class ArrayUsuario
    {       
        public int[] EntradasUsuario { get; set; }

        public ArrayUsuario()
        {
        }

        public ArrayUsuario(int[] entradasUsuario)
        {
            EntradasUsuario = entradasUsuario;
        }

        public int[]  OrdemCrescente(params int [] x)
        {
            int[] ordem = EntradasUsuario;
            return ordem.OrderBy(x => x).ToArray();

        }

        public int[]  Mediana(params int [] x)
        {
            int[] ordem = OrdemCrescente();
            if ((OrdemCrescente().Length % 2) != 0)
            {                
                Console.WriteLine($"A mediana dos valores: {OrdemCrescente()[(OrdemCrescente().Length / 2)]}");
            }
            else
            {
                Console.WriteLine($"A mediana dos valores: {(OrdemCrescente()[(OrdemCrescente().Length / 2) - 1] + OrdemCrescente()[(OrdemCrescente().Length / 2)]) / 2} ");
            }
            Console.Write("Confira:");
            return ordem;
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
        }

    }
}
