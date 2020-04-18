using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Vientos viento1 = new Vientos("Trompeta");
            Vientos viento2 = new Vientos("Flauta");

            Console.WriteLine(viento1.Inst.Name);
            Console.WriteLine(viento2.Inst.Name);



        }
    }
}
