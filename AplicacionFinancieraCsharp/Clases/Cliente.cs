using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionFinancieraCsharp.Clases
{
    public class Cliente
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }

        public Cliente()
        {
            DNI = "";
            Nombre = "";
            Telefono = "";
        }

        public Cliente(string dni, string nombre, string telefono)
        {
            DNI = dni;
            Nombre = nombre;
            Telefono = telefono;
        }

    }
}
