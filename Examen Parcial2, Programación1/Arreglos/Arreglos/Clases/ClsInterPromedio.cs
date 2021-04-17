using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    class ClsInterPromedio : InterfacePromedio
    {
        public string[,] Clasificar_Alumnos(string[,] matriz)
        {
            int acumulador = 0, acumulador1 = 0;
            int SumaG ;
            int totalfilas = matriz.GetLength(0);
            string[,] alumnos = new string[matriz.GetLength(0), 2];
            for (int fila = 0; fila < totalfilas; fila++)
            {
                alumnos[acumulador, 0] = matriz[fila, 1];
                acumulador++;
            }
            for (int fila = 0; fila < totalfilas; fila++)
            {
                SumaG = Convert.ToInt32(matriz[fila, 2]) + Convert.ToInt32(matriz[fila, 3]) + Convert.ToInt32(matriz[fila, 4]);
                alumnos[acumulador1, 1] = Convert.ToString(SumaG);
                acumulador1++;
            }
            return alumnos;
        }

        public string nombre_nota_mayor(string[,] matriz,string[] notasA)
        {
            int acumulador = 0;
            int SumaG, PromedioG;
            int totalfilas = matriz.GetLength(0);
            double[] PromedioGeneral = new double[notasA.Length];
            double mayor = 0, guardar = 0;
            for (int fila = 0; fila < totalfilas; fila++)
            {
                SumaG = Convert.ToInt32(matriz[fila, 2]) + Convert.ToInt32(matriz[fila, 3]) + Convert.ToInt32(matriz[fila, 4]);
                PromedioG = SumaG / 3;
                if (acumulador != 0)
                {
                    PromedioGeneral[acumulador] = PromedioG;
                    if (PromedioGeneral[acumulador] > guardar)
                    {
                        mayor = PromedioGeneral[acumulador];
                        guardar = PromedioGeneral[acumulador];
                    }
                }
                acumulador++;
            }
            return Convert.ToString(mayor);
        }

        public string nombre_nota_mayorconSECCION(string[,] matriz, string sección)
        {
            throw new NotImplementedException();
        }

        public int promedios_por_seccion(string[,] matriz, int columna_parcial, string seccion)
        {
            throw new NotImplementedException();
        }

        public Double promedio_general_seccion(string[,] matriz,string seccion)
        {
            double PromedioGeneral, Sumageneral = 0, Sumageneral2 = 0;
            int totalfilas = matriz.GetLength(0);
            int acumulador = 0;
            for (int fila = 0; fila < totalfilas; fila++)
            {
                if (matriz[fila, 5].Trim().Equals(seccion))
                {
                    Sumageneral = Convert.ToInt32(matriz[fila, 2]) + Convert.ToInt32(matriz[fila, 3]) + Convert.ToInt32(matriz[fila, 4]);
                    Sumageneral2 = Sumageneral + Sumageneral2;
                    acumulador++;
                }
            }
            PromedioGeneral = Sumageneral2 / acumulador;
            return Convert.ToDouble(PromedioGeneral);
        }

        public int promedio_por_parcial(string[,] matriz, int columna_parcial)
        {
            throw new NotImplementedException();
        }

       
    }
}
