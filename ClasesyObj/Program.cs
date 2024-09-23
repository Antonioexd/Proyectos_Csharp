using System;

namespace ClasesyObj
{
    // Clase Persona con propiedades automáticas
    class Persona
    {
        public string Nombre { get; set; }
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 0)
                    edad = value;
                else
                    Console.WriteLine("Edad no válida.");
            }
        }

        private int edad;

        // Método para saludar
        public void Saludar()
        {
            Console.WriteLine($"Hola, mi nombre es {Nombre} y tengo {Edad} años.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona();

            // Usamos las propiedades automáticas
            persona1.Nombre = "Carlos";
            persona1.Edad = 20;

            persona1.Saludar();
        }
    }
}
