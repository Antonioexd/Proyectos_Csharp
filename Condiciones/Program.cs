using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condiciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condiciones (if,else)
            int edad = 0;  

            Console.WriteLine("Introduza su edad: ");
            edad = int.Parse(Console.ReadLine());   

            if (edad > 18)
            {
                Console.WriteLine("Eres mayor de edad");
                Console.ReadKey();  
            }
            else
            { 
            Console.WriteLine("Eres menor de edad");
            Console.ReadKey();
            }
        }
    }
}
