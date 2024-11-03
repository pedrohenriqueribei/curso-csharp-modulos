using System.IO;

namespace Modulo11
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Pedro\Desktop\Projetos C#\Mod11-StreamWriter\file1.txt";
            string targetPath = @"C:\Users\Pedro\Desktop\Projetos C#\Mod11-StreamWriter\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
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