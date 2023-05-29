using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final.Vehiculos
{
    internal interface IVehiculos
    {
        public int id { get; set; }
        public string marca { get; set; }
        public string modelo { get; set; }
        public string color { get; set; }
        public int anio { get; set; }
        public string placa { get; set; }
        public string tipo { get; set; }
        public int velocidadMaxima { get; set; }
        public int velocidadActual { get; set; }
        public void bocina();
        public void acelerar(int cuanto);
        public void encender();
        public void apagar();
        public void frenar(int cuanto);
    }
}
