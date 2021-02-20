using System;

namespace no._2_Descuento_MegaPlaza
{
    class Program
    {
        static void Main(string[] args)
        {
            double total;
            double descu;
            decimal descu1;
            Console.Write("\t*****************MEGAPLAZA******************\n");
            Console.Write("Ingrese el total de su compra para realizar su descuento: ");
            total = double.Parse(Console.ReadLine());


            if (total >= 300)
            {
               descu= ((total*0.30)-total)*-1;
                descu1 = Convert.ToDecimal(descu);
                descu1 = Math.Round(descu1, 2);
                Console.WriteLine("#######################################################");
                Console.WriteLine("########Aplicando el descuento usted tiene que pagar==> " + descu1) ;
                Console.WriteLine("#######################################################");
            }
            else { 
                Console.WriteLine("######## No aplica para realizar descuento ###########\n"); }



        }
    }
}
