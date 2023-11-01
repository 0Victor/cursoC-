using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class LendoDados {

        public static void Executar() {
            Console.WriteLine("Qual o seu nome?");

            //Armazenar a entrada de dados pelo usuário
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade?");

            //Números inteiros e reais precisam ser convertidos com o PARSE
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a sua altura?");

            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine($"Olá {nome} você tem {idade} anos e {altura} de altura");


        }
    }
}
