using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GuiaHerencia
{
    public  class Telefono
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Precio { get; set; }
        public int Stock { get; set; }
        public double Microfono { get; set; }
        public double Bateria { get; set; }  
        public string Pantalla{ get; set; }

        public void MostrarInfoTelefono() 
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}, Precio: ${Precio}, Stock: ${Stock}, Microfonos: {Microfono}, NivelBateria: {Bateria}mAh, Pantalla: {Pantalla}");

        }
    }
}
