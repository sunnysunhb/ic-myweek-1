
using Week1ObjectOriented.Interfaces;

namespace Week1ObjectOriented.Classes
{
    public static class ShapeColourHelper
    {
        private static readonly string[] colours = ["Yellow", "Red", "Blue", "Green", "Orange" ];

        public static Shape AddColour(Shape s)
        {
            s.Colour = "Red";

            return s;
        }

        public static Shape ChangeColour(Shape s)
        {
            s.Colour = "Blue";

            return s;
        }
        public static Shape RandomColour(Shape s)
        {
            Random random = new();
            int randomIndex = random.Next(colours.Length);
            s.Colour = colours[randomIndex];

            return s;
        }
    }
}
