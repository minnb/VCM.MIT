using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using VCM.MIT.Configuration;
using VCM.MIT.Web;

namespace VCM.MIT.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MITDbContextFactory : IDesignTimeDbContextFactory<MITDbContext>
    {
        public MITDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MITDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MITDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MITConsts.ConnectionStringName));

            return new MITDbContext(builder.Options);
        }
    }
}
