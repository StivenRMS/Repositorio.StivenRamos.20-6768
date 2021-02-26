using System;

namespace Ejercicio_2__potencia_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num,num1= 1, pot;
                Console.Write("Introduzca el número: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");
                Console.Write("Introduzca la potencia: ");
                pot = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                for (int i = 1; i <= pot; i++)
                {
                    num1 = num1 * num;
                    

                }
                Console.WriteLine(" ");
                Console.Write("...........................El resultado es: " + num1 );
                Console.WriteLine(" ");

            }
            catch (Exception error) { Console.WriteLine("¡EROR! " + error.Message); }

        }
    }
}
