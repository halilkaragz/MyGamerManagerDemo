using MyGamerManagerDemo.Abstract;
using MyGamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Concrete
{
    class CampaignManager : ICampaignManager
    {
        public void GamePriceUpdate(Campaign campaign)
        {
            foreach (var item in campaign.DahilOyunlar)
            {
                item.Price = item.Price * (1 - campaign.IndirimOrani / 100);
            }
        }
        public void Add(Campaign campaign)
        {
            Console.WriteLine("kampanya oluşturuldu.");            
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("kampanya silindi.");            
        }       

        public void Update(Campaign campaign)
        {
            Console.WriteLine("kampanya güncelledi.");            
        }
    }
}
