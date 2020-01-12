namespace Triangle
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class Polygon
	{
		public List<Point> Vertices { get; set; }

		public Polygon()
		{
			Vertices = new List<Point>();
		}

		public Polygon(params Point[] vertices)
		{
			Vertices = vertices.ToList();
		}

		public Polygon(params (Double, Double)[] vertices)
		{
			Vertices = new List<Point>();

			foreach (var (x, y) in vertices)
			{
				Vertices.Add(new Point(x, y));
			}
		}
	}
}
