using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {

        public static void Executar() {
            /*
            Console.WriteLine("Digite um número: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro número: ");
            int num2 = int.Parse(Console.ReadLine());

            int resultado = num1 + num2;

            Console.WriteLine($"O resultado da soma é: {resultado}");
            */

            Console.WriteLine("Para calcular a área digite o número da base: ");
            int baseNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número da altura: ");
            int alturaNum = int.Parse(Console.ReadLine());

            int resultado = (baseNum * alturaNum) / 2;

            Console.WriteLine($"O resultado da área é: {resultado}");



        }
    }
}
