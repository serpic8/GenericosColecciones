using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericosRestricciones
{
    internal class AlmacenEmpleados<T> where T : IParaEmpleados
    {
        private T[] datosElemento;
        private int i = 0;

        public AlmacenEmpleados(int j)
        {
            datosElemento = new T[j];
        }

        public void Agregar(T obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public T GetElemento(int i)
        {
            return datosElemento[i];
        }
    }
}
