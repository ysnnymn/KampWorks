using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public abstract class BaseGamerManager : IGamerService
    {
        public virtual void Add(Gamer gamer)
        {

            Console.WriteLine("Kullanıcı Kaydedildi : " + gamer.FirstName);
        }

       
    }
}
