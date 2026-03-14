using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_12_OOP6.NewFolder
{
    //This file is responsible for displaying data and reports.
    public partial class Cinema
    {
        //Concrete Method 
        public void PrintAllTicket()
        {
            Console.WriteLine("---All Tickets(from Cinema.Reporting)---");

            foreach (var t in tickets)
            {
                t.PrintInfo();
      
                t.PrintTicket();
            }
        }

        //Concrete Method.    وظيفتها حسابات : زي إجمالي الإيرادات
        public void ShowStatistics()
            {

            decimal total = 0;

            foreach (var t in tickets)
            {
                total += t.CalculateFinalPrice();
            }

            Console.WriteLine($"\nTotal Revenue : {total:F2}");
        }


        
    }
}
