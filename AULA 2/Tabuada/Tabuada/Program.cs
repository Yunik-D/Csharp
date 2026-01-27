using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;

            Console.Write(" - Informe um número para ver a tabuada: ");
            number = int.Parse(Console.ReadLine());

            Console.WriteLine("A tabuada do numero " + number + " é ");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(" -> " + number + " X " + i + " = " + number * i);
            }
        }
    }
}
