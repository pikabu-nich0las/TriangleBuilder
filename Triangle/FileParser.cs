namespace Triangle
{
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Globalization;
	using System.Linq;

	public class FileParser
	{
		public Scene Parse(String[] lines)
		{
			lines = lines.Where(line => !String.IsNullOrWhiteSpace(line)).ToArray();

			String[] headerParts = Split(lines[0]);

			var scene = new Scene
			{
				Width = Convert.ToInt32(headerParts[0]),
				Height = Convert.ToInt32(headerParts[1]),
				Figures = new List<Figure>()
			};

			for (var i = 1; i < lines.Length; i++)
			{
				var line = lines[i];
				var polygon = new Polygon();
				var polygonDefinitionParts = Split(line);

				for (var j = 0; j < polygonDefinitionParts.Length - 4; j++)
				{
					var coordinates = polygonDefinitionParts[j].Split(',');

					polygon.Vertices.Add(new Point(
						x: Convert.ToDouble(coordinates[0]),
						y: Convert.ToDouble(coordinates[1]))
					);
				}

				var figure = new Figure
				{
					Polygon = polygon,
					LineColor = ColorTranslator.FromHtml(polygonDefinitionParts[polygonDefinitionParts.Length - 4]),
					LineThickness = Convert.ToDouble(polygonDefinitionParts[polygonDefinitionParts.Length - 3], CultureInfo.InvariantCulture),
					DrawingDirection = polygonDefinitionParts[polygonDefinitionParts.Length - 2] == "0"
						? DrawingDirection.Clockwise
						: DrawingDirection.Anticlockwise,
					LineSpacing = Convert.ToDouble(polygonDefinitionParts[polygonDefinitionParts.Length - 1], CultureInfo.InvariantCulture)
				};

				scene.Figures.Add(figure);
			}

			return scene;
		}

		private static String[] Split(String line)
			=> line.Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
	}

	public class Scene
	{
		public Int32 Width { get; set; }
		public Int32 Height { get; set; }	
		public List<Figure> Figures { get; set; }
	}

	public class Figure
	{
		public Polygon Polygon { get; set; }
		public DrawingDirection DrawingDirection { get; set; }
		public Color LineColor { get; set; }
		public Double LineThickness { get; set; }
		public Double LineSpacing { get; set; }
	}
}
