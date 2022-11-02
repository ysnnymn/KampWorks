using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game gameSale)
        {
            Console.WriteLine("Oyun Eklendi:"+gameSale.GameName);
        }
    }
}
