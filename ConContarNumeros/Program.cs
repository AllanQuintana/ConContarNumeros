using System;

namespace ConContarNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, cont = 0;
            Console.WriteLine("ingrese numero");
            int.TryParse(Console.ReadLine(), out numero);
            while (numero != 0)
            {
                cont++;
                numero = numero / 10;
            }
            Console.WriteLine("la cantidad de digitos es de: " + cont);
        }
    }
}