using Microsoft.EntityFrameworkCore;
using SANATORIO_HIPOCRATES.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SANATORIO_HIPOCRATES.Services
{
    public interface iConexionService
    {
        public DbContextOptionsBuilder<Conexion> ConexionMYSQL();
    }
}
