using System;
using System.Collections.Generic;
using System.Text;

namespace carrito.Clases
{
    class ClsAutoMotor
    {
        public string marca { get; }
        public int vel_max { get; }
        public String color { get; set; }
        private int velocidadActual = 0;
        public bool encendido { get; set; }

        public ClsAutoMotor(string marcaCarro, int MaxVel)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCarro;
        }
        public ClsAutoMotor(string marcaCarro, int MaxVel, string colorCarro)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCarro;
            this.color = colorCarro;
        }

        public string encender()
        {
            if (encendido)
            {
                return "Lo siento, el carro ya esta encendido";
            }
            else
            {
                velocidadActual = 0;
                encendido = true;
                return "Listo, ponte el cinturón de seguridad ";
            }
        }

        public string DetenerMarcha()
        {
            if (!encendido)
            {
                return "Enciende el carro Primero!";
            }

            velocidadActual = 0;
            return "Auto Detenido";
        }
        public string Acelerar()
        { if (!encendido)
            {
                return "Enciende el carro Primero!"; 
            }
            if (velocidadActual > vel_max)
            {
                velocidadActual = vel_max;
                return $"ALERTA, ya llegaste al tope {vel_max}KPH";
                
            }
            else
            {
                velocidadActual = velocidadActual + 10;
                return $"{velocidadActual}KPH";
                
            }
            
        }

        public string Frenar()
        {
            if (velocidadActual == 0)
            {
                return $"Acelera antes";
                
                
            }
            else
            {
               velocidadActual= velocidadActual - 10;
                return $"{velocidadActual}KPH";
            }
        }

        public bool cambios()
        {
            bool cambio;
            switch (velocidadActual)
            {
                case 10:
                     
                    
                case 30:
                  
                case 60:
                   
                case 90:
                 
               
                    cambio = false;
                    break;
                default:
                    cambio = true;
                    break;
            }
            
            return cambio;
        }

        public bool activapalanca()
        {
            bool cambio;
            switch (velocidadActual)
            {
                case 10:


                case 30:

                case 60:

                case 90:


                    cambio = true;
                    break;
                default:
                    cambio = false;
                    break;
            }

            return cambio;
        }

        public string Nvelocidad()
        {
            string velocidad="";
            if (velocidadActual == 10)
            {

                velocidad = "2";
            }
            else if (velocidadActual == 30)
                velocidad = "3";
            else if (velocidadActual == 60)
                velocidad = "4";
            else if (velocidadActual == 90)
                velocidad = "5";

            return velocidad;
        }
    }



}
