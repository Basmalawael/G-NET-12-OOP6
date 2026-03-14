using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP6.NewFolder
{
    internal class IMAXTicket : Ticket
    {
        public bool Is3D { get; set; }

        public IMAXTicket(int id, string movie, decimal price, bool is3D) :base(id, movie, price)
        {
            Is3D = is3D;
        }

        public override decimal CalculateFinalPrice()
        {
            return PriceAfterTax;

        }

        public override void PrintTicket()
        {
    Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | IMAX | 3D: {(Is3D ? "Yes" : "No")} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");

        }
    }
}
