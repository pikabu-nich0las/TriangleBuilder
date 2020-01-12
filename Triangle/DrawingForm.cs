namespace Triangle
{
	using System;
	using System.Drawing;
	using System.Linq;
	using System.Windows.Forms;

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

				return;
			}

			var triangleCoordinateCalculator = new TriangleCoordinateCalculator();
			var triangle = triangleCoordinateCalculator.Calculate(sideA, sideB, sideC, PictureBox.Width, PictureBox.Height);

			var pointsBuilder = new PointsBuilder();
			var points = pointsBuilder.Build(triangle.ToPolygon(), interval, drawingDirection);

			using (var graphic = PictureBox.CreateGraphics())
			{
				graphic.Clear(Color.White);

				Pen pen = new Pen(Color.Blue, 1.0f);

				graphic.DrawLines(
					pen,
					points.Select(p => new PointF((float)p.X, (float)p.Y)).ToArray()
				);
			}
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
	}
}
