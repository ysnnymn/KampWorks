using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethot
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Musteri Eklendi:"+customer.FirstName);
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Musteri Silindi:" + customer.FirstName);
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Musteri Guncellendi:" + customer.FirstName);
        }
        public void List( List<Customer> customer)
        {
            foreach (var item in customer)
            {
                Console.WriteLine("Musteriler:"+item.FirstName);
            }
        }
    }
}
