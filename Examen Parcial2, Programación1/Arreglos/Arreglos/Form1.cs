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

        private void buttonArreglo_Click(object sender, EventArgs e)
        {
            string[,] ArregloDoDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(',');
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                NumeroLinea++;
            }
            ClsInterPromedio NotaMayor = new ClsInterPromedio();
            string Mayor = NotaMayor.nombre_nota_mayor(ArregloDoDimensiones, ArregloNotas);
            labelMejorPro.Text = Mayor;



        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            PGB.Visible = true;
            PGC.Visible = true;
            PGD.Visible = true;
            PGA.Visible = true;
            listBoxParcial1.Visible = true;
            buttonNames.Visible = true;
            buttonArreglo.Visible = true;
            listBoxNombres.Visible = true;
            listBoxResultado.Visible = true;
            listBoxSumaExaamenes.Visible = true;
            buttonCargar.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            labelMejorPro.Visible = true;
            listBoxParcial1.Visible = true;
            listBoxParcial2.Visible = true;
            listBoxParcial3.Visible = true;
            listBoxSección.Visible = true;
            ClsArchivo ar = new ClsArchivo();
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Selecciona tu archivo plano";
            ofd.InitialDirectory = @"C: \Users\ramos\Desktop\Programación l, Stiven Ramos\Parcial ll Programacion 1, Stiven Ramos";
            ofd.Filter = "Archivo plano (*.csv)|*.csv";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var archivo = ofd.FileName;
                string resultado = ar.LeerTodoArhivo(archivo);
                ArregloNotas = ar.LeerArchivo(archivo);
                
            }
        }

        private int Fncpromedios(string[,]matriz, int columna)
        {
            int acumulador = 0;
            double promedio;
            int totalFilas = matriz.GetLength(0);
            int totalColumas = matriz.GetLength(1);
            for (int fila = 1; fila < totalFilas; fila++)
            {
                acumulador = acumulador + Convert.ToInt32(matriz[fila, columna]);
            }
            promedio = acumulador / (totalFilas-1);
            return Convert.ToInt32(promedio);
        }

        private void buttonNames_Click(object sender, EventArgs e)
        {
            int NumeroLinea = 0;
            string[,] ArregloDosDimensiones = new string[ArregloNotas.Length,5];
            foreach (string Linea in ArregloNotas)
            {
                
                string[] datosUnitarios = Linea.Split(',');
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Correlativo] = datosUnitarios[0];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Nombre] = datosUnitarios[1];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDosDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                NumeroLinea++;
                listBoxResultado.Items.Add($"{datosUnitarios[enumColumnas.Correlativo]}");
                listBoxSección.Items.Add($"{datosUnitarios[enumColumnas.Seccion]}");
                listBoxParcial1.Items.Add($"{datosUnitarios[enumColumnas.Parcial1]}");
                listBoxParcial2.Items.Add($"{datosUnitarios[enumColumnas.Parcial2]}");
                listBoxParcial3.Items.Add($"{datosUnitarios[enumColumnas.Parcial3]}");
            }
            int Promedio=Fncpromedios(ArregloDosDimensiones,enumColumnas.Parcial3);
            
            ClsInterPromedio Mostrar = new ClsInterPromedio();
            string[,] MostrarAlumnos = Mostrar.Clasificar_Alumnos(ArregloDosDimensiones);
            for (int i = 0; i < ArregloNotas.Length; i++)
            {
                listBoxNombres.Items.Add(MostrarAlumnos[i, 0]+".......................................");
                listBoxSumaExaamenes.Items.Add(MostrarAlumnos[i, 1]);
            }
            MessageBox.Show($"El Promedio del parcial  es {Promedio}");
            buttonNames.Enabled = false;
        }

        private void listBoxSumaExaamenes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] ArregloDoDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(',');
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                NumeroLinea++;
            }
            ClsInterPromedio Promedio = new ClsInterPromedio();
            double General = Promedio.promedio_general_seccion(ArregloDoDimensiones, "A");
            MessageBox.Show($"El Promedio general de la Sección A es {Convert.ToString(Math.Round(General, 2))}");



        }

        private void PGB_Click(object sender, EventArgs e)
        {
            string[,] ArregloDoDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(',');
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                NumeroLinea++;
            }
            ClsInterPromedio Promedio = new ClsInterPromedio();
            double General = Promedio.promedio_general_seccion(ArregloDoDimensiones, "B");
            MessageBox.Show($"El Promedio general de la Sección B es {Convert.ToString(Math.Round(General, 2))}");


        }

        private void PGC_Click(object sender, EventArgs e)
        {
            string[,] ArregloDoDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(',');
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                NumeroLinea++;
            }
            ClsInterPromedio Promedio = new ClsInterPromedio();
            double General = Promedio.promedio_general_seccion(ArregloDoDimensiones, "C");
            MessageBox.Show($"El Promedio general de la Sección C es {Convert.ToString(Math.Round(General, 2))}");
        }

        private void PGD_Click(object sender, EventArgs e)
        {
            string[,] ArregloDoDimensiones = new string[ArregloNotas.Length, 6];
            int NumeroLinea = 0;
            foreach (string linea in ArregloNotas)
            {
                string[] datosUnitarios = linea.Split(',');
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial1] = datosUnitarios[2];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial2] = datosUnitarios[3];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Parcial3] = datosUnitarios[4];
                ArregloDoDimensiones[NumeroLinea, enumColumnas.Seccion] = datosUnitarios[5];
                NumeroLinea++;
            }
            ClsInterPromedio Promedio = new ClsInterPromedio();
            double General = Promedio.promedio_general_seccion(ArregloDoDimensiones, "D");
            MessageBox.Show($"El Promedio general de la Sección D es {Convert.ToString(Math.Round(General, 2))}");
        }
    }
}
