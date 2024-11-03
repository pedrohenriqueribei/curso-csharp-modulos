namespace Modulo6
{
    using System.Globalization;
    class Program
    {
        static void Main(string[] args)
        {
            //REFERENCIA
            Point p;
            p.X = 10;
            p.Y = 20;

            //Console.WriteLine(p);

            //NULLABLE
            double? x = null;

            double y = x ?? 1000;

            //    Console.WriteLine("Y = "+y);

            //    //VETORES
            //    Console.WriteLine("Informe a quantidade ");
            //    int n = int.Parse(Console.ReadLine());

            //    double[] vetor = new double[n];

            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine("Informe a altura");
            //        vetor[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    }

            //    double media = 0.0;


            //    for (int i = 0; i < n; i++)
            //    {
            //        media += vetor[i];
            //    }

            //    media = media / n;

            //    Console.WriteLine("Media = "+ media.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Informe a quantidade de produtos");
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];

            double media = 0;
            int indice = 1;

            for (int i = 0; i < n; i++)
            {
                
                produtos[i] = new Produto();

                Console.WriteLine("Informe o nome do Produto "+ indice+": ");
                produtos[i].Nome = Console.ReadLine();

                Console.WriteLine("Informe o preço do Produto " + indice + ": ");
                produtos[i].Preco = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture);
                
                media += produtos[i].Preco;
                indice++;
            }

            media /= n;
            Console.WriteLine("MEDIA = "+ media.ToString("F2", CultureInfo.InvariantCulture));
        }

    }

}