using System;

namespace CSharp
{
    class Test
    {
        static void Main(string[] args)
        {


            int res = 0;

            for(int i=0;i<=10;i++ )
            {
                res += 2;
            }

            var pessoa1 = (Pessoas)0;
            Pessoas pessoa2 = Pessoas.fulano2;
            Pessoas pessoas3 = (Pessoas)3;

            Animal caska = new Animal();

            caska.Nome = "Caska";
            caska.NomeDono = "Alan";
            caska.Especie = "PAPAGAIA";

            var teste = new TesteOO();


            teste.Nome = "Alan";
            teste.Idade = 25;

            Console.WriteLine(res);
            Console.WriteLine("Testando Get Set :   Nome:{0} e Idade: {1}",teste.Nome,teste.Idade);
            
            Console.WriteLine("Testando a class com a interface : Meu nome é: {0}. O nome da minha filha mais velha é {1} , e ela è uma {2}",caska.NomeDono,caska.Nome,caska.Especie);
            Console.WriteLine("Testando o Enum: {0},{1},{2}", pessoa1, pessoa2, pessoas3);
        }
    }
}