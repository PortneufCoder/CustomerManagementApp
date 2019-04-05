using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityCM.BL
{
    public class CustomerRepository
    {
        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }
            return customer;
        }
        // Saves the current customer
        public bool Save(Customer customer)
        {
            return true;
        }
    }
    
}
