using MyGamerManagerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Entities
{
    public class Campaign:ICampaign
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal IndirimOrani { get; set; }
        public List<Game> DahilOyunlar { get; set; }
    }
}
