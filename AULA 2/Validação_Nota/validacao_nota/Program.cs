using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace validacao_nota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;

            Console.WriteLine("Digite uma nota entre 1 e 10: ");
            Console.Write("Nota: ");
            nota = int.Parse(Console.ReadLine());

            while (nota < 1 || nota > 10)
            {
                Console.WriteLine("Nota inválida! Digite uma nota entre 1 e 10: ");
                nota = int.Parse(Console.ReadLine());
            }

            if(nota <= 5)
            {
                Console.WriteLine("Nota ruim - Reprovado!");
            }
            else if(nota <= 8)
            {
                Console.WriteLine("Nota boa - Aprovado!");
            }
            else
            {
                {
                    Console.WriteLine("Nota excelente - Mais que aprovado!!!");
                }
            }
        }
    }
}
