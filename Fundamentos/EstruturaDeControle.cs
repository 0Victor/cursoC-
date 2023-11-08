using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class EstruturaDeControle {
        public static void Executar() {
            /*
            double dinheiro = 8000;

            if (dinheiro > 5000) {
                Console.WriteLine("Posso Viajar!");                     
            }

            else {
                Console.WriteLine("Não posso viajar!");
            }*/
            Console.WriteLine("Digite a 1° nota: ");
            double num1 = double.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite a 2° nota: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a 3° nota: ");
            double num3 = double.Parse(Console.ReadLine());

            double media = (num1 + num2 + num3) / 3;

            if (media >= 7.0) {

                Console.WriteLine("Você foi aprovado!");
            
            } else {
                Console.WriteLine("Você foi reprovado!");
            }
            




        }
    }
}
