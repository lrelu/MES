namespace GetEdge
{
	partial class Frm_HSI
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
			this.components = new System.ComponentModel.Container();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnHSI = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.cmsView = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.cmsViewRaw = new System.Windows.Forms.ToolStripMenuItem();
			this.cmsViewHistogram = new System.Windows.Forms.ToolStripMenuItem();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.splitContainer3 = new System.Windows.Forms.SplitContainer();
			this.splitContainer4 = new System.Windows.Forms.SplitContainer();
			this.picH = new System.Windows.Forms.PictureBox();
			this.picS = new System.Windows.Forms.PictureBox();
			this.picI = new System.Windows.Forms.PictureBox();
			this.picOut = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.cmsView.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
			this.splitContainer3.Panel1.SuspendLayout();
			this.splitContainer3.Panel2.SuspendLayout();
			this.splitContainer3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
			this.splitContainer4.Panel1.SuspendLayout();
			this.splitContainer4.Panel2.SuspendLayout();
			this.splitContainer4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picH)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picI)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picOut)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Location = new System.Drawing.Point(0, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(525, 545);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Tag = "pic1";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnHSI);
			this.panel1.Controls.Add(this.btnLoad);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(78, 545);
			this.panel1.TabIndex = 2;
			// 
			// btnHSI
			// 
			this.btnHSI.Enabled = false;
			this.btnHSI.Location = new System.Drawing.Point(4, 67);
			this.btnHSI.Name = "btnHSI";
			this.btnHSI.Size = new System.Drawing.Size(69, 48);
			this.btnHSI.TabIndex = 0;
			this.btnHSI.Text = "to HSI";
			this.btnHSI.UseVisualStyleBackColor = true;
			this.btnHSI.Click += new System.EventHandler(this.btnHSI_Click);
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
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(1055, 545);
			this.splitContainer1.SplitterDistance = 525;
			this.splitContainer1.TabIndex = 3;
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
			// 
			// cmsViewHistogram
			// 
			this.cmsViewHistogram.Name = "cmsViewHistogram";
			this.cmsViewHistogram.Size = new System.Drawing.Size(247, 24);
			this.cmsViewHistogram.Text = "View histogram Diagram";
			// 
			// timer1
			// 
			this.timer1.Interval = 50;
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.splitContainer3);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.splitContainer4);
			this.splitContainer2.Size = new System.Drawing.Size(526, 545);
			this.splitContainer2.SplitterDistance = 261;
			this.splitContainer2.TabIndex = 0;
			// 
			// splitContainer3
			// 
			this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer3.Location = new System.Drawing.Point(0, 0);
			this.splitContainer3.Name = "splitContainer3";
			this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			this.splitContainer3.Panel1.Controls.Add(this.picH);
			// 
			// splitContainer3.Panel2
			// 
			this.splitContainer3.Panel2.Controls.Add(this.picI);
			this.splitContainer3.Size = new System.Drawing.Size(261, 545);
			this.splitContainer3.SplitterDistance = 269;
			this.splitContainer3.TabIndex = 0;
			// 
			// splitContainer4
			// 
			this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer4.Location = new System.Drawing.Point(0, 0);
			this.splitContainer4.Name = "splitContainer4";
			this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			this.splitContainer4.Panel1.Controls.Add(this.picS);
			// 
			// splitContainer4.Panel2
			// 
			this.splitContainer4.Panel2.Controls.Add(this.picOut);
			this.splitContainer4.Size = new System.Drawing.Size(261, 545);
			this.splitContainer4.SplitterDistance = 269;
			this.splitContainer4.TabIndex = 1;
			// 
			// picH
			// 
			this.picH.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picH.Location = new System.Drawing.Point(0, 0);
			this.picH.Name = "picH";
			this.picH.Size = new System.Drawing.Size(261, 269);
			this.picH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picH.TabIndex = 0;
			this.picH.TabStop = false;
			// 
			// picS
			// 
			this.picS.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picS.Location = new System.Drawing.Point(0, 0);
			this.picS.Name = "picS";
			this.picS.Size = new System.Drawing.Size(261, 269);
			this.picS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picS.TabIndex = 1;
			this.picS.TabStop = false;
			// 
			// picI
			// 
			this.picI.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picI.Location = new System.Drawing.Point(0, 0);
			this.picI.Name = "picI";
			this.picI.Size = new System.Drawing.Size(261, 272);
			this.picI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picI.TabIndex = 1;
			this.picI.TabStop = false;
			// 
			// picOut
			// 
			this.picOut.Dock = System.Windows.Forms.DockStyle.Fill;
			this.picOut.Location = new System.Drawing.Point(0, 0);
			this.picOut.Name = "picOut";
			this.picOut.Size = new System.Drawing.Size(261, 272);
			this.picOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picOut.TabIndex = 1;
			this.picOut.TabStop = false;
			// 
			// Frm_HSI
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1055, 545);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Frm_HSI";
			this.Text = "Frm_HSI";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.cmsView.ResumeLayout(false);
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.splitContainer3.Panel1.ResumeLayout(false);
			this.splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
			this.splitContainer3.ResumeLayout(false);
			this.splitContainer4.Panel1.ResumeLayout(false);
			this.splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
			this.splitContainer4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.picH)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picI)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picOut)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnHSI;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.ContextMenuStrip cmsView;
		private System.Windows.Forms.ToolStripMenuItem cmsViewRaw;
		private System.Windows.Forms.ToolStripMenuItem cmsViewHistogram;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.PictureBox picH;
		private System.Windows.Forms.PictureBox picI;
		private System.Windows.Forms.SplitContainer splitContainer4;
		private System.Windows.Forms.PictureBox picS;
		private System.Windows.Forms.PictureBox picOut;
	}
}