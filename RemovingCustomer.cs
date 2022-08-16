using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_System
{
    class RemovingCustomer
    {
        //A method that removes customer in the DB 
        public static void removecustomer()
        {
            Console.Write("Enter the Customer's PIN number: ");
            int pin = Convert.ToInt32(Console.ReadLine());

            retrieveCustomerData(pin);

        }

        //A method to retrieve and delete customer data
        public static void retrieveCustomerData(int pin)
        {
            // Foreach loop to iterate throw the DB
            foreach (DictionaryEntry entry in Database.customer_DB)
            {

                if (Convert.ToInt32(entry.Key) == pin)
                {

                    Database.customer_DB.Remove(entry.Key);
                    Database.customer_DB.Remove(entry.Value);
                }
            }
        }
    }
}
