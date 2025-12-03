using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Rectangle
    {
        private double length;
        private double breadth;

        // Expression-bodied properties
        public double Length
        {
            get => length;
            set => length = value;
        }

        public double Breadth
        {
            get => breadth;
            set => breadth = value;
        }

        // Constructor using expression-bodied form
        public Rectangle(double length, double breadth) =>
            (this.length, this.breadth) = (length, breadth);

        // Expression-bodied methods
        public double GetArea() => length * breadth;

        public double GetPerimeter() => 2 * (length + breadth);

        public string ShowDetails() =>
            $"Length: {length}, Breadth: {breadth}";
    }
}
