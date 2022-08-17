using System;

namespace InserirValoresArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[2];
            int i = 0;
            Array[0] = Inserir();
            Array[1] = Inserir();
            Console.WriteLine("\n\nResultado: {0}{1}\n\n", Array[0], Array[1]);
        }

        static int Inserir()
        {
            Console.WriteLine("Digite um valor inteiro: ");
            int n = int.Parse(Console.ReadLine());
            return n;
        }
    }
}
