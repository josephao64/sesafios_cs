namespace desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora miCalculadora = new Calculadora();

          
            int resultadoSuma = miCalculadora.Sumar(3, 5);
            int resultadoResta = miCalculadora.Restar(10, 4);
            int resultadoMultiplicacion = miCalculadora.Multiplicar(2, 7);
            double resultadoDivision = miCalculadora.Dividir(15, 3);

         
            Console.WriteLine("Resultado suma: " + resultadoSuma);
            Console.WriteLine("Resultado resta: " + resultadoResta);
            Console.WriteLine("Resultado multiplicación: " + resultadoMultiplicacion);
            Console.WriteLine("Resultado división: " + resultadoDivision);

            Console.ReadKey();
        }
    }
}
