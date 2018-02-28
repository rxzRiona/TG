using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace TG.EntityFrameworkCore
{
    public static class TGDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<TGDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<TGDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
