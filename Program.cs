using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrolitosLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horas;
            string nombre;
            string opcion;
            JefeDeTienda j1;

            do
            {
                Console.WriteLine("Ingrese el nombre del Trabajador");
                nombre = Console.ReadLine();
                j1 = new JefeDeTienda(nombre);

                try
                {
                    Console.WriteLine("Ingrese cantidad de Horas Trabajadas");
                    horas = Convert.ToInt32(Console.ReadLine());
                    j1.CalcularSueldo(horas);

                    Console.WriteLine("Nombre del Trabajador es : " + j1.Nombre);
                    Console.WriteLine("El monto de las horas normales a pagar es : " + j1.MontoNormal);
                    Console.WriteLine("El monto de las horas extras a pagar es : " + j1.MontoExtra);
                    Console.WriteLine("Monto total a pagar al trabajador es : " + j1.Sueldo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("¿Desea salir del programa [s/n]?");
                Console.WriteLine("S = si");
                Console.WriteLine("N = no");
                opcion = Console.ReadLine();
                if( opcion == "S" || opcion == "s" )
                {
                    break;
                }

            } while (true);
         
            
        }
    }
}
