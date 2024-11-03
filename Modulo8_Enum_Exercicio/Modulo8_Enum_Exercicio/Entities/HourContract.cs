using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo8_Enum_Exercicio.Entities
{
    class HourContract
    {
        public int Id { get; set; }
        public DateOnly date {  get; set; }
        public int hours { get; set; }  
        public double valuePerHour { get; set; }


        public HourContract() { }

        public HourContract(DateOnly date, int hours, double valuePerHour)
        {
            this.date = date;
            this.hours = hours;
            this.valuePerHour = valuePerHour;
        }

        public double totalValue()
        {
            return valuePerHour * hours;
        }
    }
}
