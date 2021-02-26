using System;

namespace Ejercicio_5__Promedio_de_edad_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int nump;
                int may = 0, men = 0;
                Console.Write("Cantidades de Edades: ");
                nump = Convert.ToInt32(Console.ReadLine());
                int[] edades = new int[nump + 1];
                int i;

                for (i = 1; i <= nump; i++)
                {
                    Console.Write("Cual es la Edad de la Persona: ");
                    edades[i] = Convert.ToInt32(Console.ReadLine());
                }
                may = edades[1];
                men = edades[1];
                for (i = 1; i <= nump; i++)
                {
                    if (edades[i] > may)
                    {
                        may = edades[i];
                    }
                    else if (edades[i] < men)
                    {
                        men = edades[i];
                    }
                }

                Console.WriteLine("La edad mayor es: " + may);
                Console.WriteLine("La edad menor es: " + men);
                Console.WriteLine(" ");
            }catch (Exception error) { Console.WriteLine("¡EROR! " + error.Message); }

        }
    }
}
