using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo8_Enum_Exercicio.Entities
{
    class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Department() { }

        public Department(string name) { 
            Name = name;
        }
    }
}
