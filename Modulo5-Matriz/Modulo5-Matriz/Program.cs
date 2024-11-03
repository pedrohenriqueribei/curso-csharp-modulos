using System;

namespace Modulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mat = new double[2, 3];

            Console.WriteLine("Numero de posicoes: "+ mat.Length);
            Console.WriteLine("Numero de linhas: " + mat.Rank);
            Console.WriteLine("Numero de posicoes: " + mat.GetLength(0));
        }
    }
}
