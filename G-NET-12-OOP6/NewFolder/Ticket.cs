using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP6.NewFolder
{
    public abstract class Ticket
    {


        public int TicketId { get; set; }
        public string MovieName { get; set; }
        public decimal Price { get; set; }
        public bool IsBooked { get; set; }

        public decimal PriceAfterTax => Price * 1.14m;

        //Ctor
        protected Ticket(int ticketId, string movieName ,decimal price)
        {
            TicketId = ticketId;
            MovieName = movieName;
            Price = price;
        }

        //----------------------------------
        public abstract decimal CalculateFinalPrice();

        public abstract void PrintTicket();

        public void PrintInfo()
        {
            string status = IsBooked ? "Yes" : "No";
           
        }
        
        //------------------------------------------

        //Method 
        public void SetPrice(decimal price)
        {
            Price = price;
        }

        public void SetPrice(decimal baseprice, decimal multiplier)
        {
            Price = baseprice * multiplier;
        }

        //----------------------------------------
       
        public void Book()
        {
            if (IsBooked) throw new Exception("Already booked..!");
            IsBooked = true;
        }

        public void Cancel()
        {
            if (!IsBooked) throw new Exception("Not booked..!");
            IsBooked = false;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
