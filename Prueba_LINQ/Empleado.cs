using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_LINQ
{
    internal class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        //Clave foranea
        public int EmpresaId { get; set; }

        public override string ToString()
        {
            retunr string.Format("Empledo {0} con {1}, con cargo {2} con salario {3}" +
                "pertenece ")
        }


        //EL profe escribe muy rapido que aburrido completa con su codigo
    }
}
