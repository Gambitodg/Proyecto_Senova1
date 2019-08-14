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
        public List<Proyecto> proyectos = new List<Proyecto>();

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
        public Proyecto(string area, int duracion)
        {

        }

        public Proyecto()
        {

        }
        #endregion

        #region Métodos

        public void IngresarProyecto()
        {
            var res = "y";
            while (res == "y")
            {
                Proyecto miproyecto = new Proyecto();

                Console.WriteLine("Ingrese el nombre del proyecto");
                miproyecto.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese el codigo del proyecto");
                miproyecto.Codigo = double.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el area del proyecto");
                miproyecto.Area = Console.ReadLine();
                Console.WriteLine("Ingrese el duración del proyecto");
                var dura = Console.ReadLine();
                miproyecto.Duracion = int.Parse(dura);

                proyectos.Add(miproyecto);

                Console.WriteLine("Desea ingresar otro proyecto");
                res = Console.ReadLine();
            }


        }
        public void ImprimirProyecto(List<Proyecto> proyecto1)
        {
            foreach (var item in proyecto1)
            {
                Console.WriteLine("Proyecto");
                Console.WriteLine();
                Console.WriteLine($"El Nombre del proyecto es: {item.Nombre}");
                Console.WriteLine($"El Codigo del proyecto es: {item.Codigo}");
                Console.WriteLine($"El Area del proyecto es: {item.Area}");
                Console.WriteLine($"El Duracion del proyecto es: {item.Duracion}");
            }



        }

        public void ObtenerMayores()
        {
            List<Proyecto> pro20 = new List<Proyecto>();

            foreach (var item in proyectos)
            {
                if (item.Codigo > 20)
                {
                    Pro20.Add(item);
                }
            }

        }
        ImprimirProyecto(pro20);
    }
    #endregion


}

