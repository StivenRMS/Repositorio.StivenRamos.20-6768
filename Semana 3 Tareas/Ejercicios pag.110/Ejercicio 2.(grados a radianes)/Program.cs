using System;

namespace Ejercicio_2._grados_a_radianes_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int num;

                Console.WriteLine("DE GRADOS A RADIANES (1)");
                Console.WriteLine("DE RADIANES A GRADOS (2)");
                Console.WriteLine("");
                Console.Write("INGRESE EL NUMERO DE SU OPCION: ");
                num = Convert.ToInt32(Console.ReadLine());
           

            switch (num) 
            {
              case 1: 
                     //Si es de grado a radian
                     double grados, radianes;
                     string val;

                      Console.Write("Dame la cantidad de grados: ");
                      val = Console.ReadLine();
                      grados = Convert.ToDouble(val);
                      radianes = Math.Round(grados * (Math.PI / 180), 6);
                      Console.WriteLine(" ");
                      Console.WriteLine("El resultado es: "+radianes+" Radianes");
                    break;
              case 2:
               double grados1, radianes1;
               string val1;

               Console.Write("Dame la cantidad de Radianes: ");
               val1 = Console.ReadLine();
               radianes1 = Convert.ToDouble(val1);
               grados1 = Math.Round(((radianes1 * 180)/Math.PI), 6);
               Console.WriteLine("El resultado es: "+grados1+"°");
                    break;
                default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Ingrese una de las dos opciones!");
                    break;

              


        }

            }
            catch (Exception error) { Console.WriteLine("¡EROR! " + error.Message); }





        }
    }
}
