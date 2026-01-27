using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Igualdade_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;

            Console.WriteLine(" ================================");
            Console.WriteLine("  Verificar igualdade de Strings");
            Console.WriteLine(" ================================");

            Console.WriteLine(" - Para verificar a igualdade correta, os nomes \n - devem ser escritos de formas iguals.\n");

            Console.Write(" - Digite o primeiro nome: ");
            nome1 = Console.ReadLine();

            Console.Write(" - Digite o segundo nome: ");
            nome2 = Console.ReadLine();

            if (nome1 == nome2)
            {
                Console.WriteLine(" - Os nomes são iguais.");
            }
            else
            {
                Console.WriteLine(" - Os nomes são diferentes.");
            }
        }
    }
}
