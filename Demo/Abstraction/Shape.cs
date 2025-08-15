using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Abstraction
{
    internal abstract class Shape
    {
        public decimal Dim01 { get; set; }
        public decimal Dim02 { get; set; }

        public abstract decimal CalcArea();

        public abstract decimal Perimeter {  get; }
    }
    class Rectangle : Shape
    {
        public override decimal Perimeter
        {
            get { return Dim01 * Dim02 * 2; }
        }

        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
    class Square : Shape
    {
        public Square(decimal side)
        {
            Dim01 = Dim02 = side;
        }
        public override decimal Perimeter
        {
            get { return Dim01 * 4; }
        }

        public override decimal CalcArea()
        {
            return Dim01 * Dim02;
        }
    }
    class Circle : Shape
    {
        public Circle(decimal Radius)
        {
            Dim01 = Dim02 = Radius;
        }
        public override decimal Perimeter
        {
            get { return 2 * Dim01 * 3.14m; }
        }

        public override decimal CalcArea()
        {
            return 3.14M * Dim01 * Dim02;
        }
    }
}
