using System;

namespace Ejercicio_No._4_Año_Bisiesto_
{
    class Program
    {
        static void Main(string[] args)
        {


            int anio, dia, dias, diasf, mes;

            Console.Write("Ingrese el año: ");
            anio = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Número del mes(1-12): ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el Número del dia: ");
            dia = int.Parse(Console.ReadLine());
            dias = 0;
            if (mes == 2 && (((anio % 4 == 0) && (anio % 100 != 0)) || anio % 400 == 0))
                dias = 29;
            if (mes == 2 && (((anio % 4 != 0) || (anio % 100 == 0)) && anio % 400 != 0))
                dias = 28;
            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
                dias = 31;
            if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                dias = 30;
            diasf = dias - dia;
            Console.WriteLine("El mes tiene: " + dias+ " días");
            Console.WriteLine("Faltan " + diasf + " para que se acabe el mes ");
            Console.WriteLine();

        }
    }
}  
        