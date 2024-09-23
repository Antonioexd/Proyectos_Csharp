using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones_y_metodos
{
    internal class Program
    {
        static int sumar(int a, int b)
        { 
        return a + b;
        }
        static void Saludar(string nombre)
        {
            Console.WriteLine($"hola, {nombre}!");
            Console.ReadKey();
        }

        static void Main(string[] arg)
        {
            Saludar("Antonio");

            int resultado = sumar (5, 7);
            Console.WriteLine("El resultado de la suma es: " + resultado);
            Console.ReadKey();  
        }
    }
}
