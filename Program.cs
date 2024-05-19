using GuiaHerencia;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


public class Program 
{
    static void Main()
    {
        List<Telefono> InventarioTel = new List<Telefono>();


        bool continuar = true;
        while (continuar)
        {
            Console.WriteLine("Registro De Celulares: ");
            Console.WriteLine("Seleccione Una Opción");

            Console.WriteLine("1. Registrar Telefono");
            Console.WriteLine("2. Mostrar Telefonos Registrados");
            Console.WriteLine("3. Consultar Stock de un Telefono");
            Console.WriteLine("4. Salir ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarTelefono(InventarioTel);
                    break;

                case "2":
                    MostrarTelefonosRegistrados(InventarioTel);
                    break;

                case "3":
                    ConsultarStockTelefono(InventarioTel);
                    break;

                case "4":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine("Opcion Invalida. Por favor seleccione una opcion correcta (1/2/3/4)");
                    break;
            }
        }
    }

    static void RegistrarTelefono(List<Telefono> inventarioTel)
    {
        Console.WriteLine("Que Tipo de Celular Desea Registrar? (Inteligente(A)/Basico(B)):");
        string tipoTelefono = Console.ReadLine();
       
        if (tipoTelefono == "A")
        {
            TefInteligente inteligente = new TefInteligente();

            Console.Write("Marca: ");
            inteligente.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            inteligente.Modelo = Console.ReadLine();

            Console.Write("Precio: ");
            inteligente.Precio = Convert.ToDouble(Console.ReadLine());

            Console.Write("Microfono : ");
            inteligente.Microfono = Convert.ToDouble(Console.ReadLine());

            Console.Write("Capacidad de Bateria (en mAh): ");
            inteligente.Bateria = Convert.ToDouble(Console.ReadLine());

            Console.Write("Pantalla: ");
            inteligente.Pantalla = Console.ReadLine();

            Console.Write("Sistema Operativo: ");
            inteligente.SistemaOperativo = Console.ReadLine();

            Console.Write("Memoria RAM (en GB): ");
            inteligente.Almacenamiento = Convert.ToInt32(Console.ReadLine());

            Console.Write("Seguridad (Huella dactilar, reconocimiento facial, etc.): ");
            inteligente.Seguridad = Console.ReadLine();

            Console.Write("Conectividad (Wi-Fi, Bluetooth, etc.): ");
            inteligente.Conectividad = Console.ReadLine();

            Console.Write("Asistente Virtual (Siri, Alexa, etc.): ");
            inteligente.AsistenteVirtual = Console.ReadLine();

            Console.Write("MegaPixeles de la Camara Principal: ");
            inteligente.MegaPixeles = Convert.ToInt32(Console.ReadLine());

            inventarioTel.Add(inteligente);

            Console.WriteLine("Celular Inteligente registrado exitosamente.");

        }
        else if (tipoTelefono == "B")
        {
            TelefonoBasico telefonoBasico = new TelefonoBasico();

            Console.Write("Marca: ");
            telefonoBasico.Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            telefonoBasico.Modelo = Console.ReadLine();

            Console.Write("Precio: ");
            telefonoBasico.Precio = Convert.ToDouble(Console.ReadLine());


            Console.Write("Microfono: ");
            telefonoBasico.Microfono = Convert.ToDouble(Console.ReadLine());


            Console.Write("Capacidad de Bateria (en mAh): ");
            telefonoBasico.Bateria = Convert.ToDouble(Console.ReadLine());


            Console.Write("Pantalla: ");
            telefonoBasico.Pantalla = Console.ReadLine();

            Console.Write("Tiene Linterna (true/false): ");
            telefonoBasico.TieneLinterna = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Tiene Radio Por Antena (true/false): ");
            telefonoBasico.RadioFMAntena = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Tiene Acceso Bluetooth (true/false): ");
            telefonoBasico.Bluetooth = Convert.ToBoolean(Console.ReadLine());

            Console.Write("Dimensiones Del Celular: ");
            telefonoBasico.Dimensiones = Console.ReadLine();

            inventarioTel.Add(telefonoBasico);
        }



    }


    static void MostrarTelefonosRegistrados(IEnumerable<Telefono> InventarioTel)
    {
        Console.WriteLine("Celulares Registrados: ");

        //Creamos una estructura foreach para mostrar los celulares registrados 

        foreach (Telefono telefono in InventarioTel)
        {
            if (telefono is TefInteligente)
            {
                ((TefInteligente)telefono).MostrarInfoInteligente();
            }
            else if (telefono is TelefonoBasico)
            {
                ((TelefonoBasico)telefono).MostrarInformacionBasico();
            }
        }
    }
    static void ConsultarStockTelefono(IEnumerable<Telefono> InventarioTel) 
    {
        Console.WriteLine("Ingrese el modelo del celular a consultar: ");
        string ModeloCons = Console.ReadLine();
        bool Encontrado = false;

        foreach (Telefono telefono in InventarioTel)
        {
            if (telefono.Modelo.ToLower() == ModeloCons.ToLower())
            {
                Encontrado = true;
                if (telefono is TefInteligente)
                {
                    ((TefInteligente)telefono).MostrarInfoInteligente();
                }
                else if (telefono is TelefonoBasico)
                {
                    ((TelefonoBasico)telefono).MostrarInformacionBasico();
                }
            }
        }

        if (!Encontrado)
        {
            Console.WriteLine("Error, Celular No Encontrado.");
        }



    }






}