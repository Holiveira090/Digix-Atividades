using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_excecao
{
    public class Reservation2
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation2(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }
        public int duration()
        {
            TimeSpan timeSpan = Checkout.Subtract(Checkin); // Substract serve para subtrair datas
            return (int)timeSpan.TotalDays; // TotalDays serve para pegar o total de dias
        }
        public string UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < DateTime.Now && checkout < DateTime.Now)
            {
                return "Erro na reserva: as datas para reserva devem ser futuras";
            }
            if (checkout <= checkin)
            {
                return "Erro na reserva: a data de checkout deve ser posterior a data de checkin";
            }

            Checkin = checkin;    
            Checkout = checkout;
            return null;
            
        }
        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {Checkin}, check-out: {Checkout}, {duration()} nights";
        }
    }
}