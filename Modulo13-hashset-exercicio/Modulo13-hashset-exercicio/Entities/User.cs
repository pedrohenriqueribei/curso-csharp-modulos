using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo13_hashset_exercicio.Entities
{
    class User
    {
        public string Name { get; set; }
        public DateTime Instant { get; set; }

        public User(string name, DateTime date) {
            Name = name;
            Instant = date;
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is User))
            {
                throw new FieldAccessException("Não é usuário!!");
            }
            User other = (User)obj;

            return Name.Equals(other.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
