using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genericos
{
    public class Program
    {
        static void Main(string[] args)
        {
            AlmacenObjetos archivos = new AlmacenObjetos(4);

            /*
            archivos.agregar("Juan");
            archivos.agregar("Elena");
            archivos.agregar("Antonio");
            archivos.agregar("Sandra");
            */

            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3500));
            archivos.agregar(new Empleado(4500));

            //String nombrePersona = (String)archivos.getElemento(2
            Empleado salarioEmpleado = (Empleado)archivos.getElemento(2);

            Console.WriteLine(salarioEmpleado.getSalario());
        }
    }
}
