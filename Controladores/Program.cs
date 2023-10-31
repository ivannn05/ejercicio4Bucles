using ejercicio4Bucles.Servicios;

namespace ejercicio4Bucles
{
    class Program
    {
      

        static void Main(string[] args)
        {
            solicitudNumeroInterfaz sn = new solicitudNumeroImplemtacion();

            operacionesInterfaz op = new operacionesImplementacion();
            string respuesta;
            do
            {
                int numeroInt = sn.numeroInt();

                op.calculo(numeroInt);
                Console.WriteLine("Si quieres que se repita pulsa s");
                 respuesta= Console.ReadLine();
            } while (respuesta == "s");
        }

    }

}

