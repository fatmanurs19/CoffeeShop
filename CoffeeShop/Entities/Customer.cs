using CoffeeShop.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entities
{
    public class Customer :IEntities
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set;}
        public DateTime DateOfBirth { get; set; }
        public long NationalityId { get; set; }
    }
}
