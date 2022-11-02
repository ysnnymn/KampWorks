using MernisSorgulama.Abstract;
using MernisSorgulama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisSorgulama.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
            
        }
    }
}
