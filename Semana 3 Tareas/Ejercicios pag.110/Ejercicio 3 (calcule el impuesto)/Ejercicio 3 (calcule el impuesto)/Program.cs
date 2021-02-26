using System;

namespace Ejercicio_3__calcule_el_impuesto_
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                int num;

                Console.WriteLine("Medicina......(1)");
                Console.WriteLine("OTRO PRODUCTO.(2)");
                Console.WriteLine("");
                Console.Write("INGRESE EL NUMERO DE SU OPCION: ");
                num = Convert.ToInt32(Console.ReadLine());


                switch (num)
                {
                    case 1:
                        //Si es medicina
                        int precio;
                        Console.Write("Ingrese el precio total de la medicina: ");
                        precio = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");
                        Console.WriteLine("Su impuesto es del 0%");
                        Console.WriteLine(" ");
                        Console.WriteLine("Su Producto esta libre de pagar impuestos ");
                        break;
                    case 2:
                        int precio1;
                        double total, total1, iva = 1.12;
                        Console.Write("Ingrese el precio total del producto: ");
                        
                        precio1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(" ");
                        Console.WriteLine("Su impuesto es del 12%");
                        Console.WriteLine(" ");
                        total = Math.Round((precio1 / iva),2);
                        total1 = Math.Round((precio1 - total),2);
                        Console.WriteLine("Precio sin Impuesto: "+ total);
                        Console.WriteLine("El total del impuesto es de: " + total1);
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
