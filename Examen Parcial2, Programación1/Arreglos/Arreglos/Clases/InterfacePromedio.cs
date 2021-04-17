using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    interface InterfacePromedio
    {
        /// <summary>
        /// retorna el promedio en base a una columna especifica
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <returns></returns>
        int promedio_por_parcial(string[,] matriz, int columna_parcial);
        /// <summary>
        /// Retorna el promedio de un parcial en especial y una sección en especial
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        int promedios_por_seccion(string[,] matriz,int columna_parcial,string seccion);
        /// <summary>
        /// Saca el promedio general de todos los alumnos por sección  
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="columna_parcial"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        Double promedio_general_seccion(string[,] matriz, string seccion);

        /// <summary>
        /// retorna una matriz de 2 columnas con el nombre y la otra columna
        /// es la sumatoria del parcial del 1 2 y 3
        /// </summary>
        /// <param name="matriz"></param>
        /// <param name="seccion"></param>
        /// <returns></returns>
        string[,] Clasificar_Alumnos(string[,] matriz);
        /// <summary>
        /// busca el mejor promedio general o por seccion  
        /// </summary>
        /// <param name="matriz"></param>
        /// <returns></returns>

        string nombre_nota_mayor(string[,] matriz,string[] notasA);
        string nombre_nota_mayorconSECCION(string[,] matriz, string sección );

    }
}
