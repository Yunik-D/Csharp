using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Produto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variável que irá armazenar o produto cadastrado
            // Começa como null porque ainda não existe nenhum produto
            Produto produto = null;

            // Variável que guarda a opção do menu
            string opcao;

            // Laço principal do menu
            // O programa continua executando até o usuário escolher "S"
            do
            {
                // Cabeçalho do sistema
                Console.WriteLine(" ===============================");
                Console.WriteLine("   Cadastro de produtos XInfo.");
                Console.WriteLine(" ===============================");

                // Opções disponíveis para o usuário
                Console.WriteLine("\n Selecione uma das opções abaixo:");
                Console.WriteLine(" C -> Cadastrar um novo produto.");
                Console.WriteLine(" V -> Visualizar um produto.");
                Console.WriteLine(" S -> Sair do sistema.");

                // Leitura da opção digitada
                Console.Write("\n Opção: ");
                opcao = Console.ReadLine().ToUpper();
                // ToUpper evita problemas com letras minúsculas

                // Estrutura de decisão para tratar a opção escolhida
                switch (opcao)
                {
                    case "C":
                        // Limpa a tela antes do cadastro
                        Console.Clear();

                        try
                        {
                            // Solicita o nome do produto
                            Console.WriteLine(" Digite um nome para o produto: ");
                            string nome = Console.ReadLine();

                            /*
                             Console.WriteLine(" Informe um valor para o produto " + nome + ".");
                                double preco = double.Parse(Console.ReadLine());

                            -> Esse trecho, apesar de correto, pode causar quebra durante a execução caso o usuário digite texto. 
                            -> Sendo então, necessário recriar um produto do ZERO (Não que nesse caso seja difícil).

                            -> Forma correta e corrigida abaixo:
                             */

                            double preco;

                            // Solicita o preço do produto
                            Console.WriteLine(" Informe um valor para o produto " + nome + ".");

                            // Loop que valida:
                            // 1) se o valor é numérico
                            // 2) se o valor não é negativo
                            while (!double.TryParse(Console.ReadLine(), out preco) || preco < 0)
                            {
                                Console.WriteLine(" Valor inválido. Informe um número não-negativo:");
                            }

                            // Criação do objeto Produto
                            // O construtor ainda valida as regras de negócio
                            produto = new Produto(nome, preco);

                            // Limpa a tela após o cadastro
                            Console.Clear();
                            Console.WriteLine(" O produto foi cadastrado com sucesso!!");
                        }
                        catch (Exception e)
                        {
                            // Caso ocorra algum erro (throw no construtor, por exemplo)
                            Console.Clear();
                            Console.WriteLine(" Ocorreu um erro ao cadastrar o produto: " + e.Message);
                        }
                        break;

                    case "V":
                        // Limpa a tela antes de exibir informações
                        Console.Clear();

                        // Verifica se existe algum produto cadastrado
                        if (produto == null)
                        {
                            Console.WriteLine(" Não há produtos cadastrados.");
                        }
                        else
                        {
                            // Exibe os dados do produto utilizando as propriedades
                            Console.WriteLine(" Nome do produto: " + produto.Nome);
                            Console.WriteLine(" Preço do produto: " + produto.Preco);
                        }
                        break;

                    case "S":
                        // Mensagem de encerramento do sistema
                        Console.WriteLine(" Encerrando o programa...");
                        break;

                    default:
                        // Caso o usuário digite uma opção inválida
                        Console.Clear();
                        Console.WriteLine(" Opção inválida. Selecione uma das opções abaixo: ");
                        break;
                }

            } while (opcao != "S"); // O menu se repete até o usuário escolher sair
        }
    }
}
