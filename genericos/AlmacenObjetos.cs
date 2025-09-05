using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericos
{
    public class AlmacenObjetos
    {
        public AlmacenObjetos(int z) 
        {
            datosElemento = new object[z];
        }

        public void agregar(Object obj)
        {
            datosElemento[i] = obj;

            i++;
        }

        public Object getElemento(int i)
        {
            return datosElemento[i];
        }

        private Object[] datosElemento;

        private int i = 0;
    }
}
