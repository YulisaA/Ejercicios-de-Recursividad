using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosdeRecursividad
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Recursividad ejercicios = new Recursividad();

            string palabra = "";
            int numero = 0;

            Console.WriteLine("PALÍNDROMOS: ");
            Console.WriteLine("Ingrese una palabra: ");
            palabra = Console.ReadLine();

            if (ejercicios.Pal(palabra) == true)
            {
                Console.WriteLine("La palabra [" + palabra + "] es palíndromo");
            }
            else
            {
                Console.WriteLine("La palabra [" + palabra + "] no es palíndromo");
            }

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("NÚMEROS PRIMOS: ");
            Console.WriteLine("Ingrese un número: ");
            numero = int.Parse(Console.ReadLine());

            if (ejercicios.Primo(numero) == true)
            {
                Console.WriteLine("El número [" + numero + "] es primo");
            }
            else
            {
                Console.WriteLine("El número [" + numero + "] no es primo");
            }

            Console.ReadLine();
        }     
    }
}
