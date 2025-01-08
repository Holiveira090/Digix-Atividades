using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_excecao.Resolucao_2
{
    public class Executar2
    {

        public static void Exe(string[] args)
        {
            System.Console.WriteLine("Entre com os dados Room Number:");
            int numRoom = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com a data de check-in: (dd/MM//yyyy)");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com a data de check-out: (dd/MM//yyyy)");
             DateTime checkout = DateTime.Parse(Console.ReadLine());

            Reservation2 reservation2 = new Reservation2(numRoom, checkin, checkout);

            string error = reservation2.UpdateDates(checkin, checkout);
            if (error != null)
            {
                System.Console.WriteLine(error);
            }
            else
            {
                System.Console.WriteLine($"Reserva: {reservation2}");
            }

        }
    }
}