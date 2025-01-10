using System;
using System.Collections.Generic;

namespace Atividade_09_01
{
    class Executar
    {
        static Bank bank;
        static Customer currentCustomer;
        static Account currentAccount;

        static void Main(string[] args)
        {
            // Criar o banco
            bank = new Bank(1, "Banco Central");

            // Criar clientes
            Customer customer1 = new Customer("João Silva", "Rua A, 123", new DateTime(1985, 5, 20), 12345, 1234);
            Customer customer2 = new Customer("Maria Oliveira", "Rua B, 456", new DateTime(1990, 8, 15), 67890, 5678);

            // Criar contas
            Account account1 = new CurrentAccount(1001, 5000, customer1);
            Account account2 = new SavingAccount(1002, 10000, customer2);

            // Adicionar as contas ao banco
            bank.AddAccount(account1);
            bank.AddAccount(account2);

            // Exibição do menu
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine("       BEM-VINDO AO BANCO       ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Fazer Login");
                Console.WriteLine("2. Criar Conta");
                Console.WriteLine("3. Sair");
                Console.WriteLine("=================================");
                Console.Write("Escolha uma opção: ");

                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            PerformLogin();
                            break;
                        case 2:
                            CreateAccount();
                            break;
                        case 3:
                            Console.WriteLine("Saindo... Até logo!");
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            }
        }

        static void CreateAccount()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("       CRIAR CONTA              ");
            Console.WriteLine("=================================");
            Console.WriteLine("1. Conta Corrente");
            Console.WriteLine("2. Conta Poupança");
            Console.WriteLine("=================================");
            Console.Write("Escolha uma opção: ");
            int option;
            if (int.TryParse(Console.ReadLine(), out option))
            {
                if (option == 1 || option == 2)
                {
                    try
                    {
                        // Entrada dos dados do cliente
                        Console.WriteLine("Digite o nome do titular :");
                        string name = Console.ReadLine();
                        Console.WriteLine("Digite o Endereço do titular: ");
                        string address = Console.ReadLine();
                        Console.WriteLine("Digite a data de nascimento do titular: ");
                        DateTime birthDate = DateTime.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o número do cartão: ");
                        int cardNumber = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o PIN: ");
                        int pin = int.Parse(Console.ReadLine());

                        // Criar o cliente
                        Customer customer = new Customer(name, address, birthDate, cardNumber, pin);

                        // Criar a conta (corrente ou poupança)
                        Account newAccount;
                        if (option == 1)
                        {
                            newAccount = new CurrentAccount(Random.Shared.Next(0, 9999), 0, customer);
                        }
                        else
                        {
                            newAccount = new SavingAccount(Random.Shared.Next(0, 9999), 0, customer);
                        }

                        // Adicionar a Conta ao Banco
                        bank.AddAccount(newAccount);
                        Console.WriteLine("Conta criada com sucesso.");

                        // Fazer Login
                        PerformLogin();
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Erro de formato: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Erro ao criar conta: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Tente novamente.");
            }
            Console.ReadLine();
        }

        static void PerformLogin()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("       FAZER LOGIN               ");
            Console.WriteLine("=================================");
            Console.Write("Digite o número do seu cartão: ");
            int cardNumber = int.Parse(Console.ReadLine());

            Console.Write("Digite seu PIN: ");
            int pin = int.Parse(Console.ReadLine());

            // Verificar se o cliente existe
            Customer customer = bank.Accounts.Find(acc => acc.Customer.CardNumber == cardNumber)?.Customer;
            if (customer != null)
            {
                try
                {
                    customer.VerifyPassword(pin); // Verifica o PIN
                    currentCustomer = customer;
                    currentAccount = bank.Accounts.Find(acc => acc.Customer == currentCustomer);
                    ShowAccountMenu();
                }
                catch (InvalidPinException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
                Console.ReadLine();
            }
        }

        static void ShowAccountMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("=================================");
                Console.WriteLine($"        MENU DA CONTA: {currentCustomer.Name} ");
                Console.WriteLine("=================================");
                Console.WriteLine("1. Consultar Saldo");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Sacar");
                Console.WriteLine("4. Exibir Histórico de Transações");
                Console.WriteLine("5. Sair");
                Console.WriteLine("=================================");
                Console.Write("Escolha uma opção: ");

                int option;
                if (int.TryParse(Console.ReadLine(), out option))
                {
                    switch (option)
                    {
                        case 1:
                            ShowBalance();
                            break;
                        case 2:
                            PerformDeposit();
                            break;
                        case 3:
                            PerformWithdrawal();
                            break;
                        case 4:
                            ShowTransactionHistory();
                            break;
                        case 5:
                            Console.WriteLine("Saindo da conta...");
                            return;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Tente novamente.");
                }
            }
        }

        static void ShowBalance()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("       CONSULTAR SALDO          ");
            Console.WriteLine("=================================");
            Console.WriteLine($"Seu saldo atual é: {currentAccount.Balance:C2}");
            Console.ReadLine();
        }

        static void PerformDeposit()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("       DEPOSITAR DINHEIRO       ");
            Console.WriteLine("=================================");
            Console.Write("Digite o valor a ser depositado: ");
            double amount = double.Parse(Console.ReadLine());

            try
            {
                currentAccount.Deposit(amount);
            }
            catch (InvalidDepositAmountException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static void PerformWithdrawal()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("       SACAR DINHEIRO           ");
            Console.WriteLine("=================================");
            Console.Write("Digite o valor a ser sacado: ");
            double amount = double.Parse(Console.ReadLine());

            try
            {
                currentAccount.Withdraw(amount);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }

        static void ShowTransactionHistory()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("     HISTÓRICO DE TRANSAÇÕES    ");
            Console.WriteLine("=================================");
            currentAccount.ShowTransactionHistory();
            Console.ReadLine();
        }
    }
}
