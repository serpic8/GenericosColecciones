using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericos
{
    internal class AlmacenObjetos2<T>
    {
        private T[] datosElemento;
        private int i = 0;

        public AlmacenObjetos2(int j)
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
