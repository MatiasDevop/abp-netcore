using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using demoFirstApp.Authorization.Roles;
using demoFirstApp.Authorization.Users;
using demoFirstApp.MultiTenancy;
using demoFirstApp.Products;

namespace demoFirstApp.EntityFrameworkCore
{
    public class demoFirstAppDbContext : AbpZeroDbContext<Tenant, Role, User, demoFirstAppDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Product> Products { get; set; }

        public demoFirstAppDbContext(DbContextOptions<demoFirstAppDbContext> options)
            : base(options)
        {
        }
    }
}
