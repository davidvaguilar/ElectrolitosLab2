using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectrolitosLab2
{
    internal class JefeDeTienda : Trabajador
    {
        public JefeDeTienda(string nombre) : base(nombre)
        {
        }

        // Atributos de Clase

        // Funciones de la Clases

        public override void CalcularSueldo( int horasTrabajadas )
        {

            if( horasTrabajadas <= 40 )
            {
                this.MontoNormal = horasTrabajadas * 2000;
            }
            else
            {
                this.MontoNormal = 40 * 2000;
                this.MontoExtra = (horasTrabajadas - 40) * 3000;
            }

            this.Sueldo = this.MontoNormal + this.MontoExtra;

        }


    }
}
