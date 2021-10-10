using MyGamerManagerDemo.Abstract;
using MyGamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Concrete
{
    class GameManager : IGameManager
    {
        public void Sell(Game game, Customer customer)
        {
            customer.Games.Add(game);
            Console.WriteLine(customer.FirstName + " adlı oyuncuya " + 
                game.Name + " adlı oyun satıldı.");
        }
    }
}
