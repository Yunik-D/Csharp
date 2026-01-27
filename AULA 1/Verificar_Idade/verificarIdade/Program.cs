using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificarIdade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age;

            Console.WriteLine(" ==========================================");
            Console.WriteLine("           Verificador de Idade           ");
            Console.WriteLine(" ==========================================");

            Console.Write(" - Por obséquio, nobre persona, informe vossa idade: ");
            Age = int.Parse(Console.ReadLine());

            if (Age >= 18)
            {
                Console.WriteLine(" Parabéns, você atingiu a maior idade e já pode dirigir!");
            }
            else
            {
                Console.WriteLine(" Parabéns, você ainda é menor de idade, então aproveite enquanto pode!");
            }

        }
    }
}
