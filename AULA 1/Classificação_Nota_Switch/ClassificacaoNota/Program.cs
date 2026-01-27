using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassificacaoNota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota;

            Console.WriteLine(" ================================");
            Console.WriteLine("     Classificação de Notas      ");
            Console.WriteLine(" ================================");
        
            Console.Write(" - Digite a nota do aluno (0 a 10): \n");
            Console.Write(" - Nota: ");
            nota = int.Parse(Console.ReadLine());

            switch (nota)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine(" - Reprovado! Estude mais.");
                    break;
                case 5:
                case 6:
                    Console.WriteLine(" - Recuperação! Estude para passar!");
                    break;
                case 7:
                case 8:
                    Console.WriteLine(" - Aprovado! Parabéns.");
                    break;
                case 9:
                case 10:
                    Console.WriteLine(" - Excelente! Aprovado com méritos.");
                    break;
                    default:
                    Console.WriteLine(" - Nota inválida! Digite uma nota entre 0 e 10.");
                    break;
            }

        }
    }
}
