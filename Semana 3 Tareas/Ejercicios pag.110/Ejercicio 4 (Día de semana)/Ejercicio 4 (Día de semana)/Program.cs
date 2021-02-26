using System;

namespace Ejercicio_4__Día_de_semana_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int num;
                string dia, num1;
                Console.WriteLine("ESCRIBA UN NUMERO DEL 1 AL 7: ");
                num1=Console.ReadLine();
                num = Convert.ToInt32(num1);
                Console.WriteLine(" ");
                

                switch (num)
                {
                    case 1:
                        dia = "LUNES";
                        Console.Write("El dia según el numero es: " + dia);
                        break;
                    case 2:
                        dia = "MARTES";
                        Console.Write("El dia según el numero es: " + dia);
                        break;
                    case 3:
                        dia = "MIERCOLES";
                        Console.Write("El dia según el numero es: " + dia);
                        break;
                    case 4:
                        dia = "JUEVES";
                        Console.Write("El dia según el numero es: " + dia);
                        break;
                    case 5:
                        dia = "VIERNES";
                        Console.Write("El dia según el numero es: " + dia);
                        break;
                    case 6:
                        dia = "SABADO";
                        Console.Write("El dia según el numero es: " + dia);
                        break;
                    case 7:
                        dia = "DOMINGO";
                        Console.Write("El dia según el numero es: " + dia);
                        break;
                    default:
                        Console.WriteLine(" ");
                        Console.WriteLine("Número no disponible...");
                        break;




                }
                
            }
            catch (Exception error) { Console.WriteLine("¡EROR! " + error.Message); }





        }
    }
    
}
