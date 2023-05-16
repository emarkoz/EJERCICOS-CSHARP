using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion5
{
    internal class Matematicas
    {
        private double numero1, numero2, resultado;

        public void Sumar()
        {
            Console.WriteLine("Dame el primer numero");
            numero1= Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Dame el segundo numero");
            numero2 = Convert.ToDouble(Console.ReadLine());

            resultado = numero1 + numero2;

            Console.WriteLine("El resultado de la suma es: {0} + {1} = {2}", numero1, numero2, resultado);
        }

        public void Restar(double num1Pa, double num2Pa) //parametros
        {
            
            resultado = num1Pa - num2Pa; //operacion con parametros recibidos de argumentos en Program.cs
            Console.WriteLine("El resultado de la resta es: {0} - {1} = {2}", num1Pa, num2Pa, resultado);
        }
        public void Multiplicar()
        {
            Console.WriteLine("Dame el primer numero");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero");
            numero2 = Convert.ToDouble(Console.ReadLine());
            resultado = numero1 * numero2;
            Console.WriteLine("El resultado de la multiplicacion es: {0} * {1} = {2}", numero1, numero2, resultado);
        }
        public void Dividir()
        {
            Console.WriteLine("Dame el primer numero");
            numero1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Dame el segundo numero");
            numero2 = Convert.ToDouble(Console.ReadLine());
            resultado = numero1 / numero2;
            Console.WriteLine("El resultado de la division es: {0} / {1} = {2}", numero1, numero2, resultado);
        }
    }
}
