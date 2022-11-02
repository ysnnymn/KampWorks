using MernisSorgulama.Abstract;
using MernisSorgulama.Adapters;
using MernisSorgulama.Concrete;
using MernisSorgulama.Entities;
using System;

namespace MernisSorgulama
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer 
            { DateOfBirth=new DateTime(2000,10,1),FirstName="Yasin",LastName="Yaman",Id=1,NatioanlityId="427638698"});

        }
    }
}
