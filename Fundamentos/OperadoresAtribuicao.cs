using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            //ATRIBUIÇÃO
            var num = 3;

            //Substituindo número por 7 
            num = 7;

            //ATRIBUIÇÃO ADITIVAS 
            num += 10; //num = num + 10
            
            //ATRIBUIÇÃO SUBSTRATIVA
            num -= 3; //num = num - 3

            num *= 5;

            Console.WriteLine(num);

            var a = 1;
            var b = 1;

            a++; //a = a + 1

            b--; //b = b - 1 

        }
    }
}
