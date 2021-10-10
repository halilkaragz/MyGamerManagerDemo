using MyGamerManagerDemo.Abstract;
using MyGamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Concrete
{
    class CustomerManager:BaseCustomerManager
    {
        IPersonCheckService _personCheckService;

        public CustomerManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_personCheckService.CheckIfRealPerson(customer))
            {
              base.Save(customer);
            }
            else
            {
                throw new Exception("Geçerli bir kişi değil");
            }

            
        }
        public override void Update(Customer customer)
        {            
            if (_personCheckService.CheckIfRealPerson(customer))
            {
                base.Update(customer);
            }
            else
            {
                throw new Exception("Geçerli bir kişi değil");
            }
        }
    }
}
