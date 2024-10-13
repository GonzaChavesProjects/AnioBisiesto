//Ejercicio 2

//Escribe un programa que tome un año introducido por el usuario y diga si es bisiesto o no. Recuerda
//que los años múltiplos de 4 son bisiestos, excepto aquellos que son múltiplos de 100 y no lo
//son de 400. Es decir, el año 2000 si es bisiesto, pero no lo son el 1990 ni el 2100.
//modificacion prueba
//modificacion 2 lado visual
//mod3
//mod4

using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Introduce un año: ");
            int año = int.Parse(Console.ReadLine());

            if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
            {
                Console.WriteLine($"El año {año} es bisiesto.");
            }
            else
            {
                Console.WriteLine($"El año {año} no es bisiesto.");
            }
        }
    }
}
