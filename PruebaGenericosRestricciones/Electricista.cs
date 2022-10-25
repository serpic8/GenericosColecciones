using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericosRestricciones
{
    internal class Electricista : IParaEmpleados
    {
        private double salario;

        public Electricista(double salario)
        {
            this.salario = salario;
        }
        public double GetSalario()
        {
            return salario;
        }
    }
}
