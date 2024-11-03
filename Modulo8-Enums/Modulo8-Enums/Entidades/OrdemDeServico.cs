using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modulo8_Enums.Entidades.Enums;

namespace Modulo8_Enums.Entidades
{
    internal class OrdemDeServico
    {
        public int Id { get; set; }
        public DateTime Moment {  get; set; }

        public StatusEnum Status {  get; set; }

        public override string ToString()
        {
            return Id
                + ", "
                + Moment
                + ", "
                + Status;
        }
    }
}
