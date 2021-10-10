using MyGamerManagerDemo.Abstract;
using MyGamerManagerDemo.Concrete;
using MyGamerManagerDemo.Entities;
using System;
using System.Collections.Generic;

namespace MyGamerManagerDemo
{
    class Program
    {
        static void Main(string[] args)
        {              
            Game game = new Game { Id = 1, Name = "lotr", Price = 200 };
        
            List<Game> listgame = new List<Game>();
            listgame.Add(game);

            Customer c1 = new Customer
            {
                Id = 1,
                FirstName = "Halil",
                LastName = "Karagöz",
                NationalityID = "12345678901",
                DateOfBirth = new DateTime(1987, 11, 25),
                Games = listgame
            };

            BaseCustomerManager customermanager = new CustomerManager(new PersonCheckManager());
            //customermanager.Save(c1);
            //Console.WriteLine(c1.NationalityID);          
            //customermanager.Update(c1);
            //customermanager.Delete(c1);
            //Console.ReadLine();

            GameManager gameManager = new GameManager();

            gameManager.Sell(new Game { Id = 2, Name = "gta 5", Price = 50 }, c1);

            foreach (var item in c1.Games)
            {
                Console.WriteLine(item.Name);
            }

            Campaign campaign = new Campaign { Id = 1, IndirimOrani = 50, Name = "ilk kampanya", DahilOyunlar = listgame };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.GamePriceUpdate(campaign);

            campaignManager.Update(campaign);
            campaignManager.Delete(campaign);

            foreach (var item in listgame)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }




        }
    }
}
