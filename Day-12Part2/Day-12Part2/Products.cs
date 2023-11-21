using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_12Part2
{
    public class Products
    {
        int pid;
        double pprice;
        string pname;


        public Products()
        {
            Console.WriteLine("product constructor is called");
        }
                

        public virtual void Register()
        {
            Console.WriteLine("enter id");
            pid=int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            pname=Console.ReadLine();
            Console.WriteLine("enter price");
            pprice = int.Parse(Console.ReadLine());
        }

        public virtual void Display()
        {
            Console.WriteLine("product id:" + pid);
            Console.WriteLine("product name:" + pname);
            Console.WriteLine("product price:"+pprice);
        }
    }
}
