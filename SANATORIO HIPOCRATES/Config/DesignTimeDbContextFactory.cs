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
            // Crea un objeto DbContextOptionsBuilder para configurar las opciones de DbContext
            var optionsBuilder = new DbContextOptionsBuilder<Conexion>();
            optionsBuilder
                .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddConsole())) // Configura el uso de un LoggerFactory para registrar los mensajes de registro en la consola
                .UseMySql("Server=localhost;Database=sanatorio;Uid=root;Pwd=123456",
                new MySqlServerVersion(new Version(8, 0, 21))
            );
            // Configura el uso de MySQL como proveedor de base de datos, con la cadena de conexión especificada

            return new Conexion(optionsBuilder.Options);
        }
    }
}
