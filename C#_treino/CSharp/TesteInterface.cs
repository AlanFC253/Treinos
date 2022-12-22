using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    internal interface IAnimal
   {
        //Metodos que a class vai ter que aplicar
        void Nome(string nome);
        void Dono(string nomeDono);
        void Especie(string especie);
    }

    class Animal : IAnimal
    {
        // Class linkada a Interface
        public string Nome { get; set; }
        public string NomeDono { get; set; }
        public string Especie { get; set; }

        void IAnimal.Nome(string nome)
        {
            this.Nome = nome;
        }

        void IAnimal.Dono(string dono)
        {
            this.NomeDono = dono;
        }

        void IAnimal.Especie(string especie)
        {
            this.Especie = especie;
        }
    }
}
