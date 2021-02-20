using System;

namespace Ejer._3_Obrero
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas2;
            string horas1;
            int horas, horasex;
            Console.Write("Ingrese las horas que trabajó:");
            horas1 = Console.ReadLine();
            Console.WriteLine(" ");
            horas2 = Convert.ToInt32(horas1);

            if (horas2 <= 40)
            {
                horas = (horas2 * 16);
                Console.WriteLine("Su Salario es de: Q" + horas);}
            else {
               horasex=  horas2 - 40;
                horas2 = (40 * 16);
                horas = ((horasex * 20)+ horas2);
                Console.WriteLine("Por trabajar " + horasex + " horas extras ");
                Console.WriteLine(" ");
                Console.WriteLine("Su salario es de: Q" + horas);


            }
        }
    }
}
