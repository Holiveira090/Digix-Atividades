using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula_24_OO_excecao;

namespace Aula_24_OO_excecao
{
    public class Reservation3
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Reservation3(int roomNumber, DateTime checkin, DateTime checkout)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
            DateTime now = DateTime.Now;
            if (checkin < DateTime.Now && checkout < DateTime.Now)
            {
                throw new DomainException("Erro na reserva: as datas para reserva devem ser futuras"); // throw serve para lançar uma exceção "Erro na reserva: as datas para reserva devem ser futuras";
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Erro na reserva: a data de checkout deve ser posterior a data de checkin");
            }

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
            DateTime now = DateTime.Now;
            if (checkin < DateTime.Now && checkout < DateTime.Now)
            {
                throw new DomainException("Erro na reserva: as datas para reserva devem ser futuras"); // throw serve para lançar uma exceção "Erro na reserva: as datas para reserva devem ser futuras";
            }
            if (checkout <= checkin)
            {
                throw new DomainException("Erro na reserva: a data de checkout deve ser posterior a data de checkin");
            }

            Checkin = checkin;    
            Checkout = checkout;
            
        }
        public override string ToString()
        {
            return $"Room {RoomNumber}, check-in: {Checkin}, check-out: {Checkout}, {duration()} nights";
        }
    }
}