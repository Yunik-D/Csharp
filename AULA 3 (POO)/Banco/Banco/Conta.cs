using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Conta
    {
        // Propriedade pública para leitura do saldo
        // 'private set' impede que o saldo seja alterado diretamente fora da classe
        public double Saldo { get; private set; }

        // Construtor da conta:
        // é chamado quando fazemos new Conta(saldo)
        // garante que a conta "nasça válida"
        public Conta(double saldo)
        {
            // Regra: saldo inicial não pode ser negativo
            if (saldo < 0)
                throw new ArgumentException("O Saldo não pode ser negativo.");

            // Se o saldo for válido, armazena
            Saldo = saldo;
        }

        // Método para depositar dinheiro na conta
        public void Depositar(double valor)
        {
            // Regra: não aceita depósito zero ou negativo
            if (valor <= 0)
                throw new ArgumentException("O valor informado para depósito é inferior ao permitido.");

            // Atualiza o saldo somando o valor depositado
            Saldo += valor;
        }

        // Método para sacar dinheiro da conta
        public void Sacar(double valor)
        {
            // Regra: não aceita saque zero ou negativo
            if (valor <= 0)
                throw new ArgumentException("O valor para saque informado é inferior ao permitido.");

            // Regra: não permite sacar mais do que o saldo disponível
            if (valor > Saldo)
                throw new InvalidOperationException("Saldo insuficiente para saque.");

            // Atualiza o saldo subtraindo o valor sacado
            Saldo -= valor;
        }
    }

}
