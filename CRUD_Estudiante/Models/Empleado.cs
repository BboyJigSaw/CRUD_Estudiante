using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Empleado.Models
{
    public class Empleado
    {
        /*Instalar estos paquetes por la consola de Nuget que esta en Herramientas>
         Install-Package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
         Install-Package Microsoft.EntityFrameworkCore.SqlServer
         */
        public int ID { get; set; }
        public string Nombre { get; set; }
        public decimal Sueldo { get; set; }
        public DateTime FechaIngreso { get; set; }
        public decimal Sueldo_Neto { get; set; }
    }
}
