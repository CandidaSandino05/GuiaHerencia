using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaHerencia
{
    public class TelefonoBasico : Telefono
    {
        public bool TieneLinterna { get; set; } 
        public bool RadioFMAntena { get; set; }
        public bool Bluetooth { get; set; }
        public string Dimensiones { get; set; }

        public void MostrarInformacionBasico() 
        {
            MostrarInfoTelefono();
            Console.WriteLine($"Linterna: {TieneLinterna}, Radio: {RadioFMAntena}, Bluetooth: {Bluetooth}, DimensionDelCelular: {Dimensiones}");

        }
    }
}
