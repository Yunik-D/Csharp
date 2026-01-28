using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variável que guarda a conta criada
            // Começa como null porque ainda não existe conta
            Conta conta = null;

            // Guarda a opção digitada no menu
            string opcao;

            // Laço principal do sistema (menu)
            // Continua até o usuário escolher "Q"
            do
            {
                // Cabeçalho do sistema
                Console.WriteLine(" ===============================");
                Console.WriteLine("     Bem-vindo ao Banco do L.");
                Console.WriteLine(" ===============================");

                // Opções disponíveis para o usuário
                Console.WriteLine("\n Selecione uma das opções abaixo:");
                Console.WriteLine(" C -> Criar uma conta com saldo inicial.");
                Console.WriteLine(" D -> Depositar um saldo na conta.");
                Console.WriteLine(" S -> Sacar um valor da conta.");
                Console.WriteLine(" V -> Visualizar o saldo atual da conta.");
                Console.WriteLine(" Q -> Sair do sistema.");

                // Lê a opção do usuário e converte para maiúscula
                // Isso evita erros de case-sensitive (c vs C)
                Console.Write("\n Opção: ");
                switch (opcao = Console.ReadLine().ToUpper())
                {
                    case "C":
                        // Limpa a tela antes do processo de criação
                        Console.Clear();

                        // Enquanto conta for null, ainda não foi criada
                        while (conta == null)
                        {
                            try
                            {
                                double saldo;

                                // Solicita o saldo inicial
                                Console.WriteLine("Digite um valor para iniciar a conta: ");

                                // Loop de validação:
                                // - garante que o valor é numérico (TryParse)
                                // - garante que o valor não é negativo (saldo < 0)
                                while (!double.TryParse(Console.ReadLine(), out saldo) || saldo < 0)
                                {
                                    Console.WriteLine("Erro: Informe um valor válido para iniciar: ");
                                }

                                Console.WriteLine("Parabéns, a conta foi criada com sucesso!!");
                                // Cria a conta com saldo válido
                                conta = new Conta(saldo);
                            }
                            catch (Exception ex)
                            {
                                // Caso o construtor lance alguma exceção (por exemplo, regras adicionais no futuro)
                                Console.WriteLine("Erro: " + ex.Message);

                                /**
                                 * Aqui o Try/Catch, apesar de se mostrar em uso,
                                 * Não é estritamente necessário, já que as validações
                                 * Já garantem que o saldo é um número válido maior ou igual a zero.
                                 * Portanto, Try/Catch se torna "inútil" e redundante nesse caso.
                                 * A remoção dele não afetaria o funcionamento do sistema.
                                 **/
                            }
                        }
                        break;

                    case "D":
                        Console.Clear();

                        // Se a conta não existe, não dá para depositar
                        if (conta == null)
                        {
                            Console.WriteLine("Erro: Nenhuma conta encontrada.");
                        }
                        else
                        {
                            double valor;

                            // Solicita o valor do depósito
                            Console.WriteLine("Informe quanto será depositado: ");

                            // Validação:
                            // - valor precisa ser numérico
                            // - valor precisa ser maior que zero (não aceita 0 nem negativo)
                            while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                            {
                                Console.WriteLine("Erro: Informe um valor válido para depositar: ");
                            }

                            // Realiza o depósito chamando o método da classe Conta
                            conta.Depositar(valor);

                            // Mensagem de confirmação ao usuário
                            Console.WriteLine("Depósito Realizado!");
                        }
                        break;

                    case "S":
                        Console.Clear();

                        // Se a conta não existe, não dá para sacar
                        if (conta == null)
                        {
                            Console.WriteLine("Erro: Nenhuma conta encontrada.");
                        }
                        //Se o saldo for  0, não dá para sacar
                        else if(conta.Saldo <= 0)
                        {
                            Console.WriteLine("Erro: Saldo insuficiente para saque.");
                        }
                        //Caso as validações acima sejam passadas, permite o saque
                        else
                        {
                            
                            double valor;

                            // Solicita o valor do saque e exibe o saldo atual
                            Console.WriteLine("Quanto será sacado?");
                            Console.WriteLine("Saldo atual: " + conta.Saldo);

                            // Validação:
                            // - valor precisa ser numérico
                            // - valor precisa ser maior que 0
                            // - valor não pode ultrapassar o saldo
                            while (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0 || valor > conta.Saldo)
                            {
                                Console.WriteLine("Erro: Informe um valor válido para sacar.");
                                Console.WriteLine("Saldo atual: " + conta.Saldo);
                            }

                            // Realiza o saque chamando o método da classe Conta
                            conta.Sacar(valor);

                            // Mensagem de confirmação ao usuário
                            Console.WriteLine("Saque Realizado!");
                        }
                        break;

                    case "V":
                        Console.Clear();

                        // Se a conta não existe, não dá para visualizar saldo
                        if (conta == null)
                        {
                            Console.WriteLine("Erro: Nenhuma conta encontrada.");
                        }
                        else
                        {
                            // Exibe o saldo atual da conta
                            Console.WriteLine("O saldo atual conta é: " + conta.Saldo);
                        }
                        break;

                    case "Q":
                        // Encerra o sistema (o loop termina porque opcao == "Q")
                        Console.WriteLine("Encerrando...");
                        break;

                    default:
                        // Caso o usuário digite uma opção inválida
                        Console.Clear();
                        Console.WriteLine("Opção inválida! Selecione uma das opções abaixo: ");
                        break;
                }

            } while (opcao != "Q"); // O menu se repete até escolher sair
        }
    }

}
