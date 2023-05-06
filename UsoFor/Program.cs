using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoFor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso del For
            int i; 
            Console.WriteLine("*******Ejemplo de For*******");
            Console.WriteLine("Imprime numeros de 1 hasta el 10");
            for (i = 1; i <= 10; i++)
                Console.WriteLine(i);
            Console.ReadLine(); 
        }
    }
}
