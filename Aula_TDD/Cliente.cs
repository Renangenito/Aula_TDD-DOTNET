using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_TDD
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }


        public bool MaiorDeIdade()
        {
            if (Idade < 18)
                return false;
           
            return true;

        }
       
    }
}
