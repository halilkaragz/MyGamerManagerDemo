using MyGamerManagerDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Abstract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
