using System;

namespace TreehouseDefense
{
  class Point
  {
    public readonly int X;
    public readonly int Y;

    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }

    public int DistanceTo(int x, int y)
    {
      // Cartesian distance formula:
      // sqrt of the sum of the square of the differences of each component
      // i.e., sqrt((x2 - x1)^2 + (y2 - y1)^2)

      int xDiff = X - x;
      int yDiff = Y - y;

      int xDiffSquared = xDiff * xDiff;
      int yDiffSquared = yDiff * yDiff;

      return (int)Math.Sqrt(xDiffSquared + yDiffSquared);
    }

    public int DistanceTo(Point point)
    {
      return DistanceTo(point.X, point.Y);
    }
  }
}