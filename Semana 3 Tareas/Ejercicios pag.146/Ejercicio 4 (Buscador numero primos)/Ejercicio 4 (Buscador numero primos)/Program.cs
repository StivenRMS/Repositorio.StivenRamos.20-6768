using System;

namespace Ejercicio_4__Buscador_numero_primos_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("LOS NUMEROS PRIMOS QUE HAY DEL 1-1000: ");
                int num =2, cont =0;
                while (num <= 1000)
                {
                    for (int i = 1; i <= num; i++)
                    {
                        if (num % i == 0)
                        {
                            cont++;
                        }
                    }
                    if (cont == 2)
                    {
                        Console.WriteLine("El número  " + num + " Sí es primo");
                    }
                    cont = 0;
                    num++;
                }
            }
            catch (Exception error) { Console.WriteLine("¡EROR! " + error.Message); }

        }
    }
}
