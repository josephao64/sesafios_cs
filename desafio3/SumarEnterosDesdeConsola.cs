using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio3
{
    public static int SumarEnterosDesdeConsola()
    {
        int resultado = 0;
        try
        {
            Console.WriteLine("Ingrese el primer número entero:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo número entero:");
            string input2 = Console.ReadLine();

            int numero1 = int.Parse(input1);
            int numero2 = int.Parse(input2);

            resultado = numero1 + numero2;
        }
        catch (FormatException e)
        {
            Console.WriteLine("Error: Uno o ambos valores no son números enteros.");
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error inesperado: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Fin del programa.");
        }

        return resultado;
    }
 }
