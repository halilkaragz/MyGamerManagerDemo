using MyGamerManagerDemo.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyGamerManagerDemo.Entities
{
    public class Customer:ICustomer
    {        
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalityID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public List<Game> Games { get; set; }
    }
}
