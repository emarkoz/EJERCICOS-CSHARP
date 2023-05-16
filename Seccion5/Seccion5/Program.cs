using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matematicas sumas = new Matematicas();
            int opcion;
            double num1Ar, num2Ar; //argumentos

            Console.WriteLine("Que operacion deseas realizar?");
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicacion");
            Console.WriteLine("4.- Division");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1) {
                sumas.Sumar();
            } else if (opcion == 2)
            {
                Console.WriteLine("Dame el primer numero");
                num1Ar = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Dame el segundo numero");
                num2Ar = Convert.ToDouble(Console.ReadLine());
                sumas.Restar(num1Ar, num2Ar); //pasando argumentos al metodo
                
            } else if (opcion == 3)
            {
                sumas.Multiplicar();
            } else if (opcion == 4)
            {
                sumas.Dividir();
            } else
            {
                Console.WriteLine("Opcion no valida");  
            }
            
           
            Console.ReadKey();
        }
    }
}
