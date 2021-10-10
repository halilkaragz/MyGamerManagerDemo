using MyGamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Abstract
{
    public interface IGameManager
    {
        void Sell(Game game, Customer customer);
    }
}
