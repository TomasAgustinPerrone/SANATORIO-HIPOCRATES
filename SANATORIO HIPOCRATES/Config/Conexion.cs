using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        public DbSet<MedicoPersonal> Medicos { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Recepcionista> Recepcionistas { get; set; }
        public DbSet<Turno> Turnos { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paciente>()
                .HasOne(p => p.Persona)
                .WithOne()
                .HasForeignKey<Paciente>(b => b.IdPersona);

            modelBuilder.Entity<Empleado>()
                .HasOne(e => e.Persona)
                .WithOne()
                .HasForeignKey<Empleado>(e => e.IdPersona);


            modelBuilder.Entity<Recepcionista>()
                .HasOne(p => p.Empleado)
                .WithOne()
                .HasForeignKey<Recepcionista>(b => b.IdEmpleado);

            modelBuilder.Entity<MedicoPersonal>()
                .HasOne(p => p.Empleado)
                .WithOne()
                .HasForeignKey<MedicoPersonal>(b => b.IdEmpleado);

        }

    }
}
