using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CompanyManager : ICompanyService
    {
        public void Add(Company company)
        {
            Console.WriteLine("Kampanya Eklendi : "+company.CompanyName);
        }
    }
}
