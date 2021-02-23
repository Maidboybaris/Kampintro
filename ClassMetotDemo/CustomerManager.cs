using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Id +"  " +customer.Name +"  " +customer.SurName +"  " +  "Müşteri eklendi.");
        }
        public void ListCustomer(Customer customers)
        {
            Customer[] listCustomers = new Customer[]
            {
                customers
            };
        }
    }
}
