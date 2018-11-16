namespace GetEdge
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnMultiMorph = new System.Windows.Forms.Button();
			this.btnMorph = new System.Windows.Forms.Button();
			this.btnHistogram_Equilize = new System.Windows.Forms.Button();
			this.btnHistogramEndIn = new System.Windows.Forms.Button();
			this.btnHistogram = new System.Windows.Forms.Button();
			this.btnGetEdge = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.cmsView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmsViewRaw = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsViewHistogram = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnColor = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.cmsView.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnColor);
			this.panel1.Controls.Add(this.btnMultiMorph);
			this.panel1.Controls.Add(this.btnMorph);
			this.panel1.Controls.Add(this.btnHistogram_Equilize);
			this.panel1.Controls.Add(this.btnHistogramEndIn);
			this.panel1.Controls.Add(this.btnHistogram);
			this.panel1.Controls.Add(this.btnGetEdge);
			this.panel1.Controls.Add(this.btnLoad);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(78, 512);
			this.panel1.TabIndex = 0;
			// 
			// btnMultiMorph
			// 
			this.btnMultiMorph.Enabled = false;
			this.btnMultiMorph.Location = new System.Drawing.Point(4, 342);
			this.btnMultiMorph.Name = "btnMultiMorph";
			this.btnMultiMorph.Size = new System.Drawing.Size(69, 48);
			this.btnMultiMorph.TabIndex = 0;
			this.btnMultiMorph.Text = "Multi Morph";
			this.btnMultiMorph.UseVisualStyleBackColor = true;
			this.btnMultiMorph.Click += new System.EventHandler(this.btnMultiMorph_Click);
			// 
			// btnMorph
			// 
			this.btnMorph.Enabled = false;
			this.btnMorph.Location = new System.Drawing.Point(4, 287);
			this.btnMorph.Name = "btnMorph";
			this.btnMorph.Size = new System.Drawing.Size(69, 48);
			this.btnMorph.TabIndex = 0;
			this.btnMorph.Text = "Morph";
			this.btnMorph.UseVisualStyleBackColor = true;
			this.btnMorph.Click += new System.EventHandler(this.btnMofing_Click);
			// 
			// btnHistogram_Equilize
			// 
			this.btnHistogram_Equilize.Enabled = false;
			this.btnHistogram_Equilize.Location = new System.Drawing.Point(4, 232);
			this.btnHistogram_Equilize.Name = "btnHistogram_Equilize";
			this.btnHistogram_Equilize.Size = new System.Drawing.Size(69, 48);
			this.btnHistogram_Equilize.TabIndex = 0;
			this.btnHistogram_Equilize.Text = "평활화";
			this.btnHistogram_Equilize.UseVisualStyleBackColor = true;
			this.btnHistogram_Equilize.Click += new System.EventHandler(this.btnHistogram_Equilize_Click);
			// 
			// btnHistogramEndIn
			// 
			this.btnHistogramEndIn.Enabled = false;
			this.btnHistogramEndIn.Location = new System.Drawing.Point(4, 177);
			this.btnHistogramEndIn.Name = "btnHistogramEndIn";
			this.btnHistogramEndIn.Size = new System.Drawing.Size(69, 48);
			this.btnHistogramEndIn.TabIndex = 0;
			this.btnHistogramEndIn.Text = "End In Histogram";
			this.btnHistogramEndIn.UseVisualStyleBackColor = true;
			this.btnHistogramEndIn.Click += new System.EventHandler(this.btnHistogramEndIn_Click);
			// 
			// btnHistogram
			// 
			this.btnHistogram.Enabled = false;
			this.btnHistogram.Location = new System.Drawing.Point(4, 122);
			this.btnHistogram.Name = "btnHistogram";
			this.btnHistogram.Size = new System.Drawing.Size(69, 48);
			this.btnHistogram.TabIndex = 0;
			this.btnHistogram.Text = "Histogram";
			this.btnHistogram.UseVisualStyleBackColor = true;
			this.btnHistogram.Click += new System.EventHandler(this.btnHistogram_Click);
			// 
			// btnGetEdge
			// 
			this.btnGetEdge.Enabled = false;
			this.btnGetEdge.Location = new System.Drawing.Point(4, 67);
			this.btnGetEdge.Name = "btnGetEdge";
			this.btnGetEdge.Size = new System.Drawing.Size(69, 48);
			this.btnGetEdge.TabIndex = 0;
			this.btnGetEdge.Text = "Get Edge";
			this.btnGetEdge.UseVisualStyleBackColor = true;
			this.btnGetEdge.Click += new System.EventHandler(this.btnGetEdge_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(4, 12);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(69, 48);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(78, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.pictureBox2);
			this.splitContainer1.Size = new System.Drawing.Size(1028, 512);
			this.splitContainer1.SplitterDistance = 512;
			this.splitContainer1.TabIndex = 1;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(512, 512);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "pic1";
			this.pictureBox1.DoubleClick += new System.EventHandler(this.pictureBox1_DoubleClick);
			// 
			// pictureBox2
			// 
			this.pictureBox2.ContextMenuStrip = this.cmsView;
			this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox2.Location = new System.Drawing.Point(0, 0);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(512, 512);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 1;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Tag = "pic2";
			// 
			// cmsView
			// 
			this.cmsView.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.cmsView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsViewRaw,
            this.cmsViewHistogram});
			this.cmsView.Name = "cmsView";
			this.cmsView.Size = new System.Drawing.Size(248, 52);
			// 
			// cmsViewRaw
			// 
			this.cmsViewRaw.Name = "cmsViewRaw";
			this.cmsViewRaw.Size = new System.Drawing.Size(247, 24);
			this.cmsViewRaw.Text = "View raw_data";
			this.cmsViewRaw.Click += new System.EventHandler(this.cmsViewRaw_Click);
			// 
			// cmsViewHistogram
			// 
			this.cmsViewHistogram.Name = "cmsViewHistogram";
			this.cmsViewHistogram.Size = new System.Drawing.Size(247, 24);
			this.cmsViewHistogram.Text = "View histogram Diagram";
			this.cmsViewHistogram.Click += new System.EventHandler(this.cmsViewHistogram_Click);
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnColor
			// 
			this.btnColor.Location = new System.Drawing.Point(4, 396);
			this.btnColor.Name = "btnColor";
			this.btnColor.Size = new System.Drawing.Size(69, 48);
			this.btnColor.TabIndex = 0;
			this.btnColor.Text = "Color";
			this.btnColor.UseVisualStyleBackColor = true;
			this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1106, 512);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.cmsView.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnGetEdge;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button btnHistogram;
		private System.Windows.Forms.Button btnHistogramEndIn;
		private System.Windows.Forms.ContextMenuStrip cmsView;
		private System.Windows.Forms.ToolStripMenuItem cmsViewRaw;
		private System.Windows.Forms.ToolStripMenuItem cmsViewHistogram;
		private System.Windows.Forms.Button btnHistogram_Equilize;
		private System.Windows.Forms.Button btnMorph;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnMultiMorph;
		private System.Windows.Forms.Button btnColor;
	}
}

