using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {

        public static void Executar() {
            string nome = "Malcom";
            int idade = 38;
            var sobreNome = "Batman"; //Variável Coringa
            double altura = 1.60;
            bool casado = false;

            idade = 40;

            const double pi = 3.14; // Constante

            //Formas de Concatenação
            Console.WriteLine("Olá meu nome é " + nome + ", tenho " + idade + " anos com altura de " + altura + " e " + casado + " não sou.");
            Console.WriteLine($"Olá meu nome é {nome}, tenho {idade} anos com altura de {altura} e é {casado} a história que sou casado.");

        }

    }
}
