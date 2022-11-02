using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Adapters
{
    public class MernisService : IGamerCheckService
    {
        public bool CheckIfRealPerson(Gamer gamer)
        {
            return gamer.FirstName =="Yasin";

            
        }
    }
}
