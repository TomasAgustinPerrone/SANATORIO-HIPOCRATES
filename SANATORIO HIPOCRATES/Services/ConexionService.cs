using Microsoft.EntityFrameworkCore;
using SANATORIO_HIPOCRATES.Config;
using System;

namespace SANATORIO_HIPOCRATES.Services
{
    public class ConexionService : iConexionService
    {
        public DbContextOptionsBuilder<Conexion> ConexionMYSQL()
        {
            var optionsBuilder = new DbContextOptionsBuilder<Conexion>();
            optionsBuilder.UseMySql("Server=localhost;Database=sanatorio;Uid=root;Pwd=123456",
                    new MySqlServerVersion(new Version(8, 0, 21))
            );

            return optionsBuilder;
        }
       
    }
}
