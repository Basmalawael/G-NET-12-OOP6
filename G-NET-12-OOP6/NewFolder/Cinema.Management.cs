using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP6.NewFolder
{
    public partial class Cinema
    {
        private List<Ticket> tickets = new List<Ticket>();
        //Concrete Method 
        // Take Ticket Give List //
        public void AddTicket(Ticket t) 
        { 
            tickets.Add(t);
        }
        public void BookTicket(int id)
        {
            var ticket = tickets.Find(t => t.TicketId == id);
            if (ticket != null) 
            {
                ticket.Book();
             
            }
         

        }
    }
}
