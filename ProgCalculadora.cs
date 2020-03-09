using System.Collections.Generic;
using System;

namespace ProgCalculadora
{
    class ProgCalculadora
    {
        static void Main(string[] args)
        {

            System.Console.Write("\n\n    5 + 2,9 = ");
            calculadora c = new calculadora();
            c.addNumero(5);
            c.addNumero(2.9);
            System.Console.WriteLine(c.somar());

            System.Console.Write("\n\n    10 -5 -2 = ");
            c.addNumero(10);
            c.addNumero(5);
            c.addNumero(2);
            System.Console.WriteLine(c.subtrair());

            System.Console.Write("\n\n    10 *2 *2 = ");
            c.addNumero(10);
            c.addNumero(2);
            c.addNumero(2);
            System.Console.WriteLine(c.multiplicar());

            System.Console.Write("\n\n    6/2/2= ");
            c.addNumero(6);
            c.addNumero(2);
            c.addNumero(2);
            System.Console.WriteLine(c.Dividir());


        }
    }
}