using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using demoFirstApp.Authorization.Users;
using System;

namespace demoFirstApp.Products
{
    public class Product : Entity<int>
    {
        public string Name { get; set; }

        public int Quantity { get; set; }

    }
}
