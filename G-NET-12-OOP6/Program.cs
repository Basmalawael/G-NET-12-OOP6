using G_NET_12_OOP6.NewFolder;

namespace G_NET_12_OOP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 : Theoretical Questions

            #region Q1:

            /* Q1 : What is abstraction in OOP?
             * How is it different from encapsulation? 
             * Give a real-world example (not from the session) that shows
             * the difference between the two.
             * 
             * ---------------------------------------------------------------------
             * 
             * Abstraction is the process of hiding complex implementation 
             * details and showing only the necessary features of an object. 
             * It focuses on "what" an object does instead of "how" it does it.
             * 
             * --------------------------------------------------------------------
             * 
             * Abstraction hides complexity at the design level using interfaces 
             * or abstract classes.
             * 
             * while Encapsulation hides data and internal state within a class using
             * access modifiers (like private) to protect it.
             * 
             * ---------------------------------------------------------------------
             * 
             * (Real-world Example):
             * The Coffee Machine :
             * 
             * Abstraction: You only see the buttons (On/Off, Select Coffee). 
             * You don't need to know how the machine heats water or grinds beans
             * to get your drink. (Focus on Functionality).
             * 
             * Encapsulation: All the internal wires, water tank, and heating elements
             * are hidden inside the plastic cover. You cannot touch them directly; 
             * they are protected for safety. (Focus on Protection/Grouping).
             * 
             */
            #endregion

            #region Q2: 

            /* What is the difference between an abstract class and an interface? 
             * Give at least four differences. 
             * When would you choose one over the other?
             * 
             * 1- Multiple Inheritance :
             * 
             * Abstract Class : A class can inherit from only one abstract class.
             * Interface      : A class can implement multiple interfaces.
             * ----------------------------------------------------
             * 
             * 2- Members :
             * 
             * Abstract Class :Can have fields (variables), constructors, and methods.
             * Interface     :Can only have method signatures (and properties/events).
             * 
             * ----------------------------------------------------
             * 
             * 3- Implementation : 
             * 
             * Abstract Class : Can have both abstract methods and concrete (full) methods.
             * Interface      : Traditionally only contains abstract methods (no body). 
             * 
             * ---------------------------------------------------
             * 
             * 4- Access Modifiers :
             * 
             * Abstract Class : Can use any access modifier (private, protected, etc.).
             * Interface      : All members are implicitly public.
             * 
             * -------------------------------------------------
             * 
             * Use an Abstract Class when you want to share code among closely 
             * related classes (is-a relationship).
             * 
             * Use an Interface when you want to define a common behavior for
             * unrelated classes (can-do relationship).
             * 
             * 
            */
            #endregion

            #region Q3:
            /* 
             * a) Can you write: Appliance a = new Appliance("LG"); ? Why or why not?
             * 
             * No, you cannot.
             * Reason: Because Appliance is an abstract class. 
             * Abstract classes are incomplete blueprints and cannot be instantiated 
             * directly (you cannot create an object from them). 
             * They are meant only to be inherited by other classes.
             * 
             * -----------------------------------------------------
             * 
             * b) What is the difference between the three methods: 
             * PowerConsumption(),
             * Status(),
             * and Label()?
             * Why did the designer make each one abstract, virtual, or concrete?
             * 
             * 1-PowerConsumption() : Abstract : 
             * To force every appliance to provide its own calculation,
             * as there is no "default" consumption for all appliances.
             * 
             * Status() : Virtual : 
             * To provide a default behavior ("Standby") while allowing specific appliances
             * (like WashingMachine) to change it if needed.
             * 
             * Label() : Concrete :
             * To provide a fixed behavior that is shared by all appliances. 
             * It shouldn't be changed because the format is the same for everyone.
             * 
             * ---------------------------------
             * 
             * Abstract:  (Must implement).
             * Virtual: اختيار (Can override).
             * Concrete: مشاركة (Use as is).
             * --------------------------------
             * 
             * c) If you call Status() on a Toaster object, what will it return? Why?
             * 
             * It will return: "Standby"
             * Reason: Because the Toaster class did not override the Status() method.
             * Therefore, it inherits and uses the default implementation defined in 
             * the base Appliance class.
             * 
             */

            #endregion

            #region Q4:
            /* 
             * a) What is a partial class? Why would a developer split Calculator into two files?
             * 
             * Partial Class: A feature that allows a single class to be defined across 
             * multiple files. The compiler combines them into one class during compilation.
             * 
             * Why split it?
             * 
             * 1. Organization: To separate different concerns (e.g., core logic in one file and 
             *                                                  logging/UI in another).
             *                                                  
             * 2. Collaboration: To allow multiple developers to work on the same class 
             * simultaneously without merge conflicts.
             * 
             * 3. Code Generation: To separate human-written code from automatically generated code 
             * (like in Windows Forms or EF).
             * 
             * b) What is a partial method? What happens if the OnCalculated() implementation in Calculator
             * .Logging.cs is deleted — will the code still compile? Why?
             * 
             * Partial Method: It is a method defined in one part of a partial class (as a signature)
             * and optionally implemented in another part.
             * 
             * If the implementation is deleted: Yes, the code will still compile.
             * 
             * Why? 
             * Because if a partial method has no implementation, the compiler removes the method signature 
             * and all calls to it during compilation. It’s as if the line OnCalculated(LastResult); 
             * never existed.
             * 
             * c) What is an extension method? What are the three rules for writing one?
             * 
             * Extension Method: A static method that allows you to "add" new methods to 
             * existing types without modifying the original code or using inheritance.
             * 
             * The Three Rules:
             * The method must be defined inside a static class.
             * The method itself must be static.
             * The first parameter must use the this keyword followed by the type it is extending.
             * 
             * d) What will the following code print?
             * 
             * Calculator calc = new Calculator();
             * double result = calc.Add(19.5, 0.5);
             * Console.WriteLine(result.ToCurrency());
             * 
             * Log: result = 20
             * $20.00
             * 
             * First, the Add method calls OnCalculated, which executes the code in 
             * the partial class (File: Calculator.Logging.cs) and prints the "Log" message.
             * 
             * Then, result.ToCurrency() uses the extension method to format the number 20.0 
             * into a currency string with two decimal places and a dollar sign.
             * 
             * 
            */
            #endregion
            #endregion


            #region Part 02 : Practical (Extending the Movie Ticket Booking System)
            /* 
            Console.WriteLine("=== Cinema Opened  ===");
            Console.WriteLine(" Projector ON\n");
            Console.WriteLine("// Ticket t = new Ticket( Test, 100) ;// ERROR: Cannot create instance of abstract type 'Ticket' ");
            Console.WriteLine();

            // a. إنشاء تذاكر بأنواع مختلفة
            Cinema C = new Cinema();
            StandardTicket s1 = new StandardTicket(101, "Inception", "A5", 80);
            VIPTicket v1 = new VIPTicket(102, "Avengers", 200, true, 50);
            IMAXTicket i1 = new IMAXTicket(103, "Dune", 130, true);

            // c. إنشاء السينما وإضافة التذاكر (Partial Class)

            C.AddTicket(s1);
            C.AddTicket(v1);
            C.AddTicket(i1);

            // حجز التذاكر
            C.BookTicket(101);
            C.BookTicket(102);
            C.BookTicket(103);




            // d. طباعة كل التذاكر (Reporting Partial File)
            C.PrintAllTicket();

            // . عرض الـ Polymorphism(نادينا CalculateFinalPrice لكل نوع)
            Console.WriteLine("\n --- Polymorphism: Final Price per Ticket ---");
            Console.WriteLine($" StandardTicket => Final Price: {s1.CalculateFinalPrice():F2}");
            Console.WriteLine($" VIPTicket      => Final Price: {v1.CalculateFinalPrice():F2}");
            Console.WriteLine($" IMAXTicket     => Final Price: {i1.CalculateFinalPrice():F2}");

            //  e. استخدام الـ Extension Method لطباعة إيصال
            Console.WriteLine("\n--- Extension Method: Receipt ---");
            Console.WriteLine(v1.ToReceipt());

            // استخدام الـ Extension Method: TotalRevenue
            Console.WriteLine("\n --- Extension Method: Total Revenue");
            C.ShowStatistics();

            Console.WriteLine("\n Projector OFF");
            Console.WriteLine("\n=== Cinema Closed ===");

        
        */
            #endregion



        }
    }


    #region TicketExtensions
    /*
    public static class TicketExtensions
    {
        public static string ToReceipt(this Ticket ticket)
        {
            return $@"
========== RECEIPT ==========
Movie     : {ticket.MovieName}
Type      : {ticket.GetType().Name}
Price     : {ticket.Price}
Final     : {ticket.CalculateFinalPrice():F2}
Status    : {(ticket.IsBooked ? "Booked" : "Not Booked")}
==============================";
        }
        public static decimal TotalRevenue(this List<Ticket> ticketlist)
        {
            decimal total = 0;
            foreach (var t in ticketlist)
            {
                if (t.IsBooked)
                {
                    total += t.CalculateFinalPrice();

                }
            }

            return total;

        }
    }
    */
        #endregion

    
}


