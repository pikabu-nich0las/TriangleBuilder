namespace Triangle
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class PointsBuilder
	{
		public List<Point> Build(Polygon polygon, Double interval, DrawingDirection direction)
		{
			List<Point> points = polygon.Vertices.Select(v => new Point(v)).ToList();
			List<Point> basis = polygon.Vertices.Select(v => new Point(v)).ToList();

			switch (direction)
			{
				case DrawingDirection.Clockwise:
					break;
				case DrawingDirection.Anticlockwise:
					points.Reverse();
					basis.Reverse();
					break;
				default:
					throw new ArgumentException($"{nameof(DrawingDirection)}.{direction} is not supported");
			}

			points.Add(new Point(points[0]));

			Int32 recalculatedIndex = 1;
			Int32 nextIndex = GetNextIndex(recalculatedIndex, basis.Count);

			while (Point.SegmentLength(basis[recalculatedIndex], basis[nextIndex]) - interval > 1e-2)
			{
				Point newPoint = CalculateNewPoint(basis[recalculatedIndex], basis[nextIndex], interval);
				points.Add(new Point(newPoint));			
				basis[recalculatedIndex] = new Point(newPoint);
				recalculatedIndex = nextIndex;
				nextIndex = GetNextIndex(recalculatedIndex, basis.Count);
			}

			return points;
		}

		private static Int32 GetNextIndex(Int32 currentIndex, Int32 arrayLength)
			=> currentIndex >= arrayLength - 1
				? 0
				: currentIndex + 1;

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
