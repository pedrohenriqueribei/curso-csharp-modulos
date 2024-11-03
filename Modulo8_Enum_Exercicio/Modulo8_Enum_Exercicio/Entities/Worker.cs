using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulo8_Enum_Exercicio.Entities.Enum;

namespace Modulo8_Enum_Exercicio.Entities
{
    class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int WorkerId { get; set; }
        public WorkerLevel level { get; set; }
        public double baseSalary { get; set; }

        public Department department { get; set; }

        public List<HourContract> contracts {  get; set; } = new List<HourContract>();

        public Worker() { }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            this.level = level;
            this.baseSalary = baseSalary;
            this.department = department;
        }

        public void AddContract (HourContract contract)
        {
            this.contracts .Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            this.contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = baseSalary;

            foreach(HourContract contract in this.contracts) {

                if (contract.date.Year == year && contract.date.Month == month)
                {
                    sum += contract.totalValue();
                }
                

             }

            return sum;
        }
    }
}
