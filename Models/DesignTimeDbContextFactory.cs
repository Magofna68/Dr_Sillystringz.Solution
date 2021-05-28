using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkDesign;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Factory.Models
{
  public class FactoryContextFactory : IDesignTimeDbContextFactory<FactoryContext>
  {
    FactoryContext IDesignTimeDbContextFactory<FactoryContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrectDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

      var builder = new DbContextOptionsBuilder<FactoryContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"],
      ServerVersion.AutoDetect(configuration["ConnectionsStrings:DefaultConnection"]));

      return new FactoryContext(builder.Options);
    }
  }
}