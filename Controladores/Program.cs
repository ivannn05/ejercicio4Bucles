using ejercicio4Bucles.Servicios;

namespace ejercicio4Bucles
{
    class Program
    {
        static void Main(string[] args)
        {
            solicitudNumeroInterfaz sn = new solicitudNumeroImplemtacion();

            int numeroInt=sn.numeroInt();

            operacionesInterfaz op = new operacionesImplementacion();
            op.calculo(numeroInt);

        }

    }

}

