using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaGenericos
{
    internal class AlmacenObjetos
    {
        private Object[] datosElemento;
        private int i = 0;

        public AlmacenObjetos(int j)
        {
            datosElemento = new Object[j];
        }

        public void Agregar(Object obj)
        {
            datosElemento[i] = obj;
            i++;
        }

        public Object GetElemento(int i)
        { 
            return datosElemento[i]; 
        }
    }
}
