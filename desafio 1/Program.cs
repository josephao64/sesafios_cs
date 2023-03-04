namespace clase_27_02_23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("ingresa tu nombre");
            string nombre = Console.ReadLine();

            Console.WriteLine("Imgrese sus ultimos 3 meses de salario ");
            int salario1 = Convert.ToInt32(Console.ReadLine());
            int salario2 = Convert.ToInt32(Console.ReadLine());
            int salaario3 = Convert.ToInt32(Console.ReadLine());

            int salarioT = salario1 + salario2 + salaario3;
            int promedio = salarioT / 3;
            Console.WriteLine(" hola " + nombre + " tu salario de estos ultimos 3 meses es de " + salarioT + " y promediaste un total de " + promedio);






        }


    }
}