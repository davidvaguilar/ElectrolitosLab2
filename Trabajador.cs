using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrolitosLab2
{
    abstract class Trabajador
    {
        public string Nombre { get; set; }
        public double MontoNormal { get; set; }
        public double MontoExtra { get; set; }
        public double Sueldo { get; set; }

        public Trabajador(string nombre)
        {
            this.Nombre = nombre;
        }

        public abstract void CalcularSueldo(int horasTrabajadas);


    }
}
