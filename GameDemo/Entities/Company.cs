using GameDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Entities
{
  public  class Company:IEntity
    {
        public string CompanyName { get; set; }
        public double DiscountRate { get; set; }

    }
}
