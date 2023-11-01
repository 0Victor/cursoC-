using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {

        public static void Executar() {

            //Arredondar Número
            double valor = 15.175;

            Console.WriteLine(valor.ToString("F1"));

            //Transformar um valor monetário (Moeda de acordo como idioma da Máquina)
            Console.WriteLine(valor.ToString("C"));

            //Multiplica um valor por 100 e adiciona percentual
            Console.WriteLine(valor.ToString("p"));

            //Formatando o número do jeito que você quiser
            Console.WriteLine(valor.ToString("#.##"));


        }

    }
}
