namespace Triangle
{
	partial class DrawingForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.SideCLength = new System.Windows.Forms.NumericUpDown();
			this.SideBLength = new System.Windows.Forms.NumericUpDown();
			this.SideALength = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.DrawButton = new System.Windows.Forms.Button();
			this.PictureBox = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.Interval = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.IsClockwise = new System.Windows.Forms.RadioButton();
			this.IsAntiClockwise = new System.Windows.Forms.RadioButton();
			this.SaveAsPngButton = new System.Windows.Forms.Button();
			this.SavePngFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.SaveAsSvgButton = new System.Windows.Forms.Button();
			this.SaveSvgFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.LoadConfigButton = new System.Windows.Forms.Button();
			this.LoadFile = new System.Windows.Forms.OpenFileDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.SideCLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SideBLength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.SideALength)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Interval)).BeginInit();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.SideCLength);
			this.groupBox1.Controls.Add(this.SideBLength);
			this.groupBox1.Controls.Add(this.SideALength);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(146, 119);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Triangle Settings";
			// 
			// SideCLength
			// 
			this.SideCLength.Location = new System.Drawing.Point(67, 86);
			this.SideCLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.SideCLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.SideCLength.Name = "SideCLength";
			this.SideCLength.Size = new System.Drawing.Size(68, 22);
			this.SideCLength.TabIndex = 10;
			this.SideCLength.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
			// 
			// SideBLength
			// 
			this.SideBLength.Location = new System.Drawing.Point(67, 54);
			this.SideBLength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.SideBLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.SideBLength.Name = "SideBLength";
			this.SideBLength.Size = new System.Drawing.Size(68, 22);
			this.SideBLength.TabIndex = 9;
			this.SideBLength.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
			// 
			// SideALength
			// 
			this.SideALength.Location = new System.Drawing.Point(67, 24);
			this.SideALength.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.SideALength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.SideALength.Name = "SideALength";
			this.SideALength.Size = new System.Drawing.Size(68, 22);
			this.SideALength.TabIndex = 3;
			this.SideALength.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 88);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "Side C";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "Side B";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Side A";
			// 
			// DrawButton
			// 
			this.DrawButton.Location = new System.Drawing.Point(419, 18);
			this.DrawButton.Name = "DrawButton";
			this.DrawButton.Size = new System.Drawing.Size(118, 44);
			this.DrawButton.TabIndex = 1;
			this.DrawButton.Text = "Draw";
			this.DrawButton.UseVisualStyleBackColor = true;
			this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
			// 
			// PictureBox
			// 
			this.PictureBox.BackColor = System.Drawing.Color.White;
			this.PictureBox.Location = new System.Drawing.Point(12, 133);
			this.PictureBox.Name = "PictureBox";
			this.PictureBox.Size = new System.Drawing.Size(650, 650);
			this.PictureBox.TabIndex = 2;
			this.PictureBox.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.Interval);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.groupBox3);
			this.groupBox2.Location = new System.Drawing.Point(164, 8);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(247, 119);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Drawing Settings";
			// 
			// Interval
			// 
			this.Interval.DecimalPlaces = 1;
			this.Interval.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.Interval.Location = new System.Drawing.Point(153, 45);
			this.Interval.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
			this.Interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
			this.Interval.Name = "Interval";
			this.Interval.Size = new System.Drawing.Size(85, 22);
			this.Interval.TabIndex = 2;
			this.Interval.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(150, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 17);
			this.label5.TabIndex = 1;
			this.label5.Text = "Line spacing";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.IsClockwise);
			this.groupBox3.Controls.Add(this.IsAntiClockwise);
			this.groupBox3.Location = new System.Drawing.Point(6, 24);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(125, 81);
			this.groupBox3.TabIndex = 0;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Direction";
			// 
			// IsClockwise
			// 
			this.IsClockwise.AutoSize = true;
			this.IsClockwise.Checked = true;
			this.IsClockwise.Location = new System.Drawing.Point(6, 21);
			this.IsClockwise.Name = "IsClockwise";
			this.IsClockwise.Size = new System.Drawing.Size(90, 21);
			this.IsClockwise.TabIndex = 4;
			this.IsClockwise.TabStop = true;
			this.IsClockwise.Text = "Clockwise";
			this.IsClockwise.UseVisualStyleBackColor = true;
			// 
			// IsAntiClockwise
			// 
			this.IsAntiClockwise.AutoSize = true;
			this.IsAntiClockwise.Location = new System.Drawing.Point(6, 48);
			this.IsAntiClockwise.Name = "IsAntiClockwise";
			this.IsAntiClockwise.Size = new System.Drawing.Size(112, 21);
			this.IsAntiClockwise.TabIndex = 0;
			this.IsAntiClockwise.Text = "Anticlockwise";
			this.IsAntiClockwise.UseVisualStyleBackColor = true;
			// 
			// SaveAsPngButton
			// 
			this.SaveAsPngButton.Location = new System.Drawing.Point(419, 68);
			this.SaveAsPngButton.Name = "SaveAsPngButton";
			this.SaveAsPngButton.Size = new System.Drawing.Size(118, 48);
			this.SaveAsPngButton.TabIndex = 4;
			this.SaveAsPngButton.Text = "Save PNG";
			this.SaveAsPngButton.UseVisualStyleBackColor = true;
			this.SaveAsPngButton.Click += new System.EventHandler(this.SaveAsPngButton_Click);
			// 
			// SavePngFileDialog
			// 
			this.SavePngFileDialog.FileName = "impage.png";
			this.SavePngFileDialog.Filter = "PNG Files (*.png)|*.png";
			// 
			// SaveAsSvgButton
			// 
			this.SaveAsSvgButton.Location = new System.Drawing.Point(544, 68);
			this.SaveAsSvgButton.Name = "SaveAsSvgButton";
			this.SaveAsSvgButton.Size = new System.Drawing.Size(118, 48);
			this.SaveAsSvgButton.TabIndex = 5;
			this.SaveAsSvgButton.Text = "Save SVG";
			this.SaveAsSvgButton.UseVisualStyleBackColor = true;
			this.SaveAsSvgButton.Click += new System.EventHandler(this.SaveAsSvgButton_Click);
			// 
			// SaveSvgFileDialog
			// 
			this.SaveSvgFileDialog.FileName = "impage.svg";
			this.SaveSvgFileDialog.Filter = "SVG Files (*.svg)|*.svg";
			// 
			// LoadConfigButton
			// 
			this.LoadConfigButton.Location = new System.Drawing.Point(544, 18);
			this.LoadConfigButton.Name = "LoadConfigButton";
			this.LoadConfigButton.Size = new System.Drawing.Size(118, 44);
			this.LoadConfigButton.TabIndex = 6;
			this.LoadConfigButton.Text = "Draw from file";
			this.LoadConfigButton.UseVisualStyleBackColor = true;
			this.LoadConfigButton.Click += new System.EventHandler(this.LoadConfigButton_Click);
			// 
			// LoadFile
			// 
			this.LoadFile.Filter = "TXT Files (*.txt)|*.txt";
			// 
			// DrawingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(673, 800);
			this.Controls.Add(this.LoadConfigButton);
			this.Controls.Add(this.SaveAsSvgButton);
			this.Controls.Add(this.SaveAsPngButton);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.PictureBox);
			this.Controls.Add(this.DrawButton);
			this.Controls.Add(this.groupBox1);
			this.Name = "DrawingForm";
			this.Text = "Triangle Builder";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.SideCLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SideBLength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.SideALength)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Interval)).EndInit();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button DrawButton;
		private System.Windows.Forms.PictureBox PictureBox;
		private System.Windows.Forms.NumericUpDown SideCLength;
		private System.Windows.Forms.NumericUpDown SideBLength;
		private System.Windows.Forms.NumericUpDown SideALength;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton IsAntiClockwise;
		private System.Windows.Forms.RadioButton IsClockwise;
		private System.Windows.Forms.NumericUpDown Interval;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button SaveAsPngButton;
		private System.Windows.Forms.SaveFileDialog SavePngFileDialog;
		private System.Windows.Forms.Button SaveAsSvgButton;
		private System.Windows.Forms.SaveFileDialog SaveSvgFileDialog;
		private System.Windows.Forms.Button LoadConfigButton;
		private System.Windows.Forms.OpenFileDialog LoadFile;
	}
}

