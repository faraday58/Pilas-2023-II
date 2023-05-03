using System;
using System.Collections.Generic;
namespace Pilas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pila = new Stack<string>();

            pila.Push("Hola");
            pila.Push("Armando");

            for(int i= 0; i< pila.Count; i++  )
            {
                Console.Write(" {0} ", pila.Pop());
            }
            Console.ReadLine();
        }
    }
}
