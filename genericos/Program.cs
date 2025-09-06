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
            //AlmacenObjetos<Empleado> archivos = new AlmacenObjetos<Empleado>(4);

            //AlmacenObjetos<String> archivos = new AlmacenObjetos<String>(4);

            AlmacenObjetos<DateTime> archivos = new AlmacenObjetos<DateTime>(4);

            /*
            archivos.agregar("Juan");
            archivos.agregar("Elena");
            archivos.agregar("Antonio");
            archivos.agregar("Sandra");
            */


            /*
            archivos.agregar(new Empleado(1500));
            archivos.agregar(new Empleado(2500));
            archivos.agregar(new Empleado(3500));
            archivos.agregar(new Empleado(4500));
            */

            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());
            archivos.agregar(new DateTime());

            //String nombrePersona = archivos.getElemento(2);
            //Empleado salarioEmpleado = archivos.getElemento(2);
            DateTime salarioEmpleado = archivos.getElemento(2);

            Console.WriteLine(salarioEmpleado);
        }
    }
}
