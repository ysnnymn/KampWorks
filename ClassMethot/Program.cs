using System;
using System.Collections.Generic;

namespace ClassMethot
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Yasin";
            customer1.LastName = "Yaman";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.FirstName = "Cinar";
            customer2.LastName = "Yaman";

            List<Customer> customers = new List<Customer>() { customer1,customer2};
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Delete(customer2);
            customerManager.Update(customer1);

            customerManager.List(customers);
        }
    }
}
