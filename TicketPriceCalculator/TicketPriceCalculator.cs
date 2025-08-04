using System;
 
 namespace TicketPriceCalculator
 {
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==Ticket Price Calculator==");
            Console.WriteLine("Enter age");

            string input = Console.ReadLine();
            int age;

            if (!int.TryParse(input, out age))
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
                return;
            }
            if (age <0)
            {
                Console.WriteLine("Age cannot be negative.");
                return;
            }

            decimal ticketPrice;
            string customerType;

            if (age <= 12 )
            {
                ticketPrice = 7.0m;
                customerType ="Child";
            }
            else if (age >=65)
            {
                ticketPrice = 7.0m;
                customerType = "Senior citizen";
            }
            else 
            {
                ticketPrice = 10.0m;
                customerType = "Adult";
            }

            Console.WriteLine($"\nAge: {age}");
            Console.WriteLine($"Customer Type: {customerType}");
            Console.WriteLine($"Ticket price: {ticketPrice}");

            Console.WriteLine("\nThank you for using the Ticket Price Calculator!\nPress any key to exit ");
            Console.ReadKey();

            
        }
    }
 }