using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ClsCalcular
{
    public class Calculadora : MarshalByRefObject
    {
        public Calculadora()
        {
        }
        public int suma(int a, int b)
        {
            return a + b;
        }
    }
}

