using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            do
            {

                Console.WriteLine("\n\n - Seja bem-vindo!! Escolha entre:\n - 'F' para uma menssagem fofa.\n - 'D' para a menssagem do dia.\n - 'S' para sair.");
                Console.Write("\n - Opção: ");
                switch (opcao = Console.ReadLine().ToUpper())
                {
                    case "F":
                        Console.WriteLine("\n   Pedi a estrela cadente\r\n   Por um presente perfeito,\r\n   Você me apareceu\r\n   E eu me amarrei no seu jeito!");
                        break;
                    case "D":
                        Console.WriteLine("\n   A sua zona de conforto é o cárcere das suas possibilidades.");
                        break;
                    case "S":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n   Opção inválida!");
                        break;
                }



            } while (opcao != "S".ToUpper());

        }
    }
}
