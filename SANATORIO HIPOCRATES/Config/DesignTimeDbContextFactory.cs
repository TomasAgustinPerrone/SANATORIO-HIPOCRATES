using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Config
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<Conexion>
    {
        public Conexion CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<Conexion>();
            optionsBuilder.UseMySql("Server=localhost;Database=sanatorio;Uid=root;Pwd=123456;",
                new MySqlServerVersion(new Version(8, 0, 21))
            );

            return new Conexion(optionsBuilder.Options);
        }
    }
}
