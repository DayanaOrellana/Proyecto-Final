using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Vehiculos
{
    internal class Convertible: VehivuloBase
    {
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int anio { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }
        public int velocidadMaxima { get; }
        public int velocidadActual { get; }
        private int Encendido = 0;
        private int velocidad_actual = 0;
        private int frena_o_te_vas_para_el_cielo = 0;
        private int sonido = 0;
        public void bocina()
        {
            if (sonido == 0)
            {
                Console.WriteLine($"Las bocinas funcionan bien ");
                sonido = 0;
            }
            else
            {
                Console.WriteLine("ups, las bocinas no estan funcionnado correctamente ");
            }
        }
        public void acelerar(int daleee)
        {
            if (Encendido == 1)
            {
                velocidad_actual += daleee;
                Console.WriteLine($"runrunrun has encendido el carro ");
                Encendido = 1;
            }
            else
            {
                Console.WriteLine("ups, el carro ya estaba encendido");
            }
        }
        public void encender()
        {
            if (Encendido == 0)
            {
                Console.WriteLine($"runrunrun tu carro esta encendido y listo");
                Encendido = 1;
            }
            else
            {
                Console.WriteLine("ups, el carro ya estaba encendido ");
            }

        }
        public void apagar()
        {
            if (Encendido == 0)
            {
                Console.WriteLine($"runrunrun el carro se apago");
                Encendido = 0;
            }
            else
            {
                Console.WriteLine("ups, el carro ya estaba apagado");
            }
        }
        public void frenar(int cuanto)
        {
            if (frena_o_te_vas_para_el_cielo == 0)
            {
                Console.WriteLine($"ufffff has frenado");
                frena_o_te_vas_para_el_cielo = 0;
            }
            else
            {
                Console.WriteLine("ups, el carro esta en P ");
            }
        }
    

    //propiedades
    public void Pasajeros()
        {
            Console.WriteLine("Los convertibles pueden ser de 2 o 4 pasajeros");
        }

        public void Techo()
        {
            Console.WriteLine("El techo es recactil o puede quitars, plegarse o guardarse en el maletero");
        }

        public void Libertad()
        {
            Console.WriteLine("Sensacion de libertar que brinda ");
        }
        //metodo
        public void Carroceria()
        {
            Console.WriteLine("Carroceria de tres Volumenes ");
        }

        internal void acelerar()
        {
           // throw new NotImplementedException();
        }

        internal void frenar()
        {
           // throw new NotImplementedException();
        }
    }
}
