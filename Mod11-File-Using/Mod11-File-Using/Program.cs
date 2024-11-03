namespace Modulo11
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Pedro\Desktop\Projetos C#\Mod11-File\file1.txt";

            try
            {
                
                //usando using nao precisa fechar o stream
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.Message);
            }
        }
    }
}