using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Customer_System
{

    public class Program
    {
        static void Main(string[] args)
        {
            displayandSelect();
        }

        // A method to prompt the user the menu options 
        static void displayandSelect()
        {
            int selection;
            Console.WriteLine("Welcome to Virtual Customer System");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadKey();

            // Prompting the user the selection menu
            Console.WriteLine("1.Add a new customer");
            Console.WriteLine("2.Load a customer");
            Console.WriteLine("3.Delete a customer");
            Console.WriteLine("4.Display all Customers stored");
            Console.WriteLine("5.Exit the V.C.S");

            do
            {
                // Selection Switch Statement 
                Console.Write("Enter a selection: ");
                selection = Convert.ToInt32(Console.ReadLine());
                switch (selection)
                {
                    case 1:
                        NewCustomer.addCustomer();
                        break;
                    case 2:
                        ExistingCustomer.loadcustomer();
                        break;
                    case 3:
                        RemovingCustomer.removecustomer();
                        break;
                    case 4:
                        DisplayAllCustomers.retrieveAllCustomers();
                        break;
                    case 5:
                        Console.WriteLine("Thanking you for using the Virtual Customer System...");
                        break;
                }
            }
            while (selection != 5);

        }

    }
}
