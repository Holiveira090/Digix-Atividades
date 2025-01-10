using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atividade_09_01
{
    public class Customer
    {
        public string Name { get; private set; }
        public string Address { get; private set; }
        public DateTime Dob { get; private set; }
        public int CardNumber { get; private set; }
        public int Pin { get; private set; }

        public Customer(string name, string address, DateTime dob, int cardNumber, int pin)
        {
            Name = name;
            Address = address;
            Dob = dob;
            CardNumber = cardNumber;
            Pin = pin;
        }

        public void VerifyPassword(int pin)
        {
            if (Pin != pin)
            {
                throw new InvalidPinException("Senha incorreta. Tente novamente.");
            }
            else
            {
                Console.WriteLine("Login bem-sucedido!");
            }
        }
    }

}