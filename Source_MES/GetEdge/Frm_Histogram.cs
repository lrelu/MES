using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetEdge
{
	public partial class Frm_Histogram : Form
	{
		public Frm_Histogram()
		{
			InitializeComponent();
		}

		public void DrawHistogram(double[] normalList)
		{
			int outH = 256;
			int outW = 256;

			Bitmap bitmap = new Bitmap(outW, outH);
			System.Byte[,] outImage = new System.Byte[outW, outH];

			for (int i = 0; i < outH; i++)
				for (int k = 0; k < outW; k++)
					outImage[i, k] = 255;

			for (int i = 0; i < outH; i++)
				for (int k = 0; k < (int)normalList[i]; k++)
					outImage[255 - k, i] = 0;

			this.Size = new Size(outH, outW);
			System.Byte data; Color c;
			for (int i = 0; i < outH; i++)
			{
				for (int k = 0; k < outW; k++)
				{
					data = outImage[i, k];
					c = Color.FromArgb(data, data, data);
					bitmap.SetPixel(k, i, c);
				}
			}
			pictureBox1.Image = bitmap;
			// 픽처 박스(=칠판) 크기 조절
			pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pictureBox1.Size = new Size(outH, outW);
		}
	}
}
