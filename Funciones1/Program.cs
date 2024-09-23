using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones1
{
    internal class Program
    {
        //Calculadora con metodos
        //metodo para sumar
        static int Sumar (int a, int b)
        {
            return a + b;
        }

        //metodo para restar 
        static int Restar(int a, int b)
        {
            return a - b;
        }

        //metodo para multiplicar
        static int Multiplicar(int a, int b)
        {
            return a * b;
        }
        //metodo para dividir 
        static int Dividir (int a, int b)
        {
         if (b == 0)
            {
                Console.WriteLine("ERROR: No se puede dividir entre cero");
                return 0;
            }
            return (int)((double)a / b);

        }
        static void Main(string[] arg)
        {
            //ejemplo de uso de los metodos

            int num1 = 10;
            int num2 = 5;

            Console.WriteLine("El resultado de la suma es: " + Sumar(num1,num2));
            Console.WriteLine("El resultado de la resta es: " + Restar(num1,num2));
            Console.WriteLine("El resultado de la multiplicacion es: " + Multiplicar(num1,num2));
            Console.WriteLine("El resultado de la resta es: " + Dividir(num1,num2));

            Console.ReadLine();
        }
    }
}
