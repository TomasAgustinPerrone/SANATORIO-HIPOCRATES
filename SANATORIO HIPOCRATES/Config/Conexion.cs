using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SANATORIO_HIPOCRATES.Entidades;

namespace SANATORIO_HIPOCRATES.Config
{
    public class Conexion : DbContext
    {
        public Conexion(DbContextOptions<Conexion> options)
            : base(options)
        { }


        public DbSet<Persona> Personas { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Recepcionista> Recepcionistas { get; set; }
        public DbSet<Turno> Turnos { get; set; }
    }
}
