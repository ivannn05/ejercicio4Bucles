using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4Bucles.Servicios
{
    internal class solicitudNumeroImplemtacion : solicitudNumeroInterfaz
    {
        public int numeroInt()
        {
            int numeroInt;

            Console.WriteLine("Introduzca un numero int");
            numeroInt = Convert.ToInt32(Console.ReadLine());
            return numeroInt;
        }
    }
}
