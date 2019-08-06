using System;

namespace Proyecto_Senova1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Proyecto miprimerproyecto = new Proyecto();
            //Proyecto misegundoproyecto = new Proyecto();
            //Proyecto mitercerproyecto = new Proyecto();
            Proyecto proyecto4 = new Proyecto("Realidad aumentada" ,12540, "Sistema",12);
            //mitercerproyecto.IngresarProyecto();
            //mitercerproyecto.ImprimirProyecto();
            proyecto4.ImprimirProyecto();
            
            //
            //miprimerproyecto.Area = "Sistemas";
            //miprimerproyecto.Codigo = 12000;
            //miprimerproyecto.Duracion = 13;
            //misegundoproyecto.Nombre = "Desarrollo internet de las cosas IOT";
            //misegundoproyecto.Area = "Cocina";
            //misegundoproyecto.Codigo = 18046;
            //misegundoproyecto.Duracion = 20;
            //misegundoproyecto.Nombre = "Desarrollo de postres dulces";
            //
            //Console.WriteLine($"Nombre:{miprimerproyecto.Nombre}");
            //Console.WriteLine($"Area:{miprimerproyecto.Area}");
            //Console.WriteLine($"Codigo: {miprimerproyecto.Codigo}");
            //Console.WriteLine($"Duración: {miprimerproyecto.Duracion}");
            //Console.WriteLine($"Nombre:{misegundoproyecto.Nombre}");
            //Console.WriteLine($"Area:{misegundoproyecto.Area}");
            //Console.WriteLine($"Codigo: {misegundoproyecto.Codigo}");
            //Console.WriteLine($"Duración: {misegundoproyecto.Duracion}");
           Console.ReadLine();

        }
    }
}
