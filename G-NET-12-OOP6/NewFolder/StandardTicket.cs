using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP6.NewFolder
{
    internal class StandardTicket : Ticket
    {

        public string SeatNumber { get; set; }

        public StandardTicket(int id, string movie, string seat, decimal price) : base(id, movie, price)
        {
            SeatNumber = seat;
        }

        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax;
        }

        public override void PrintTicket()
        {
  Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | Standard | Seat : {SeatNumber} | Price : {Price} | Final : {CalculateFinalPrice():F2} | Booked : {(IsBooked ? "Yes"  : "No")} ");
        }
    }
}
