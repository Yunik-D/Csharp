using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificacaoLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Usuario = "admin";
            string senha = "#0056";

            string user;
            string pass;

            Console.WriteLine(" ===============");
            Console.WriteLine("      LOGIN     ");
            Console.WriteLine(" ===============");

            Console.Write("\n - User: ");
            user = Console.ReadLine();
            if (user != "admin")
            {
                Console.WriteLine(" - Usuário não cadastrado!");
            }
            else
            {
            
            Console.Write(" - Password: ");
            pass = Console.ReadLine();
            if (pass != senha)
            {
                Console.WriteLine(" - Senha incorreta!");
            }
            else
            {                  
                Console.WriteLine(" - Login realizado com sucesso!");

            }

            }
        }
    }
}
