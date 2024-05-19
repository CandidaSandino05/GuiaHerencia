using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaHerencia
{
    public  class TefInteligente : Telefono
    {
        public string SistemaOperativo { get; set; }
        public int Almacenamiento { get; set; }
        public string Seguridad { get; set;  }
        public string  Conectividad { get; set; }
        public string AsistenteVirtual { get; set; }
        public int MegaPixeles { get; set; }
        public void MostrarInfoInteligente() 
        {
            MostrarInfoTelefono();
            Console.WriteLine($"Sistema Operativo: {SistemaOperativo}, CapacidadDeMemoria: {Almacenamiento}GB, Seguridad en el celular: {Seguridad}, Conecciones: {Conectividad}, AsistenteVirtual: {AsistenteVirtual}, Resolucion: {MegaPixeles}");
        }

    }
}
