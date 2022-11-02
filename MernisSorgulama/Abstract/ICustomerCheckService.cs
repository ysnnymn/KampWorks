using MernisSorgulama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisSorgulama.Abstract
{
  public  interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
