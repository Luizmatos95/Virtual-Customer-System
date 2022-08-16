using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// A class that takes in new customer information

namespace Customer_System
{
    public class NewCustomer
    {
        public string first, last;
        public double amt;
        public NewCustomer(string firstName, string lastName, double amount)
        {
            first = firstName;
            last = lastName;
            amt = amount;
        }

        // A method to retrieve the customers information
        public static void addCustomer()
        {
            

            Console.Write("Enter customers PIN: ");
            int pin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Enter customers first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter customers last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine();

            Console.Write("Enter customers dollar amount: $");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("The Customer information you entered: PIN Number: {0} Full Name: {1} {2} Total account amount: ${3}.", pin, firstName, lastName, amount);

            // New customer variable to pass into method
            NewCustomer Customer = new NewCustomer(firstName, lastName, amount);

            // Parsing the customers information to the DB
            Database.customer_DB.Add(pin, Customer.first + " " + Customer.last + " " + Convert.ToString(Customer.amt));

            // Prompting user if they want enter another user 
            Console.WriteLine("Do you want to enter another customer? (Yes Or No)");
            string yes = "Yes";
            string answer = Console.ReadLine();
            if (answer.Equals(yes, StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                addCustomer();
            }
            else
            {
                // Prompting the user the selection menu
                Console.WriteLine("1.Add a new customer");
                Console.WriteLine("2.Load a customer");
                Console.WriteLine("3.Delete a customer");
                Console.WriteLine("4.Display all Customers stored");
                Console.WriteLine("5.Exit the V.C.S");
                // Do nothing and return to menu

            }
        }

    }

}

