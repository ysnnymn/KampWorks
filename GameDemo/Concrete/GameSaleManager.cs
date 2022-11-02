using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class GameSaleManager : IGameSalesService
    {
        public void CompanySales(Company company, Game game, Gamer gamer)
        {
            double campagin = (game.GameUnitPrice - (company.DiscountRate * game.GameUnitPrice) / 100);

            Console.WriteLine(game.GameName +" Oyunu , "+gamer.FirstName 
                +" Adlı Kişiye "+
                company.CompanyName + " Kampanyası İle " +
                
             
              campagin +" Liradan Satıldı");
        }

        public void Sales(Gamer gamer, Game game)
        {
          
            
        }
    }
}
