using System;

namespace Ejercicio_5__polígono_regular_
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                char numop;
                double ladtri, bastri, alttri, pertri, artri;
                double ladcua, pericua, arcua, canpo, larpo, apop, pep, apo;
                Console.WriteLine("****AREA Y PERIMETRO DE POLIGONOS REGULARES*****");
                Console.WriteLine("Triangulo Equilatero.......................(1)");
                Console.WriteLine("Cuadrado...................................(2) ");
                Console.WriteLine("Polígonos Regulares de 5,6,7,8,9,10 Lados..(3)");
                Console.Write("Ingrese el numero de la opcion: ");
                numop = Convert.ToChar(Console.ReadLine());
                switch (numop)
                {
                    case '1':
                        Console.WriteLine("---------------------------------------------");
                        Console.Write("Ingrese la longitud de un lado de los triangulo: ");
                        ladtri = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la longitud de la base del triangulo: ");
                        bastri = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la longitud de la altura del triangulo: ");
                        alttri = Convert.ToDouble(Console.ReadLine());

                        pertri = (ladtri * 3);
                        artri = ((bastri * alttri) / 2);
                        Console.WriteLine("El Perimetro del triangulo es: " + pertri);
                        Console.WriteLine("El Area del triangulo es: " + artri);
                        break;

                    case '2':
                        Console.WriteLine("-------------------------------------------");
                        Console.Write("Ingrese la longitud de un lado del Cuadradado: ");
                        ladcua = Convert.ToDouble(Console.ReadLine());
                        pericua = (ladcua * 4);
                        arcua = (ladcua * ladcua);
                        Console.WriteLine("El Perimetro del Cuadrado es: " + pericua);
                        Console.WriteLine("El Area del Cuadrado es: " + arcua);
                        break;

                    case '3':
                        Console.WriteLine("");
                        Console.Write("Ingrese la catidad de lados que tiene su Poligono: ");
                        canpo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese la longitud de un lado de su Poligono: ");
                        larpo = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingrese el apotema de su Poligono: ");
                        apop = Convert.ToDouble(Console.ReadLine());
                        pep = (canpo * larpo);
                        apo = ((pep * apop) / 2);
                        Console.WriteLine("El Perimetro del Poligono es: " + pep);
                        Console.WriteLine("El Area del Poligono es: " + apo);
                        break;
                } 
            }
           
            catch (Exception error) { Console.WriteLine("¡EROR! " + error.Message); }
        }
}
}
