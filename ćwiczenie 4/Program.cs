using System;


interface IShape
{
    double GetArea();
}


class SquareAdapter : IShape
{
    private Square square;

    public SquareAdapter(Square square)
    {
        this.square = square;
    }

    public double GetArea()
    {
        return square.CalculateArea();
    }
}


class Square
{
    private double sideLength;

    public Square(double sideLength)
    {
        this.sideLength = sideLength;
    }

    public double CalculateArea()
    {
        return sideLength * sideLength;
    }
}

class Program
{
    static void Main(string[] args)
    {
        
        Square square = new Square(5);
        SquareAdapter adapter = new SquareAdapter(square);
        UseShape(adapter);
    }

    static void UseShape(IShape shape)
    {
        double area = shape.GetArea();
        Console.WriteLine($"Area: {area}");
    }
}
