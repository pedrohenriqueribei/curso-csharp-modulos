namespace Modulo13
{
    class Program
    {
        public static HashSet<int> set = new HashSet<int>();

        static void Main(string[] args)
        {
            

            Console.WriteLine("How many students for course A?");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe as matriculas");

            SetHashSet(a);

            Console.WriteLine();

            Console.WriteLine("How many students for course B?");
            int b = int.Parse(Console.ReadLine());

            SetHashSet(b);

            Console.WriteLine();
            Console.WriteLine("How many students for course C?");
            int c = int.Parse(Console.ReadLine());

            SetHashSet(c);

            Console.WriteLine(" ------- ");
            Console.WriteLine("Total students: "+ set.Count);
        }

        private static void SetHashSet(int number)
        {
            for(int i = 0;i < number; i++)
            {
                int mat = int.Parse(Console.ReadLine());

                set.Add(mat);
            }
        }
    }
}