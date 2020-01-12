namespace Triangle
{
	using System;
	using System.Collections.Generic;

	public class PointsBuilder
	{
		public List<Point> Build(Triangle triangle, Double interval, DrawingDirection direction)
		{
			List<Point> points;

			switch (direction)
			{
				case DrawingDirection.Clockwise:
					points = new List<Point> { triangle.Vertex1, triangle.Vertex2, triangle.Vertex3, triangle.Vertex1 };
					break;
				case DrawingDirection.Anticlockwise:
					points = new List<Point> { triangle.Vertex3, triangle.Vertex2, triangle.Vertex1, triangle.Vertex3 };
					break;
				default:
					throw new ArgumentException($"{nameof(DrawingDirection)}.{direction} is not supported");
			}

			var point1 = points[0];
			var point2 = points[1];
			var point3 = points[2];

			while (Point.SegmentLength(point2, point3) > interval)
			{
				var newPoint = CalculateNewPoint(point2, point3, interval);
				points.Add(newPoint);

				var oldPoint1 = new Point(point1);
				var oldPoint3 = new Point(point3);

				point1 = newPoint;
				point2 = oldPoint3;
				point3 = oldPoint1;
			}

			return points;
		}

		private static Point CalculateNewPoint(Point pointA, Point pointB, Double interval)
		{
			Double segmetLength = Point.SegmentLength(pointA, pointB);

			return new Point(
				x: pointA.X + interval * (pointB.X - pointA.X) / segmetLength,
				y: pointA.Y + interval * (pointB.Y - pointA.Y) / segmetLength
			);
		}
	}
}
