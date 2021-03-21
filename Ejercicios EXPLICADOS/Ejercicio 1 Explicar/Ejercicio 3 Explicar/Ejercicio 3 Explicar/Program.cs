using System;

namespace RandomToken
{
    class Program
    {
        public static string Respuesta(int min, int max)
        {
            Random Res = new Random();
            int Mayus = Convert.ToInt32(Res.Next(65, 90));
            string RespF = "";
            if (((Mayus > min) & (Mayus < max)))
            {
                RespF = Convert.ToString((char)Mayus);

            }


            return RespF;
        }
        static void Main(string[] args)
        {
            byte Cantidad, R;

            string LeerCant;
            Console.Write("Numero de caracteres deseados para su token: ");
            LeerCant = Console.ReadLine();
            Cantidad = byte.Parse(LeerCant);


            string Respuesta = "";
            for (R = 1; R <= Cantidad; R++)
            {
                Respuesta = Respuesta + Program.Respuesta(65, 90);
            }
            Console.WriteLine($"Su token es= {Respuesta}");

        }
    }
}