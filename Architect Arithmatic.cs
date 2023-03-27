using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(Rect(4, 5));
      Console.WriteLine(Circle(4));
      Console.WriteLine(Triangle(10, 9));

      double teoRect = Rect(1500, 2500);
      double teoCircle = Circle(375)/2;
      double teoTriangle = Triangle(750, 500);
      double teoTotalArea = teoRect + teoCircle + teoTriangle;
      double teoCost = Math.Round(teoTotalArea * 180, 2);
      Console.WriteLine($"The total material cost for architect floor plan Teotihuacan : {teoCost} pesos");
    }
    static double Rect(double length, double width)
    {
      double rectArea = (length * width);
      return rectArea;
    }
    static double Circle(double radius)
    {
      double circleArea = (Math.PI * Math.Pow(radius, 2));
      return circleArea;
    }
    static double Triangle(double bottom, double height)
    {
      double triangleArea = (0.5 * bottom * height);
      return triangleArea;
    }
  }
}
