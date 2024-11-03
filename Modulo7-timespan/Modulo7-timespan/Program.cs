

namespace Program {
    class Program
    {
        static void Main(string[] args) {


            DateTime d = new DateTime(2024, 10, 21, 20, 11, 58);

            Console.WriteLine(d.ToString());

            DateTime d2 = d.AddDays(3);

            Console.WriteLine(d2.Subtract(d));
        }
    }
}