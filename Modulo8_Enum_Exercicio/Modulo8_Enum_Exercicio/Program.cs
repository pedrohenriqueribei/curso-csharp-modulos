using Modulo8_Enum_Exercicio.Entities;
using Modulo8_Enum_Exercicio.Entities.Enum;
using System.Globalization;

namespace Modulo8_Enum_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o departamento");
            string departName = Console.ReadLine();

            Console.WriteLine("Worker");
            Console.WriteLine("Name");
            string name = Console.ReadLine();

            Console.WriteLine("Level: (Junior/ MedLevel/Senior)");
            WorkerLevel leval = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.WriteLine("Base Salary");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(departName);
            Worker worker = new Worker(name, leval, baseSalary, department);

            Console.WriteLine("How many contracts to this worker");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #" + i + " contract data");
                Console.WriteLine("Data: ");
                DateOnly date = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("Value Per Hour");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours):");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, hours, valuePerHour);

                worker.AddContract(contract);
            }

            Console.WriteLine();

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string mesAno = Console.ReadLine();
            int mes =  int.Parse(mesAno.Substring(0, 2));
            int ano = int.Parse(mesAno.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: "+ worker.department.Name);
            Console.WriteLine("Income for "+ mesAno+ ": " + worker.Income(ano,mes).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
