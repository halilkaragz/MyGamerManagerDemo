using MyGamerManagerDemo.Entities;
using System;
using System.Text;

namespace MyGamerManagerDemo.Abstract
{
    public interface ICampaignManager
    {
        void GamePriceUpdate(Campaign campaign);
        void Add(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
