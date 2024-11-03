namespace Modulo11
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Pedro\\Desktop\\Projetos C#";

            try
            {

                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);

                Console.WriteLine("Pastas");

                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                Console.WriteLine("Arquivos");

                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Directory.CreateDirectory(path + "\\newFolder");
        }
    }
}
