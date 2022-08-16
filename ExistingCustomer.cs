using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_System
{
    class ExistingCustomer
    {

        //A method that loads in the customers data 
        public static void loadcustomer()
        {
            Console.Write("Enter the Customer's PIN number: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            retrieveCustomerData(pin);

        }

        //A method to retrieve customer data
        public static void retrieveCustomerData(int pin)
        {
            // Foreach loop to iterate throw the DB
            foreach (DictionaryEntry entry in Database.customer_DB)
            {

                if (Convert.ToInt32(entry.Key) == pin) 
                {
                    Console.WriteLine(entry.Key + " " + entry.Value);
                }
            
            }
        }

    }
}
