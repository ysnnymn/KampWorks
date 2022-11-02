using MernisSorgulama.Abstract;
using System;

namespace MernisSorgulama.Entities
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NatioanlityId { get; set; }

    }
}
