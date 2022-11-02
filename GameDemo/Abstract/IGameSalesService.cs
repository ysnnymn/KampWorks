using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
  public  interface IGameSalesService
    {
        void Sales(Gamer gamer, Game game);
        void CompanySales(Company company, Game game, Gamer gamer);
    }
}
