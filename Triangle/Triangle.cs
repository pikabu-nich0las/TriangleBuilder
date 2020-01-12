namespace Triangle
{
	using System;

	public class Triangle
	{
		public Point Vertex1 { get; set; }
		public Point Vertex2 { get; set; }
		public Point Vertex3 { get; set; }

		public Triangle(Point vertex1, Point vertex2, Point vertex3)
		{
			Vertex1 = vertex1;
			Vertex2 = vertex2;
			Vertex3 = vertex3;
		}

		public Point GetCenter()
		{
			var minX = Min(Vertex1.X, Vertex2.X, Vertex3.X);
			var maxX = Max(Vertex1.X, Vertex2.X, Vertex3.X);
			var minY = Min(Vertex1.Y, Vertex2.Y, Vertex3.Y);
			var maxY = Max(Vertex1.Y, Vertex2.Y, Vertex3.Y);

			return new Point(
				(minX + maxX) / 2.0,
				(minY + maxY) / 2.0
			);
		}

		public void FlipVertical()
		{
			var minY = Min(Vertex1.Y, Vertex2.Y, Vertex3.Y);
			var maxY = Max(Vertex1.Y, Vertex2.Y, Vertex3.Y);
			var reltiveYCoordinate = (minY + maxY) / 2.0;

			Vertex1.FlipVertical(reltiveYCoordinate);
			Vertex2.FlipVertical(reltiveYCoordinate);
			Vertex3.FlipVertical(reltiveYCoordinate);
		}

		public static Boolean IsExist(Int32 side1Length, Int32 side2Length, Int32 side3Length)
			=> (side1Length < side2Length + side3Length) &&
			   (side2Length < side1Length + side3Length) &&
			   (side3Length < side1Length + side2Length);

		public Polygon ToPolygon()
			=> new Polygon(Vertex1, Vertex2, Vertex3);

		private static Double Min(params Double[] values)
		{
			return Operation(values, Math.Min);
		}

		private static Double Max(params Double[] values)
		{
			return Operation(values, Math.Max);
		}

		private static Double Operation(Double[] values, Func<Double, Double, Double> func)
		{
			var result = values[0];

			foreach (var value in values)
			{
				result = func(result, value);
			}

			return result;
		}
	}
}
