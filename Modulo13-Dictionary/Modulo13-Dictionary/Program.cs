using System.Runtime.CompilerServices;

namespace Modulo13
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["nome"] = "Pedro";
            cookies["email"] = "pedro@gmail.com";
            cookies["phone"] = "61 99156-6128";

            Console.WriteLine(cookies["nome"]);

            foreach (var cookie in cookies)
            {
                Console.WriteLine(cookie);
            }

            Console.WriteLine("All cookies");

            foreach(KeyValuePair<string,string> kvp in cookies)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }
        }
    }
}