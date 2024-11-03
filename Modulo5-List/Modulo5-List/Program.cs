using System;

namespace Modulo5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Anna");
            list.Add("Pedro");
            list.Add("Gabriela");

            list.Insert(2, "Luiza");
            list.Insert(1, "Paula");

            foreach (var item in list)
            {
                Console.WriteLine(item);
     
            }

            Console.WriteLine(list.Count);

            string last = list.FindLast(x => x[0] == 'p');

            Console.WriteLine("Last: "+last);

            Console.WriteLine("");

            Console.WriteLine("---------------");

            int pos1 = list.FindLastIndex(x => x[0] == 'P');

            Console.WriteLine(pos1);



            Console.WriteLine("");

            Console.WriteLine("--------------- FIND ALL");

            List<string> result = list.FindAll(x => x.Length >= 5);


            ImprimirLista(result);


            Console.WriteLine("");

            Console.WriteLine("--------------- REMOVE");

            list.Remove("Pedro");
            list.Remove("Gabrielaaaa");

            list.RemoveAt(3);

            ImprimirLista(list);


            Console.WriteLine("");

            Console.WriteLine("--------------- REMOVE ALL");

            list.RemoveAll(x => x.Length >= 5); 
            ImprimirLista(list);

        }

        public static void ImprimirLista(List<string> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}