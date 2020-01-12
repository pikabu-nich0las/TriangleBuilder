namespace Triangle
{
	using System;

	public class Point
	{
		public Double X { get; set; }
		public Double Y { get; set; }

		public Point(Double x, Double y)
		{
			X = x;
			Y = y;
		}

		public Point(Point point)
		{
			X = point.X;
			Y = point.Y;
		}

		public static Point operator +(Point p1, Point p2)
			=> new Point(p1.X + p2.X, p1.Y + p2.Y);

		public static Point operator -(Point p1, Point p2)
			=> new Point(p1.X - p2.X, p1.Y - p2.Y);


		public void FlipVertical(Double relativeYCoordinate)
		{
			Y += 2 * (relativeYCoordinate - Y);
		}

		public static Double SegmentLength(Point a, Point b)
			=> Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
	}
}
