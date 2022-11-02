using MernisSorgulama.Abstract;
using MernisSorgulama.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Text;

namespace MernisSorgulama.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync
                (Convert.ToInt64(customer.NatioanlityId) ,customer.FirstName.ToUpper()
                ,customer.LastName.ToUpper(),customer.DateOfBirth.AddYears
                );
               
        }
    }
}
