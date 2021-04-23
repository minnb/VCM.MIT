using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace VCM.MIT.EntityFrameworkCore
{
    public static class MITDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MITDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MITDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
