using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP6.NewFolder
{
    internal class VIPTicket : Ticket
    {
        public bool LoungeAccess { get; set; }
        public decimal ServiceFee { get; set; }

        public VIPTicket(int id, string movie, decimal price, bool lounge, decimal servicefee)
                         : base(id, movie, price)
        {
            LoungeAccess = lounge;
            ServiceFee = servicefee;
        }

        public override decimal CalculateFinalPrice()
        {
            return (Price + ServiceFee) * 1.14m;
        }

        public override void PrintTicket()
        {
       Console.WriteLine($"[Ticket #{TicketId}] {MovieName} | VIP | Lounge: {(LoungeAccess ? "Yes" : "No")} | Fee: {ServiceFee} | Price: {Price} | After Tax: {PriceAfterTax} | Booked: {(IsBooked ? "Yes" : "No")}");
        }
    }
}
