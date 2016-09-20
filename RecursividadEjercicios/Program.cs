using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionParcial1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Recursividad ejercicios = new Recursividad();
            
            string palabra = "";
            Console.WriteLine("Ingrese una palabra: ");
            palabra = Console.ReadLine();

            Console.WriteLine(ejercicios.Pal(palabra));

            Console.WriteLine(ejercicios.Primo(5));
            Console.WriteLine(ejercicios.Primo(6));
            Console.ReadLine();
        }     
    }
}
