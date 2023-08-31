using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContarNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena = "abv7bkrjbv2902bnjfbd08c732bhbcwecjub74";

            int contador = 0;

            //forma1
            foreach (var c in cadena) 
            {
                if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
                {
                    contador++;
                }
            }
            Console.WriteLine("Cantidad de numeros: " + contador);

            //forma2
            string pattern = @"[0-9]";
            var regex = new Regex(pattern);
            int n = regex.Matches(cadena).Count;
            Console.WriteLine("Cantidad de numeros: " + n);

            //Contar letras
            string pattern2 = @"[a-z A-Z]";
            var regex2 = new Regex(pattern2);
            int n2 = regex2.Matches(cadena).Count;
            Console.WriteLine("Cantidad de letras: " + n2);

            Console.WriteLine("Numero total de caracteres: " + cadena.Length);

        }
    }
}
