namespace Triangle
{
	using System;
	using System.Collections.Generic;
	using System.Drawing;
	using System.Drawing.Imaging;
	using System.IO;
	using System.Linq;
	using System.Windows.Forms;
	using Svg;

	public partial class DrawingForm : Form
	{
		public DrawingForm()
		{
			InitializeComponent();

			SideALength.Maximum = SideBLength.Maximum = SideCLength.Maximum = PictureBox.Width;
			SideALength.Value = SideBLength.Value = SideCLength.Value = PictureBox.Width - 50;
		}

		private void DrawButton_Click(Object sender, EventArgs e)
		{
			PictureBox.Image = BuildBitmap();
		}

		private Bitmap BuildBitmap()
		{
			var points = GetTrianglePoints();

			if (points == null)
			{
				return null;
			}

			Bitmap bitmap = new Bitmap(PictureBox.Width, PictureBox.Height);

			using (var graphic = Graphics.FromImage(bitmap))
			{
				graphic.Clear(Color.White);

				Pen pen = new Pen(Color.Blue, 1.0f);

				graphic.DrawLines(
					pen,
					points.Select(p => new PointF((float)p.X, (float)p.Y)).ToArray()
				);
			}

			return bitmap;
		}

		private List<Point> GetTrianglePoints()
		{
			Int32 sideA = (Int32)SideALength.Value;
			Int32 sideB = (Int32)SideBLength.Value;
			Int32 sideC = (Int32)SideCLength.Value;
			Double interval = (Double)Interval.Value;
			DrawingDirection drawingDirection = GetDrawingDirection();

			if (!Triangle.IsExist(sideA, sideB, sideC))
			{
				MessageBox.Show(
					text: @"A triangle with such sides does not exist.",
					caption: @"Error"
				);

				return null;
			}

			var triangleCoordinateCalculator = new TriangleCoordinateCalculator();
			var triangle = triangleCoordinateCalculator.Calculate(sideA, sideB, sideC, PictureBox.Width, PictureBox.Height);

			var pointsBuilder = new PointsBuilder();
			var points = pointsBuilder.Build(triangle.ToPolygon(), interval, drawingDirection);

			return points;
		}

		private DrawingDirection GetDrawingDirection()
		{
			if (IsClockwise.Checked)
			{
				return DrawingDirection.Clockwise;
			}

			if (IsAntiClockwise.Checked)
			{
				return DrawingDirection.Anticlockwise;
			}

			return default(DrawingDirection);
		}

		private void SaveAsPngButton_Click(object sender, EventArgs e)
		{
			var bitmap = BuildBitmap();
			PictureBox.Image = bitmap;

			if (bitmap == null)
			{
				return;
			}

			if (SavePngFileDialog.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}

			bitmap.Save(SavePngFileDialog.FileName, ImageFormat.Png);
		}

		private void SaveAsSvgButton_Click(object sender, EventArgs e)
		{
			var bitmap = BuildBitmap();
			PictureBox.Image = bitmap;

			if (bitmap == null)
			{
				return;
			}

			if (SaveSvgFileDialog.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}

			var svg = new SvgDocument
			{
				Height = PictureBox.Height,
				Width = PictureBox.Height
			};

			var polyline = new SvgPolyline
			{
				Points = new SvgPointCollection(),
				Fill = new SvgColourServer(Color.Transparent),
				Stroke = new SvgColourServer(Color.Black),
				StrokeWidth = new SvgUnit(1),
			};

			var points = GetTrianglePoints();

			foreach (var point in points)
			{
				polyline.Points.Add(new SvgUnit(SvgUnitType.Point, (float)point.X));
				polyline.Points.Add(new SvgUnit(SvgUnitType.Point, (float)point.Y));
			}

			svg.Children.Add(polyline);

			svg.Write(SaveSvgFileDialog.FileName);
		}

		private void LoadConfigButton_Click(object sender, EventArgs e)
		{
			if (LoadFile.ShowDialog() == DialogResult.Cancel)
			{
				return;
			}

			var lines = File.ReadAllLines(LoadFile.FileName);

			var parser = new FileParser();

			Scene scene;

			try
			{
				scene = parser.Parse(lines);
			}
			catch
			{
				MessageBox.Show(@"Could not parse file", @"Error");
				return;
			}

			var pointsBuilder = new PointsBuilder();

			var svg = new SvgDocument
			{
				Height = scene.Height,
				Width = scene.Width
			};

			foreach (var figure in scene.Figures)
			{
				var polyline = new SvgPolyline
				{
					Points = new SvgPointCollection(),
					Fill = new SvgColourServer(Color.Transparent),
					Stroke = new SvgColourServer(figure.LineColor),
					StrokeWidth = new SvgUnit((float)figure.LineThickness)
				};

				var points = pointsBuilder.Build(figure.Polygon, figure.LineSpacing, figure.DrawingDirection);

				foreach (var point in points)
				{
					polyline.Points.Add(new SvgUnit(SvgUnitType.Point, (float)point.X));
					polyline.Points.Add(new SvgUnit(SvgUnitType.Point, (float)point.Y));
				}

				svg.Children.Add(polyline);
			}

			var svgPath = LoadFile.FileName.Substring(0, LoadFile.FileName.Length - 4) + "_image.svg";
			svg.Write(svgPath);
			MessageBox.Show(
				text: svgPath,
				caption: @"Success");
		}
	}
}
