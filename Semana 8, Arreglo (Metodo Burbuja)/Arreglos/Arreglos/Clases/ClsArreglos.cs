using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    class ClsArreglos
    {
        private string[] ArregloTemporal;
        private string[] datos;
        private string datosTemporal;
        private int i, j;
        private int tamanoArreglo = 0;
        private double Pars1, Pars2, Pars3;

       
        public ClsArreglos(string [] arreglo)
        {
            datos = arreglo;
            tamanoArreglo = datos.Length;
        }

        public string[] MetodoBurbuja()
        {
            ArregloTemporal = datos;

            for (i = 0; i < tamanoArreglo - 1; i++)
            {
                for (j = i + 1; j < tamanoArreglo; j++)
                {
                    if (ArregloTemporal[i].CompareTo(ArregloTemporal[j]) > 0)
                    {
                        datosTemporal = ArregloTemporal[i];
                        ArregloTemporal[i] = ArregloTemporal[j];
                        ArregloTemporal[j] = datosTemporal;
                    }
                }
          
            
           }

            return ArregloTemporal;
        }

        public ClsArreglos(string parcial1,string parcial2, string parcial3)
        {
            Pars1 = Convert.ToDouble(parcial1);
            Pars2 = Convert.ToDouble(parcial2);
            Pars3 = Convert.ToDouble(parcial3);
           
            
        }

        public double promedioG()
        {
            double result = ((Pars1 + Pars2 + Pars3) / 3);
            return result;
        }
    }
}
