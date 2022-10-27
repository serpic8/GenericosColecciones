using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_LINQ
{
    internal class Empresa
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return String.Format("Empresa {0} con {1}", Nombre, Id);

        }
    }
}
