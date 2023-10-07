using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzeria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pizzero = new Pizzero();
            var cliente = new Cliente(pizzero);
            cliente.RealizarPedido();
            Console.ReadLine();
        }
    }
}
