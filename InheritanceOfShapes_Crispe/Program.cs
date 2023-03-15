using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceOfShapes_Crispe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================================================");

            NewShape sh1 = new NewShape();
            sh1.name = "First shape";
            sh1.sides = 0;
            Console.WriteLine(sh1);

            NewShape sh2 = new NewShape("Second shape", 0);
            Console.WriteLine(sh2);


            Console.WriteLine("======================================================================");

            Square sq = new Square("The Square: ", 4, 2);
            Console.WriteLine(sq);

            Rectangle re = new Rectangle("The Rectangle: ", 4, 3, 5);
            Console.WriteLine(re);



        }
    }
}
