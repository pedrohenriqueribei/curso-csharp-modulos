using Modulo15_Exercicio2;
using System.Globalization;

namespace Modulo15
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Users\\Pedro\\Desktop\\Projetos C#\\Modulo15-Exercicio2\\in.txt";

            List<Employee> employees = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double price = double.Parse(fields[2], CultureInfo.InvariantCulture);
                    
                    Employee emp = new Employee(name, email, price);
                    employees.Add(emp);
                }
            }

            //ordenando a coleção: implemetado a interface IComparable
            //employees.Sort();

            //buscando os dados de forma ordenada
            var funcs = employees.OrderBy(f => f.Name);
            //funcs.ForEach(Console.WriteLine);

            foreach (var item in funcs)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Enter value salary");
            double sal = double.Parse(Console.ReadLine());

            var emails = employees.Where(f => f.Salary >= sal).OrderBy(f => f.Email).Select(f => f.Email);

            Console.WriteLine("Mostrar em ordem alfabetica o email dos funcionarios que tem salario maior que " + sal.ToString("F2", CultureInfo.InvariantCulture) + ". ");
            foreach(var email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine("Mostrar a soma dos salarios dos funcioarios que começam com a letra M");
            double soma = 0.0;
            foreach (var emp in employees)
            {
                if (emp.Name[0] == 'M')
                {
                    soma += emp.Salary;
                }
            };
            Console.WriteLine("$ " + soma.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
