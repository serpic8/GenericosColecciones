using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericosRestricciones
{
    internal class Secretario : IParaEmpleados
    {
        private double salario;

        public Secretario(double salario)
        {
            this.salario = salario;
        }
        public double GetSalario()
        {
            return salario;
        }
    }
}
