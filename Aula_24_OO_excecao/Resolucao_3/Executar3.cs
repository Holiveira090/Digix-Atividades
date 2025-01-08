using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_excecao
{
    public class Executar3
    {
        public static void Exe(string[] args)
        {
            try
            {


                System.Console.WriteLine("Entre com os dados Room Number:");
                int numRoom = int.Parse(Console.ReadLine());

                System.Console.WriteLine("Entre com a data de check-in: (dd/MM//yyyy)");
                DateTime checkin = DateTime.Parse(Console.ReadLine());

                System.Console.WriteLine("Entre com a data de check-out: (dd/MM//yyyy)");
                DateTime checkout = DateTime.Parse(Console.ReadLine());

                Reservation3 reservation3 = new Reservation3(numRoom, checkin, checkout);
                System.Console.WriteLine($"Reserva {reservation3}");

                System.Console.WriteLine("Escreva os dados para atualizar a reserva: (dd/MM//yyyy)");
                System.Console.WriteLine("Entre com a data de check-in: (dd/MM//yyyy)");
                checkin = DateTime.Parse(Console.ReadLine());

                System.Console.WriteLine("Entre com a data de check-out: (dd/MM//yyyy)");
                checkout = DateTime.Parse(Console.ReadLine());

                reservation3.UpdateDates(checkin, checkout);
                System.Console.WriteLine($"Reserva atualizada: {reservation3}");
            }
            catch (DomainException e)
            {
                System.Console.WriteLine($"Erro inesperado: {e.Message}");
            }


        }
    }
}