// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;

var square = new Square(10);

try
{
    square.SetArea(2);

    Console.WriteLine("The area is " + square.GetArea());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

var circle = new Circle(9);

try
{
    Console.WriteLine("The area is " + circle.GetArea());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}


try
{
    var triangle = new Triangle(3, 4, 5);
    Console.WriteLine("The area is " + triangle.GetArea());
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

ShapeColourHelper.AddColour(circle);

ShapeColourHelper.AddColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.ChangeColour(square);

Console.WriteLine(square.Colour);

ShapeColourHelper.RandomColour(square);

Console.WriteLine(square.Colour);


int numberOfSquares = 8;
Square[] squares = new Square[numberOfSquares];

for (int i = 0; i < numberOfSquares; i++)
{
    squares[i] = new Square(i+1); 
    ShapeColourHelper.RandomColour(squares[i]);
    Console.WriteLine(i+1 + " " + squares[i].Colour);
}


Console.ReadLine();
