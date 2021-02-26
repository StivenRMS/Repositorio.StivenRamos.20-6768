using System;

namespace Serie_de_un_Numero
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Console.Write("Ingrese el numero: ");
				int cantidad = int.Parse(Console.ReadLine());
				long a = 0;
				long b = 1;
				long aux = 1;


				for (int i = 0; i <= cantidad; i++)
				{
					if (i == 0)
					{
						Console.Write(a + ", ");
					}
					else
					{
						aux = a;
						a = b;
						b = aux + a;
						Console.Write(a + ", ");
					}
				}
				Console.WriteLine();
			}catch (Exception error) { Console.WriteLine("¡EROR! " + error.Message); }

		}
	}
}
