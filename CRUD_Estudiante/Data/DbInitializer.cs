using CRUD_Empleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Empleado.Data
{
    public class DbInitializer
    {
        public static void Initialize(EmpleadoContext context)
        {
            context.Database.EnsureCreated();

            if (context.Empleados.Any())
            {
                return;
            }

            var empleado = new Empleado[]
            {
                new Empleado {Nombre="Carlos", Sueldo=100,FechaIngreso=DateTime.Parse("2001-01-01"),Sueldo_Neto=90},
                new Empleado {Nombre="Aneurys", Sueldo=16000,FechaIngreso=DateTime.Parse("2019-02-11"),Sueldo_Neto=15250},
                new Empleado {Nombre="Jose", Sueldo=10000,FechaIngreso=DateTime.Parse("2015-05-21"),Sueldo_Neto=9000},
                new Empleado {Nombre="Gabriel", Sueldo=19000,FechaIngreso=DateTime.Parse("2012-03-11"),Sueldo_Neto=18090},
                new Empleado {Nombre="Miguel", Sueldo=22000,FechaIngreso=DateTime.Parse("2016-06-16"),Sueldo_Neto=21090}
            };


            foreach(Empleado s in empleado)
            {
                //Añadir registros
                context.Empleados.Add(s);
            }
            //Guardar los cambios
            context.SaveChanges();

        }
    }
}
