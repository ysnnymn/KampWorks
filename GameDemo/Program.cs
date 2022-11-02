using GameDemo.Adapters;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer() { FirstName = "Yasin", LastName = "Yaman" };
            Game game = new Game() { GameUnitPrice = 100, GameName = "Pubg" };
            Company company = new Company() { CompanyName = "Yılbasşı", DiscountRate = 10 };

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.CompanySales(company, game, gamer);
            BaseGamerManager gamerManager = new GamerManager(new MernisService());
            gamerManager.Add(gamer);
        }
    }
}
