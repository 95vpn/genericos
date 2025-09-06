using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericos
{
    public class AlmacenObjetos<T>
    {
        public AlmacenObjetos(int z) 
        {
            datosElemento = new T[z];
        }

        public void agregar( T obj)
        {
            datosElemento[i] = obj;

            i++;
        }

        public T getElemento(int i)
        {
            return datosElemento[i];
        }

        private T[] datosElemento;

        private int i = 0;
    }
}
