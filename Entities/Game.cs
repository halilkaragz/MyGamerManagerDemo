using MyGamerManagerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Entities
{
    public class Game : IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

}