using System;

namespace Ejercicio_6_Numero_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, num;
            Console.WriteLine("Ingrese el Numero que desea saber si es primo: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < (num + 1); i++)
            {
                if (num % i == 0)
                {
                    a++;
                }
            }
            if (a != 2)
            {
                Console.WriteLine(num + " No es un número primo");
            }
            else
            {
                Console.WriteLine(num + " Si es un número primo");
            }
            Console.ReadLine();
        }
    }
    }

