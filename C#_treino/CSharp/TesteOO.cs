using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
     class TesteOO
    {
        //Atributos
        private string nome;
        private int idade;

        // Gets  e Sets

        public string Nome { get; set; }
        public int Idade { get; set; }

        //Construtor 
        public TesteOO() {
            Console.WriteLine("Testando");
        }


        }
}
