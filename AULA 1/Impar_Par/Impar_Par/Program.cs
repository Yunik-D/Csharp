using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impar_Par
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.WriteLine(" ===================================");
            Console.WriteLine("  Verificar numero: Impar ou Par");
            Console.WriteLine(" ===================================");

            Console.Write(" - Digite um numero a ser verificado entre 1 e 10: ");
            number = int.Parse(Console.ReadLine());

           while(number < 1 || number > 10)
            {
                Console.WriteLine("Número inválido! Por gentileza, digite um numero entre 1 e 10.");
                number = int.Parse(Console.ReadLine());
            }

            if (number %2 == 0)
            {
                Console.Write(" - O numero " + number + " é Par.");
            }
            else
            {
                Console.Write(" - O numero " + number + " é Impar.");
            }
        }
    }
}
