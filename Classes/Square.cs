
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public class Square : Shape, IFaces, IShape
    {
        private double side;

        public Square(double s) 
        {
            if (s > 10)
            {
                throw new Exception("Cannot be greater then 10");
            }

            side = s;
        }

        public Square() { }

        public void SetSide(double s)
        {
            side = s;
        }

        public double GetArea()
        {
            return side * side; 
        }

        public int GetFaces()
        {
            throw new NotImplementedException();
        }

        public readonly int Sides;

    }
}
