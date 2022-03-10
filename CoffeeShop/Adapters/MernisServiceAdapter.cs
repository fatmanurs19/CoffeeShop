﻿using CoffeeShop.Abstract;
using CoffeeShop.Entities;
using CoffeeShop.MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(customer.NationalityId,customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(),customer.DateOfBirth.Year);
        }
    }
}
