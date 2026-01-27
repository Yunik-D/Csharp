using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int operacao;

            Console.WriteLine(" ============================");
            Console.WriteLine("     Calculadora simples");
            Console.WriteLine(" ============================");

            Console.WriteLine("\n - Cara e inestimável persona, informe dois números abaixo:\n");
            Console.Write(" - Número 1: ");
            a = int.Parse(Console.ReadLine());

            Console.Write(" - Número 2: ");
            b = int.Parse(Console.ReadLine());


            Console.Clear();
            Console.WriteLine(" - Agora escolha a operação desejada:");
            Console.WriteLine(" - 1 Para somar.");
            Console.WriteLine(" - 2 Para subtrair.");
            Console.WriteLine(" - 3 Para multiplicar.");
            Console.WriteLine(" - 4 Para Dividir.");

            operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    Console.WriteLine(" - A soma dos números é: " + (a + b));
                    break;
                case 2:
                    Console.WriteLine(" - A subtração dos números é: " + (a - b));
                    break;
                case 3:
                    Console.WriteLine(" - A multiplicação dos números é: " + (a * b));
                    break;
                case 4:
                    if (b == 0)
                    {
                        Console.WriteLine(" - Erro: Divisão por zero não é permitida!");
                    }
                    else
                    { 
                         Console.WriteLine(" - A divisão dos números é: " + (a / b));
                    }
                    break;
                default:
                    Console.WriteLine(" - Operação inválida!");
                    break;
            }

        }
    }
}
