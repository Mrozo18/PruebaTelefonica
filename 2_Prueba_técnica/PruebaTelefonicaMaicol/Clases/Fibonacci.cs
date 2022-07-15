using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTelefonicaMaicol.Clases
{
    public class Fibonacci
    {
        public string SerieFibonacci(int limite)
        {
            string array = "0";
            try
            {
                int a, b, i, auxiliar;

                a = 0;
                b = 1;
                for (i = 0; i < limite; i++)
                {
                    auxiliar = a;
                    a = b;
                    b = auxiliar + a;

                    array = array + " " + a + " ";
                }

                return array;
            }
            catch (ArgumentException excArgu)
            {
                array = "Error " + excArgu.ToString();
            }
            return array;
        }
    }
}