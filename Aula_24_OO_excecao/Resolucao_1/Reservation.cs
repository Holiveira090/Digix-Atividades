using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aula_24_OO_excecao
{
    public class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation(int roomNumber, DateTime checkin, DateTime checkout)
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
        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            Checkin = checkin;
            Checkout = checkout;
        }
        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {Checkin}, check-out: {Checkout}, {duration()} nights";
        }
    }
}