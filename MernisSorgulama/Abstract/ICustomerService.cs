using MernisSorgulama.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisSorgulama.Abstract
{
  public  interface ICustomerService
    {
        void Save(Customer customer);
    }
}
