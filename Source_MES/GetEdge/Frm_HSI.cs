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
	public partial class Frm_HSI : Form
	{
		public Frm_HSI()
		{
			InitializeComponent();
		}

		private struct HSI
		{
			public double H;
			public double S;
			public double I;
		}

		/// <summary>
		/// Bitmap 객체를 RGB Array로 분리
		/// </summary>
		/// <param name="bitmap"></param>
		/// <returns></returns>
		private List<byte[,]> BitmapToRGB(Bitmap bitmap)
		{
			// 필요변수
			List<byte[,]> rgb = new List<byte[,]>();
			byte[,] R = new byte[bitmap.Height, bitmap.Width];
			byte[,] G = new byte[bitmap.Height, bitmap.Width];
			byte[,] B = new byte[bitmap.Height, bitmap.Width];
			Color color;

			// bitmap을 읽어서 RGB값을 분리
			for (int i = 0; i < bitmap.Height; i++)
			{
				for (int k = 0; k < bitmap.Width; k++)
				{
					color = bitmap.GetPixel(i, k);
					R[i, k] = color.R;
					G[i, k] = color.G;
					B[i, k] = color.B;
				}
			}

			// 분리한 RGB값을 list 배열에 저장
			rgb.Add(R);
			rgb.Add(G);
			rgb.Add(B);

			return rgb;
		}

		/// <summary>
		/// RGB 배열을 HSI 배열로 변환
		/// </summary>
		/// <param name="rgb"></param>
		/// <returns></returns>
		private List<float[,]> RGBtoHSI(List<byte[,]> rgb)
		{
			if (rgb.Count <= 0)
				return null;

			// 한 레이어에다가 로우데이터 담음
			int width = rgb[0].GetLength(0);
			int height = rgb[0].GetLength(1);

			// 임시저장공간 생성
			float[,] H = new float[height, width];
			float[,] S = new float[height, width];
			float[,] I = new float[height, width];

			// 반환할 공간 생성
			List<float[,]> hsi = new List<float[,]>();
			
			for (int i = 0; i < height; i++)
			{
				for (int k = 0; k < width; k++)
				{
					Color color = Color.FromArgb(rgb[0][i, k], rgb[1][i, k], rgb[2][i, k]);
					H[i, k] = color.GetHue();
					S[i, k] = color.GetSaturation();
					I[i, k] = color.GetBrightness();
				}	
			}

			// 리턴 리스트에 저장
			hsi.Add(H);
			hsi.Add(S);
			hsi.Add(I);

			return hsi;
		}

		/// <summary>
		/// HSI 배열을 RGB 배열로 변환
		/// </summary>
		/// <param name="rgb"></param>
		/// <returns></returns>
		private List<byte[,]> HSItoRGB(List<byte[,]> hsi)
		{
			return hsi;
		}

		private void DisplayHSI(List<float[,]> hsi, PictureBox picH, PictureBox picS, PictureBox picI)
		{
			if (hsi.Count <= 0)
				return;

			int width = hsi[0].GetLength(0);
			int height = hsi[1].GetLength(1);

			Bitmap H = new Bitmap(width, height);
			Bitmap S = new Bitmap(width, height);
			Bitmap I = new Bitmap(width, height);

			for (int i = 0; i < height; i++)
			{
				for (int k = 0; k < width; k++)
				{
					int color = hsi[0][i, k] > 255 ? 255 : (int)hsi[0][i, k];				H.SetPixel(i, k, Color.FromArgb(color, color, color));
					color = (int)hsi[1][i, k];																S.SetPixel(i, k, Color.FromArgb(color, color, color));
					color = (int)hsi[2][i, k];															I.SetPixel(i, k, Color.FromArgb(color, color, color));
				}
			}

			picH.Image = H;
			picS.Image = S;
			picI.Image = I;
		}

		private void DisplayImage(Bitmap bitmap, PictureBox ctl)
		{
			ctl.Image = bitmap;
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.DefaultExt = "raw";
				dialog.Filter = "Image Files| *.png;*.jpg";
				dialog.InitialDirectory = @"C:\Temp\Pet_Color\Pet_Color(512x512)";
				dialog.RestoreDirectory = true;
				
				if (dialog.ShowDialog() == DialogResult.OK)
				{
					Bitmap bitmap = new Bitmap(dialog.FileName);
					this.DisplayImage(bitmap, this.pictureBox1);
					this.btnHSI.Enabled = true;
				}
			}
		}

		private void btnHSI_Click(object sender, EventArgs e)
		{
			// Image를 RGB 리스트로 만듬
			Bitmap bitmap = new Bitmap(this.pictureBox1.Image);
			List<byte[,]> rgb = this.BitmapToRGB(bitmap);

			// RGB 리스트를 HSI 리스트로 만듬
			List<float[,]> hsi = this.RGBtoHSI(rgb);

			// HSI 리스트를 픽쳐박스에 노출
			this.DisplayHSI(hsi, picH, picS, picI);
		}
	}
}
