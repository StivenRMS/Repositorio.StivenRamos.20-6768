using Arreglos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arreglos
{
    public partial class Form1 : Form
    {
        private string[] ArregloNotas;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonArreglo.Enabled = false;
            int numer=0, totalP1 = 0, totalP2 = 0, totalP3 = 0;
            double prom1, prom2,prom3;

            string[] parcial1 = new string[ArregloNotas.Length - 1];
            string[] parcial2 = new string[ArregloNotas.Length - 1];
            string[] parcial3 = new string[ArregloNotas.Length - 1];

            foreach (string linea in ArregloNotas)
            {


                if (numer != 0)
                {
                    string[] datoU = linea.Split(',');
                    string[] datos = linea.Split(',');
                    parcial1[numer - 1] = datos[2];
                    parcial2[numer - 1] = datos[3];
                    parcial3[numer - 1] = datos[4];
                    totalP1 = Convert.ToInt32(parcial1[numer - 1]) + totalP1;
                    totalP2 = Convert.ToInt32(parcial2[numer - 1]) + totalP2;
                    totalP3= Convert.ToInt32(parcial3[numer - 1]) + totalP3;
                    ClsArreglos Prom = new ClsArreglos(datoU[2], datoU[3], datoU[4]);
                    double general = Prom.promedioG();
                    listBoxPromedio.Items.Add(Math.Round(general, 2));
                }
                numer++;
            }
            prom1 = totalP1 / parcial1.Length;
            prom2 = totalP2 / parcial2.Length;
            prom3 = totalP3 / parcial3.Length;

            labelp1.Text = Convert.ToString(Math.Round(prom1, 2));
            labelp2.Text = Convert.ToString(Math.Round(prom2, 2));
            labelp3.Text = Convert.ToString(Math.Round(prom3, 2));
        }

        private void buttonCargarArchivo_Click(object sender, EventArgs e)
        {
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Porfa, selecciona tu archivo plano";
            ofd.InitialDirectory = @"C:\Users\ramos\Desktop\Programación l, Stiven Ramos\Arreglos";
            ofd.Filter = "Archivo Plano (*.csv)|*.csv";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArchivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                

            }

            buttonCargarArchivo.Visible = false;
            
            
            label1.Visible = true;
            labelp1.Visible = true;
            labelp2.Visible = true;
            labelp3.Visible = true;
            listBox1.Visible= true;
            listBox2.Visible = true;
            listBox3.Visible = true;
            listBoxOrdenado.Visible = true;
            listBoxOrdenado.Visible = true;
            listBoxResultado.Visible = true;
            buttonDatos.Visible = false;
            buttonDatos.Visible = true;
            listBoxPromedio.Visible = true;
        }

        private void buttonNombres_Click(object sender, EventArgs e)
        {

            buttonOrdenar.Visible = true;
            buttonDatos.Visible = false;
            buttonOrdenar.Visible = true;
            buttonArreglo.Visible = true;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(',');
                listBoxResultado.Items.Add(datosUnitarios[1]);
                listBox1.Items.Add(datosUnitarios[2]);
                listBox2.Items.Add(datosUnitarios[3]);
                listBox3.Items.Add(datosUnitarios[4]);
               
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            int cont = 0; 
            string[] nombres = new string[ArregloNotas.Length - 1];
            foreach (string linea in ArregloNotas)
            {
                if (cont != 0)
                {
                    string[] datos = linea.Split(',');
                    nombres[cont - 1] = datos[1];
                }
                cont++;
            }
            ClsArreglos ordenar = new ClsArreglos(nombres);
            string[] resul = ordenar.MetodoBurbuja();
            for (int i = 0; i < resul.Length; i++)
            {
                listBoxOrdenado.Items.Add(resul[i]);
            }

            buttonOrdenar.Enabled = false;
        }

        private void buttonMay_Menor_Click(object sender, EventArgs e)
        {
          
        }

    }
}
