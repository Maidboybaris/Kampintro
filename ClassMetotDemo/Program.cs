using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customerr1 = new Customer();
            customerr1.Id = 1065215606;
            customerr1.Name = "Hasan";
            customerr1.SurName = "Karademir";

            Customer customerr2 = new Customer();
            customerr2.Id = 454745874;
            customerr2.Name = "Zeynep";
            customerr2.SurName = "Gümüş";

            CustomerManager customermanager = new CustomerManager();
            customermanager.AddCustomer(customerr1);
            customermanager.AddCustomer(customerr2);

            Console.WriteLine("Müşteriler");

            Customer[] ListCustomers = new Customer[] {customerr1,customerr2 };
            foreach (Customer customers in ListCustomers)
            {
                
                Console.WriteLine("Müşteri ID:"   +  customers.Id);
                Console.WriteLine("Müşteri Adı:"   +  customers.Name);
                Console.WriteLine("Müşteri Soyadı:"   +  customers.SurName);
            }

        }
    }
}
