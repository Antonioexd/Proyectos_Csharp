using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concep_Basicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naci = 2003;
            string nombre = "Antonio Estrada";
            double altura = 1.76;
            bool SoyProgramador = true;

            Console.WriteLine("Naci en el año: " + naci);
            Console.WriteLine("Mi nombre es: " + nombre);
            Console.WriteLine("Mido mas o menos unos: " + altura);
            Console.WriteLine("Soy programador: " + SoyProgramador);
            Console.ReadKey();
        }
    }
}
