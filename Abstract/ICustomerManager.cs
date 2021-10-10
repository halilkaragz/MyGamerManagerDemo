using MyGamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Abstract
{
    interface ICustomerManager
    {
        void Save(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
