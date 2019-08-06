using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto_Senova1
{
    #region Atributos
    #endregion
    #region Propiedades
    public class Proyecto
    {
        public string Nombre { get; set; }
        public double Codigo { get; set; }
        public string Area { get; set; }
        public int Duracion { get; set; }

        #endregion

        #region Constructor
        public Proyecto(string nombre, double codigo, string area, int duracion)
    {
        Nombre = nombre;
        Codigo = codigo;
        Area = area;
        Duracion = duracion;
    }
    #endregion

        #region Métodos
        public void IngresarProyecto()
        {
            Console.WriteLine("Ingrese el nombre del proyecto");
            Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo del proyecto");
            Codigo = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el area del proyecto");
            Area = Console.ReadLine();
            Console.WriteLine("Ingrese el duración del proyecto");
            var dura = Console.ReadLine();
            Duracion = int.Parse(dura);

        }
        public void ImprimirProyecto()
        {
            Console.WriteLine($"El Nombre del proyecto es: {Nombre}");
            Console.WriteLine($"El Codigo del proyecto es: {Codigo}");
            Console.WriteLine($"El Area del proyecto es: {Area}");
            Console.WriteLine($"El Duracion del proyecto es: {Duracion}");

        }
        
    }
        #endregion

    
}
