using System;

namespace Ejercicio_5._Dias_de_la_Semana_laboral
{
    class Program
    {
        static void Main(string[] args)
        {
           
                string dia1 ;
            int dia;
            Console.WriteLine("Ingrese el día: ");
            dia1 = Console.ReadLine();
            if (dia1 == "Lunes" || dia1 == "LUNES" || dia1 == "lunes") { dia1 = "1"; }
            if (dia1 == "Martes" || dia1 == "MARTES" || dia1 == "martes") { dia1 = "2"; }
            if (dia1 == "Miercoles" || dia1 == "MIERCOLES" || dia1 == "miercoles") { dia1 = "3"; }
            if (dia1 == "Jueves" || dia1 == "JUEVES" || dia1 == "jueves") { dia1 = "4"; }
            if (dia1 == "Viernes" || dia1 == "VIERNES" || dia1 == "viernes") { dia1 = "5"; }
            if (dia1 == "Sabado" || dia1 =="sábado"||dia1 == "SABADO" || dia1 == "sabado") { dia1 = "6"; }
            if (dia1 == "Domingo" || dia1 == "DOMINGO" || dia1 == "domingo") { dia1 = "7"; }
            dia = Convert.ToInt32(dia1);

            switch (dia)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        Console.WriteLine("####ES DÍA LABORAL####");
                        break;
                    case 6:
                    case 7:
                        Console.WriteLine("####No es día Laboral####");
                        break;
                default:
                        Console.WriteLine("##Tranquilo, solo hay 7 días amigo## ;)");
                        break;
                }
            }
        }
    }
    

