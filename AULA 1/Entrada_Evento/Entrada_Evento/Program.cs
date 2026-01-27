using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrada_Evento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Age;
            bool temIngresso;
            bool acompanhadoResponsavel;
            string respostaIngresso;
            string respostaAcompanhado;

            Console.WriteLine(" ================================");
            Console.WriteLine("        Entrada no Evento     ");
            Console.WriteLine(" ================================\n");

            Console.WriteLine(" - Para entrar no evento você precisa cumprir os requisitos:\n - Ter o ingresso.\n - Ser maior de 18.\n - Estar acompanhada(o) se menor de 18.\n");


            Console.Write("Digite sua idade: "); //Solicita a idade do usuário.
            Age = int.Parse(Console.ReadLine()); //Lê a idade digitada e converte para inteiro.
            if (Age >= 18) //Verifica se o usuário é maior de idade.
            {
                Console.WriteLine("Você é maior de idade e pode seguir com a verificação do ingresso.");
            }
            else //Se o usuário for menor de idade, executa o próximo bloco de verificação de acompanhamento do responsável.
            {
                Console.WriteLine("Você é menor de idade e precisa estar acompanhado por um responsável para entrar no evento.");
            }



            if (Age < 18) //se o usuário for menor de idade, pergunta se está acompanhado por um responsável.
            {
                Console.Write("Você está acompanhado(a) de um responsável? (Sim/Não): ");
                respostaAcompanhado = Console.ReadLine();
                if (respostaAcompanhado.ToUpper() == "sim") //Se a resposta for sim, atribui o valor true 
                {                                                                              //à variável acompanhadoResponsavel e permite seguir com a verificação do ingresso.
                    acompanhadoResponsavel = true;

                    if (acompanhadoResponsavel == true)
                    {
                        Console.WriteLine("Ótimo! Você pode seguir com a verificação do ingresso.");
                    }

                }
                else //Se a resposta for não, informa que é necessário estar acompanhado por um responsável para entrar no evento e encerra o programa.
                {
                    acompanhadoResponsavel = false;
                    Console.WriteLine("Você precisa estar acompanhado por um responsável para entrar no evento.");
                    Environment.Exit(0);
                }
            }





            Console.Write("Você tem ingresso? (Sim/Não): "); //Pergunta se o usuário tem ingresso.
            respostaIngresso = Console.ReadLine();
            if (respostaIngresso.ToUpper() == "sim") //Se a resposta for sim, atribui o valor true 
            {                                                                                       //à variável temIngresso e permite seguir com a entrada no evento.
                temIngresso = true;

                if (temIngresso == true)
                {
                    Console.WriteLine("Ótimo! Você pode seguir com a verificação do ingresso.");
                }

                Console.WriteLine("Ótimo! Você pode entrar no evento. Aproveite!");
            }
            else //Se a resposta for não, informa que é necessário ter um ingresso para entrar no evento e encerra o programa.
            {
                temIngresso = false;
                Console.WriteLine("Você precisa de um ingresso para entrar no evento.");
                Environment.Exit(0);
            }

        }
    }
}
