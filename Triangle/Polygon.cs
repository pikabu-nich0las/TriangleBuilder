namespace Triangle
{
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
	}
}
