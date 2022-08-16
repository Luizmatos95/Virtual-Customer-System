using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_System
{
    class DisplayAllCustomers
    {
        public static void retrieveAllCustomers()
        {
            // Foreach loop to iterate throw the DB
            foreach (DictionaryEntry entry in Database.customer_DB)
            {
                Console.WriteLine(entry.Key + " " + entry.Value);
            }
        }
    }
}
