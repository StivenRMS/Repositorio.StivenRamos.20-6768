using System;

namespace Factorial_de_un_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int num, fact = 1;
                Console.Write("Ingrese un Número:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num < 0)
                {
                    fact = 0;
                }
                else if (num == 0)
                {
                    fact = 1;
                }
                else
                {
                    for (int i = 1; i <= num; i++)
                    {
                        fact = fact * i;
                    }
                }
                Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||");
                Console.WriteLine("El factorial del numero " + num + " es: " + fact);
            }catch (Exception error) { Console.WriteLine("¡EROR! " + error.Message); }

        }

    }
}
