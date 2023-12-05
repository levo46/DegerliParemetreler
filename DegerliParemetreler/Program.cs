using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerliParemetreler
{
    class Sinifim
    {
        public void Selamla(string Ad = " Hasan")
        {
            Console.WriteLine("Merhaba "+Ad);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Sinifim sinifim = new Sinifim();
            sinifim.Selamla();
            sinifim.Selamla("Efe ");
        }
    }
}
