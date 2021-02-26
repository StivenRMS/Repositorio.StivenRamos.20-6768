
using System;

namespace Ejecicio_1_tabla_de_multiplicar_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num, num1;
                Console.WriteLine("Introdusca el número que desea saber la tabla: ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("La tabla es la siguiente: ");

                for (int i = 1; i <= 10; i++)
                {
                    num1 = num * i;
                    Console.WriteLine(num + " x " + i + " = " + num1);

                }
            }catch (Exception error) { Console.WriteLine("¡EROR! " + error.Message); }


        }
    }
}
