namespace Modulo13
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();

            set.Add("TV");
            set.Add("Notebook");
            set.Add("Tablet");

            Console.WriteLine(set.Contains("Notebook"));


            foreach (var item in set)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("------------------ SortedSet");

            SortedSet<int> a = new SortedSet<int>() { 0,2,4,5,6,8,10 };
            SortedSet<int> b = new SortedSet<int>() { 4, 6, 7, 8, 9 };

            PrintCollection(a);

            Console.WriteLine("------------------  Union");

            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(b);
            PrintCollection(c);

            Console.WriteLine("------------------  Intersection");
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            PrintCollection(d);

            Console.WriteLine("------------------  Except");
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " - ");
            }
            Console.WriteLine();
        }
    }
}