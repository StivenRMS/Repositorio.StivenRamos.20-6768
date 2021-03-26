using carrito.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace carrito
{
    public partial class Form1 : Form
    {
        ClsAutoMotor carrito ;
        public Form1()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("Meches",130);
            
            carrito.color = "Blanco";

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max}KPH");
            
            buttonAcelerar.Visible = true;
            buttonALTOTOTAL.Visible = true;
            pictureBox1.Visible = true;
            labelEstadoVelocidad.Visible = true;
            buttonEncender.Visible = true;
            button1.Visible = false;
            buttonFreno.Visible = true;
            buttonBMW.Visible = true;
            buttonPlay.Visible = true;
            stop.Visible = true;
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
           
            
                
                labelEstado.Text = $"El carro {carrito.marca} : {carrito.encender()}";
            

            
        }

        

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Crea el carro primero");
            }
            else
            {
                labelEstadoVelocidad.Text = carrito.Acelerar();
               

            }
            pictureBox1.Enabled = true;
           
            
            
                buttonAcelerar.Enabled = carrito.cambios();
                button2.Visible = carrito.activapalanca();
            if (button2.Visible == true) {
                labelNVel.Text = $"Vas en: {carrito.Nvelocidad()}";
                labelNVel.Visible = false;

            }
            else { labelNVel.Visible = true; }


        }

        private void buttonBMW_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("BMW", 200,"NEGRO");

            carrito.color = "Negro";
            buttonBMW.Visible = false;

            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max}KPH");
        }

        private void buttonALTOTOTAL_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.DetenerMarcha();
            pictureBox1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\ramos\Desktop\ani.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            labelEstadoVelocidad.Parent = pictureBox1;
            labelEstado.Parent = pictureBox1;
            labelNVel.Parent = pictureBox1;
            buttonPlay.Parent = pictureBox1;
            stop.Parent = pictureBox1;
            pictureBox1.Enabled = false;
        }

        private void buttonFreno_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.Frenar();
            if (labelEstadoVelocidad.Text== "0KPH")
            {
                pictureBox1.Enabled = false;
            }
            if (labelEstadoVelocidad.Text == "20KPH")
            {

                
                button2.Visible = true;
            }

            buttonAcelerar.Enabled = carrito.cambios();
            button2.Visible = carrito.activapalanca();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            buttonAcelerar.Enabled = true;
            button2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\ramos\Downloads\music.wav";
            player.Play();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = @"C:\Users\ramos\Downloads\music.wav";
            player.Stop();
        }
    }
}
