using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Day_12Part2
{
    public class HerbalProducts : Products
    {
        string herbsused;
        DateTime mfdate;
        DateTime expdate;

        public HerbalProducts()
        {
            Console.WriteLine("herbalproduct constructor is called");
        }
        public override void Register()
        {
            base.Register();
            Console.WriteLine("enter herbsused");
            herbsused = Console.ReadLine();
            mfdate = DateTime.Now;
            expdate = DateTime.Now.AddYears(4);
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("herbs used:"+herbsused);
            Console.WriteLine("manufacture date:"+mfdate);
            Console.WriteLine("expiry date:"+expdate);
        }

    }

}
       
    

