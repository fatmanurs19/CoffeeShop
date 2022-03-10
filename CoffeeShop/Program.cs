using CoffeeShop.Abstract;
using CoffeeShop.Adapters;
using CoffeeShop.Concrete;
using CoffeeShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop
{
     class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985), FirstName = "Engin", LastName = "Demiroğ", NationalityId = 12345678987 });
            Console.ReadLine();
        }
    }   
    
}
