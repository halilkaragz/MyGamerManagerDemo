using MyGamerManagerDemo.Abstract;
using MyGamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Concrete
{
    class PersonCheckManager : IPersonCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
