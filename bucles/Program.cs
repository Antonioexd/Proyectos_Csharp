using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Imprimir los numeros del 1 al 10 en orden inverso (del 10 al 1)
            /*for (int i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }*/

            // Sumar solo los numeros pares
            /*int sumar = 0;
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)//si el numero es par
                    {
                        sumar += i;
                    }
                }
                Console.WriteLine("La suma de los numeros pares del 1 al 100 es: " + sumar);
                Console.ReadLine();
            */

            //Perdirle al usuario que ingrese un numero  
            int num = 0;
            //bucle while que sigue pidiendo un numero hasta que el numero  sea mayor a 100
            while (num <= 100)
            {
                Console.WriteLine("Ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num == 100)
                { 
                Console.WriteLine("Llegaste al numero 100!");
                }
                else if (num > 100)
                {
                    Console.WriteLine("Pusiste un numero mayor a 100. Fin del programa :) ");
                }

            }
            Console.ReadLine();

        }
    }
}
