using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace SANATORIO_HIPOCRATES.Config
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Conexion>
    {
        public Conexion CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Conexion>();
            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole()))
                .UseMySql("Server=localhost;Database=sanatorio;Uid=root;Pwd=;",
                new MySqlServerVersion(new Version(8, 0, 21))
            );

            return new Conexion(optionsBuilder.Options);
        }
    }
}
