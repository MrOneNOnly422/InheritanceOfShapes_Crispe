using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace InheritanceOfShapes_Crispe
{
    internal class Square : NewShape
    {
        private double side1;

        public Square()
        {
        }

        public Square(string Name, int Sides, double side1)
        {
           base.name = Name;
            base.sides = Sides;
            this.side1 = side1;
        }

        public double Side1 { get => side1;  set => side1 = value; }

        public override string ToString()
        {
            return   "\nName: " + base.name + "\nNo of Sides: " + base.sides + "\nLength of 1 side: " +this.Side1 + "\nArea: " + this.ComputeArea() + "\nPerimeter: " + this.ComputePerimeter();
        }

        public override double ComputeArea()
        {
            return Math.Pow(this.side1, 2);
        }

        public override double ComputePerimeter()
        {
            return this.Side1 * 4;
        }
    }
}