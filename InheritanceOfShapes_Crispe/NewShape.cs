
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace InheritanceOfShapes_Crispe
{
    internal class NewShape
    {
        private string Name;
        private int Sides;
        public NewShape()
        {

        }

        public NewShape(string Name, int Sides)
        {
            this.name = Name;
            this.sides = Sides;
        }

        public string name { get => Name; set => Name = value; }
        public int sides { get => Sides; set => Sides = value; }

        public override string ToString()
        {
            return "\nName: " + this.name + "\nNo of Sides: " + this.sides + "\nArea: " + this.ComputeArea() + "\nPerimeter: " + this.ComputePerimeter();
        }

        public virtual double ComputeArea()
        {
            return 0.0;
        }

        public virtual double ComputePerimeter()
        {
            return 0.0;
        }
    }
}