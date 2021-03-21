using System;
using System.Threading;

namespace ejercicios__clase_1_para_parcial_2
{
    class Program
    {

        public static string Mid(string parametro, int startindex, int length)
        {
            string result = parametro.Substring(startindex, length);
            return result;
        }
        static void Main(string[] args)
        {
            string nombre;
            string caracter;
            int k = 0;
            int P = 0;
            int cadenaT = 0;
            int distancia = 0;
            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(1, 12);
            Console.Write(nombre);
            cadenaT = nombre.Length;
            distancia = 70;
            nombre = nombre.ToUpper();
            for (P = nombre.Length; P >= 1; P--)
            {
                caracter = Mid(nombre, P - 1, 1);
                for (k = cadenaT; k <= distancia; k++)
                {
                    Console.SetCursorPosition(k, 12);
                    Console.Write(" " + caracter);
                    Thread.Sleep(50);
                }
                distancia = distancia - 1;
                cadenaT = cadenaT - 1;
            }
        }
    }
}