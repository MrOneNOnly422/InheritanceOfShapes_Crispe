using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InheritanceOfShapes_Crispe
{
    internal class Rectangle: NewShape
    {
        private double lenght;
        private double width;

        public Rectangle()
        {
        }

        public Rectangle(string Name, int Sides, double lenght, double width)
        {
            base.name = Name;
            base.sides = Sides;
            this.Length = lenght;
            this.Width = width;
        }

        public double Width { get => width; set => width = value; }
        public double Length { get => lenght; set => lenght = value; }

        public override string ToString()
        {
            return "\nName: " + base.name + "\nNo of Sides: " + base.sides + "\nLength: " + this.Length + "\nWidth: " + this.Width + "\nArea: " + this.ComputeArea() + "\nPerimeter: " + this.ComputePerimeter();
        }

        public override double ComputeArea()
        {
            return this.Length * this.Width;
        }

        public override double ComputePerimeter()
        {
            return this.Length * 2 + this.Width * 2;
        }

    }
}