using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos {
    class ExerciciosOperadores {

        public static void Executar() {
            /*
            Console.WriteLine("qual é a 1 nota do aluno ?");
            double n1 = double.Parse(Console.ReadLine());
 
            Console.WriteLine("qual é a 2 nota do aluno ?");
            double n2 = double.Parse(Console.ReadLine());
 
            Console.WriteLine("qual a 3 nota ?");
            double n3 = double.Parse(Console.ReadLine());
 
            double resultado = Math.Round((n1 + n2 + n3) / 3,2);
 
            Console.WriteLine($"A média do aluno é : {resultado}");
            */

            /*
            Console.WriteLine("Digite a 1° Nota: ");
            double n1 = double.Parse(Console.ReadLine());
            double resul1 = n1 * 3.5;

            Console.WriteLine("Digite a 2° Nota: ");
            double n2 = double.Parse(Console.ReadLine());
            double resul2 = n2 * 7.5;

            double resultado = Math.Round((resul1 + resul2) / 11,1);
            Console.WriteLine($"O resultado:{resultado}");
            */

            Console.WriteLine("Digite seu número de funcionário: ");
            int numFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite suas horas trabalhadas: ");
            var horas = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu salário: ");
            var salario = double.Parse(Console.ReadLine());

            var salarioTotal = horas * salario;

            Console.WriteLine($"Número de Funcionário: {numFuncionario}");
            Console.WriteLine($"Salário: {salarioTotal}");

        }
             
    }
}
