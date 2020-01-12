namespace Triangle
{
	using System;

	public class TriangleCoordinateCalculator
	{
		public Triangle Calculate(Int32 sideA, Int32 sideB, Int32 sideC, Int32 canvasWidth, Int32 canvasHeight)
		{
			var vertex2X = (sideB * sideB + sideC * sideC - sideA * sideA) / (2.0 * sideB);
			var vertex2Y = Math.Sqrt(sideC * sideC - vertex2X * vertex2X);

			var triangle = new Triangle(
				vertex1: new Point(0, 0),
				vertex2: new Point(vertex2X, vertex2Y),
				vertex3: new Point(sideB, 0)
			);

			triangle.FlipVertical();

			var triangleCenter = triangle.GetCenter();
			var canvasCenter = new Point(canvasWidth / 2.0, canvasHeight / 2.0);

			var offset = canvasCenter - triangleCenter;

			triangle.Vertex1 += offset;
			triangle.Vertex2 += offset;
			triangle.Vertex3 += offset;

			return triangle;
		}
	}
}
