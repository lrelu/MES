namespace OCR
{
	partial class frmOcr
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOcr));
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnGetText = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.pic = new System.Windows.Forms.PictureBox();
			this.txt = new System.Windows.Forms.RichTextBox();
			this.btnChangeImage = new System.Windows.Forms.Button();
			this.btnGetTextKor = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnChangeImage);
			this.panel1.Controls.Add(this.btnGetTextKor);
			this.panel1.Controls.Add(this.btnGetText);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1068, 62);
			this.panel1.TabIndex = 0;
			// 
			// btnGetText
			// 
			this.btnGetText.Location = new System.Drawing.Point(887, 12);
			this.btnGetText.Name = "btnGetText";
			this.btnGetText.Size = new System.Drawing.Size(169, 44);
			this.btnGetText.TabIndex = 0;
			this.btnGetText.Text = "Get English from Image using Tesseract";
			this.btnGetText.UseVisualStyleBackColor = true;
			this.btnGetText.Click += new System.EventHandler(this.btnGetText_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 62);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.pic);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txt);
			this.splitContainer1.Size = new System.Drawing.Size(1068, 593);
			this.splitContainer1.SplitterDistance = 439;
			this.splitContainer1.TabIndex = 1;
			// 
			// pic
			// 
			this.pic.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pic.Image = ((System.Drawing.Image)(resources.GetObject("pic.Image")));
			this.pic.Location = new System.Drawing.Point(0, 0);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(439, 593);
			this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pic.TabIndex = 0;
			this.pic.TabStop = false;
			// 
			// txt
			// 
			this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt.Location = new System.Drawing.Point(0, 0);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(625, 593);
			this.txt.TabIndex = 0;
			this.txt.Text = "";
			// 
			// btnChangeImage
			// 
			this.btnChangeImage.Location = new System.Drawing.Point(12, 12);
			this.btnChangeImage.Name = "btnChangeImage";
			this.btnChangeImage.Size = new System.Drawing.Size(127, 44);
			this.btnChangeImage.TabIndex = 1;
			this.btnChangeImage.Text = "Change Image";
			this.btnChangeImage.UseVisualStyleBackColor = true;
			this.btnChangeImage.Click += new System.EventHandler(this.btnChangeImage_Click);
			// 
			// btnGetTextKor
			// 
			this.btnGetTextKor.Location = new System.Drawing.Point(712, 12);
			this.btnGetTextKor.Name = "btnGetTextKor";
			this.btnGetTextKor.Size = new System.Drawing.Size(169, 44);
			this.btnGetTextKor.TabIndex = 0;
			this.btnGetTextKor.Text = "Get Korean from Image using Tesseract";
			this.btnGetTextKor.UseVisualStyleBackColor = true;
			this.btnGetTextKor.Click += new System.EventHandler(this.btnGetTextKor_Click);
			// 
			// frmOcr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1068, 655);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.panel1);
			this.Name = "frmOcr";
			this.Text = "OCR";
			this.Load += new System.EventHandler(this.frmOcr_Load);
			this.panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnGetText;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.RichTextBox txt;
		private System.Windows.Forms.Button btnChangeImage;
		private System.Windows.Forms.Button btnGetTextKor;
	}
}

