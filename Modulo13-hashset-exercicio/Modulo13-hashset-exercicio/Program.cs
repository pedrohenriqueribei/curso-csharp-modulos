

using Modulo13_hashset_exercicio.Entities;
using Modulo13_hashset_exercicio.Services;
using System.Reflection.Metadata;

namespace Modulo13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            //string path = "C:\\Users\\Pedro\\Desktop\\Projetos C#\\Modulo13-hashset-exercicio\\in.txt";

            HashSet<User> users = new HashSet<User>();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);

                        RunService run = new RunService();

                        User usuario = run.SetUserSystem(line);
                        users.Add(usuario);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("----- Users ------");

            foreach (User user in users)
            {
                Console.WriteLine(user.Name);
            }

            Console.WriteLine("----- Total Users ------");
            Console.WriteLine(users.Count);

            Console.WriteLine("----- Total Acess ------");
            
            foreach(User user in users)
            {
                Console.WriteLine(user.Instant);
            }
        }

        
    }
}