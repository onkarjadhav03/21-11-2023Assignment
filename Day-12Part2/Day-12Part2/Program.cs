using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           HerbalProducts herbalProducts    = new HerbalProducts();
            herbalProducts.Register();
            herbalProducts.Display();
        }
    }
}
