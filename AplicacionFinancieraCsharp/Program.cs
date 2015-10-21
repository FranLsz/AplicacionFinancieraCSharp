using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicacionFinancieraCsharp.Clases;

namespace AplicacionFinancieraCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc1 = new CuentaCorriente(new Cliente(), 2000, 500, 2.5);

            cc1.Sacar(2500);

            Console.Read();
        }
    }
}
