using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using TG.Configuration;
using TG.Web;

namespace TG.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class TGDbContextFactory : IDesignTimeDbContextFactory<TGDbContext>
    {
        public TGDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<TGDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            TGDbContextConfigurer.Configure(builder, configuration.GetConnectionString(TGConsts.ConnectionStringName));

            return new TGDbContext(builder.Options);
        }
    }
}
