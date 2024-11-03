namespace Modulo13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            //string path = Console.ReadLine();

            string path = @"C:\Users\Pedro\Desktop\Projetos C#\Modulo13-Dictionary-exercicio1\in.txt";

            Dictionary<string, int> candidates = new Dictionary<string, int>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        

                        string[] linha = line.Split(',');
                        //cadidates.Add(linha[0], int.Parse(linha[1]));   

                        if (candidates.ContainsKey(linha[0]))
                        {
                            //Console.WriteLine("Somado");
                            candidates[linha[0]] = int.Parse(linha[1]) + candidates[linha[0]];
                        }
                        else
                        {
                            candidates.Add(linha[0], int.Parse(linha[1]));
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();

            Console.WriteLine("----- Cadidates ------");

            int max = 0;

            foreach (KeyValuePair<string,int> kvp in candidates)
            {
                
                Console.WriteLine(kvp.Key + " " + kvp.Value+ " votos");

                if(kvp.Value > max)
                {
                    max = kvp.Value;
                }
            }

            

        }


    }
}