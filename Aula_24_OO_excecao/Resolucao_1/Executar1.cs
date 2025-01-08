using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_excecao
{
    public class Executar1
    {
        // public static void Main(string[] args) 
        public static void Exe(string[] args) 
        {
            System.Console.WriteLine("Entre com os dados Room Number");
            int numRoom = int.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com a data de check-in (dd/MM//yyyy)");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            System.Console.WriteLine("Entre com a data de check-out (dd/MM//yyyy)");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            if (checkin < DateTime.Now || checkout < DateTime.Now)
            {
                System.Console.WriteLine("Erro na reserva: as datas para reserva devem ser futuras");
            }
            else if (checkout <= checkin)
            {
                System.Console.WriteLine("Erro na reserva: a data de checkout deve ser posterior a data de checkin");
            }
            else
            {
                Reservation reserva = new Reservation(numRoom, checkin, checkout);
                System.Console.WriteLine(reserva.ToString());
            }
        }
    }
}