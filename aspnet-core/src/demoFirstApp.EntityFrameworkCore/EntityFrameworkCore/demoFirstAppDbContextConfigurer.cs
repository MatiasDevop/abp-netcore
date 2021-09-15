using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace demoFirstApp.EntityFrameworkCore
{
    public static class demoFirstAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<demoFirstAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<demoFirstAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
