using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Clases
{
    class ClsArchivo
    {
        public string[] LeerArchivo(string archivo)
        {
            string[] lineas = File.ReadAllLines(archivo,System.Text.Encoding.UTF8);
            return lineas;
        }

        public String LeerTodoArchivo(string archivo)
        {
            string ContenidoArchivo;
            using(StreamReader reader= new StreamReader(archivo,System.Text.Encoding.UTF8))
            {
                ContenidoArchivo = reader.ReadToEnd();
            }
            return ContenidoArchivo;
        }
    }
}
