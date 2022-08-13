using System;

namespace ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            //Captura de datos desde consola
            Console.WriteLine("introduzca un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("introduzca otro numero");
            num2 = int.Parse(Console.ReadLine());
            // llamado de funciones locales
            Console.WriteLine("la suma es: " + Suma(num1, num2));
            Console.WriteLine("la resta es: " + resta(num1, num2));
            Console.WriteLine("la multiplicacion es: " + Multi(num1, num2));
            Console.WriteLine(" la division es: " + Div(num1, num2));

             }




            
               

                
        }

       
    }
}
