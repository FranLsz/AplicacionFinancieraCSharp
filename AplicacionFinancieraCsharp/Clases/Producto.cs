using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinancieraCsharp.Clases
{
    public abstract class Producto
    {
        public Cliente Cliente { get; set; }
        public double Saldo { get; set; }

        public abstract string Detalles();
        public abstract string Ingresar();
        public abstract string Sacar();


    }
}
