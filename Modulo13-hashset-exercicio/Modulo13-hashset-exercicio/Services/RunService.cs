using Modulo13_hashset_exercicio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo13_hashset_exercicio.Services
{
    class RunService
    {

        public User SetUserSystem(string userData)
        {
            string[] datas = userData.Split(' ');
            string nome = datas[0];
            DateTime dataAcesso = DateTime.Parse(datas[1]);

            return new User(nome, dataAcesso);

        }
    }
}
