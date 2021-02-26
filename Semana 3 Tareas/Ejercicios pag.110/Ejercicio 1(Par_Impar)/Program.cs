using System;

namespace Ejercicio_1_Par_Impar_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double n1;
                Console.WriteLine("Ingrese el número: ");
                n1 = double.Parse(Console.ReadLine());


                if (n1 % 2 == 0)
                {
                    Console.WriteLine("El número " + n1 + " es par");

                }
                else { Console.WriteLine("El número " + n1 + " es impar"); }
            }catch (Exception error)
            {
                Console.WriteLine($"Hay un error {error.Message}");
            }

        }
    }
}
