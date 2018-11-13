using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetEdge
{
	public partial class Form1 : Form
	{
		System.Byte[,] inImage, outImage;
		int inH, inW, outH, outW;

		public Form1()
		{
			InitializeComponent();
		}

		private void LoadImage(string fileName)
		{
			System.Int64 fileSize = new System.IO.FileInfo(fileName).Length;
			this.inH = this.inW = (int)Math.Sqrt(fileSize);

			this.inImage = new System.Byte[inH, inW];

			using (BinaryReader br = new BinaryReader(File.Open(fileName, FileMode.Open)))
			{
				for (int i = 0; i < inH; i++)
				{
					for (int k = 0; k < inW; k++)
					{
						System.Byte pixel = br.ReadByte();
						inImage[k, i] = pixel;
					}
				}
			}
		}

		private void DisplayImage(byte[,] image, Control ctl)
		{
			System.Byte pixel;
			Color color;
			Bitmap bitmap = new Bitmap(inW, inH);

			for (int i = 0; i < inH; i++)
			{
				for (int k = 0; k < inW; k++)
				{
					pixel = image[i, k];
					color = Color.FromArgb(pixel, pixel, pixel);
					bitmap.SetPixel(i, k, color);
				}
			}

			((PictureBox)ctl).Image = bitmap;
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.DefaultExt = "raw";
				dialog.Filter = "RAW File(*.raw) | *.raw";
				dialog.InitialDirectory = @"C:\Temp\Etc_Raw\512";
				dialog.RestoreDirectory = true;

				if (dialog.ShowDialog() == DialogResult.OK)
				{
					this.LoadImage(dialog.FileName);
					this.DisplayImage(this.inImage, this.pictureBox1);

				}
			}
		}

		private void btnGetEdge_Click(object sender, EventArgs e)
		{
			double[,] eboMask = { { -1.0, 0.0, 0.0 }, { 0.0, 0.0, 0.0 }, { 0.0, 0.0, 1.0 } };
			//double[,] edgeHMask = { { 0.0, -1.0, 0.0 }, { 0.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };
			//double[,] edgeVMask = { { 0.0, 0.0, 0.0 }, { -1.0, 1.0, 0.0 }, { 0.0, 0.0, 1.0 } };

			System.Byte[,] tempOut = this.MakeFilter(eboMask);

			this.DisplayImage(tempOut, this.pictureBox2);
		}

		private System.Byte[,] MakeFilter(double[,] mask)
		{
			double[,] tempIn = new double[this.inW + 2, this.inH + 2];
			System.Byte[,] tempOut = new System.Byte[this.inW, this.inH];

			// 원본이미지를 여백이 있는 임시 double 배열에다가 저장
			for (int i = 0; i < inH; i++)
				for (int k = 0; k < inW; k++)
					tempIn[i + 1, k + 1] = (double)this.inImage[i, k];

			for (int i = 0; i < inH; i++)
			{
				for (int k = 0; k < inW; k++)
				{
					// 마스킹
					double sum = 0.0;
					for (int m = -1; m < mask.GetLength(0) - 1; m++)
						for (int n = -1; n < mask.GetLength(1) - 1; n++)
							sum += tempIn[(i + 1) + m, (k + 1) + n] * mask[m + 1, n + 1];

					//sum = sum > 255.0 ? 255.0 : sum;
					//sum = sum < 0.0 ? 0.0 : sum;
					//tempOut[i, k] = (System.Byte)sum;

					tempOut[i, k] = (System.Byte)(sum + 127);
				}
			}

			return tempOut;
		}
	}
}
