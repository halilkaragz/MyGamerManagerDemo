using MyGamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerManager
    {
        public void Delete(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı kullanıcı silindi.");
        }

        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı kullanıcı kaydedildi.");
        }

        public virtual void Update(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " adlı kullanıcı güncellendi.");
        }
    }
}
