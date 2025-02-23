using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Triangle : Shape, IFaces, IShape
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {

            if (a > 10 || b > 10 || c > 10)
            {
                throw new Exception("Cannot be greater then 10");
            }

            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new Exception("Please recheck the sides");
            }

            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double GetArea()
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c)); ;
        }

        public int GetFaces()
        {
            throw new NotImplementedException();
        }
    }
}
