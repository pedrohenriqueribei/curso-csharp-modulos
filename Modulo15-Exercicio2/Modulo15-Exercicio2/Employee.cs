using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Modulo15_Exercicio2
{
    internal class Employee :IComparable<Employee>
    {
        
        public string Name { get; set; }    
        public string Email { get; set; }   
        public double Salary { get; set; }

        public Employee(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }

        public override string ToString()
        {
            return "Nome........ : " + Name + "\n" +
                   "Email........: " + Email + "\n" +
                   "Salary.......: " + Salary.ToString("F2", CultureInfo.InvariantCulture) + "\n";
        }

        public int CompareTo(Employee? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
