using System.IO;

namespace Modulo11
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\Pedro\Desktop\Projetos C#\Mod11-File\file1.txt";

            string targetPath = @"C:\Users\Pedro\Desktop\Projetos C#\Mod11-File\file2.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                //fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);

                foreach (string line in lines)
                {
                    //Console.WriteLine(line);
                }

                //
                fs = new FileStream(sourcePath, FileMode.Open);
                sr = new StreamReader(fs);

                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.WriteLine("An error occured");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }

                if (sr != null)
                {
                    sr.Close();
                }
            }
        }
    }
}