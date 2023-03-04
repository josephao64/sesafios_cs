namespace desafio5
{
    class Program
    {
        static int puntaje = 0;
        static int puntajeRecord = 0;
        static string jugadorRecord = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al juego imaginario!");

            Console.Write("Ingrese su nombre: ");
            string nombreJugador = Console.ReadLine();

            Console.Write("Ingrese su puntaje: ");
            int puntajeJugador = int.Parse(Console.ReadLine());

            VerificarPuntaje(puntajeJugador, nombreJugador);

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static void VerificarPuntaje(int puntajeJugador, string nombreJugador)
        {
            if (puntajeJugador > puntajeRecord)
            {
                puntajeRecord = puntajeJugador;
                jugadorRecord = nombreJugador;
                Console.WriteLine("La nueva puntuación más alta es " + puntajeRecord);
                Console.WriteLine("La puntuación más alta fue lograda por " + jugadorRecord);
            }
            else
            {
                Console.WriteLine("La puntuación más alta de " + puntajeRecord + " no se ha podido superar, y aún está en manos de " + jugadorRecord);
            }
        }
    }
}
