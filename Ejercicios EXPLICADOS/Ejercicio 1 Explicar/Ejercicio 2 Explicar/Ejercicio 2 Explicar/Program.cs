using System;
using System.Threading;

namespace ejercicios__clase_1_para_parcial_2
{
    class Program
    {

        public static void dibuja(int cantidad)
        {
            int columnaT = 50;
            int filaT = 100;
            int IntervF = 2;
            int IntervC = 2;
            int F, C, A;
            for (A = 1; A <= cantidad; A++)
            {
                for (F = IntervC; F <= filaT; F++)
                {
                    Console.SetCursorPosition(F, columnaT); Console.Write("?");
                    Console.SetCursorPosition(F, IntervF); Console.Write("?");
                }
                for (C = IntervF; C <= columnaT; C++)
                {
                    Console.SetCursorPosition(IntervC, C); Console.Write("X");
                    Console.SetCursorPosition(filaT, C); Console.Write("X");
                }
                IntervF = IntervF + 1;
                columnaT = columnaT - 1;
                IntervC = IntervC + 1;
                filaT = filaT - 1;
            }
        }
        static void Main(string[] args)
        {
            for (int tam = 1; tam < 25; tam++)
            {
                dibuja(tam);
                Thread.Sleep(1000);
            }
        }
    }
}
