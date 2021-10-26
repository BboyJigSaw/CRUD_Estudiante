using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD_Empleado.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Empleado.Data
{
    public class EmpleadoContext: DbContext
    {
        public EmpleadoContext (DbContextOptions<EmpleadoContext> options):base(options)
        {

        }

        public DbSet<Empleado> Empleados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>().ToTable("Empleados");
        }
    }
}
