using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dump
{
	public partial class Form3 : Form
	{
		

		public Form3()
		{
			InitializeComponent();
		}

		private void pictureBox1_MouseHover(object sender, EventArgs e)
		{

		}

		private void pictureBox1_Move(object sender, EventArgs e)
		{

		}

		string _img1 = @"C:\Temp\Pet_Color\Pet_Color(512x512)\etc15_512.png";
		string _img2 = @"C:\Temp\Pet_Color\Pet_Color(512x512)\etc15_512_gray.png";

		private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
		{
			this.Text = string.Format("X: {0}, Y: {1}", e.X.ToString(), e.Y.ToString());

			if ((e.X > 90 && e.X < 120) && (e.Y > 250 && e.Y < 270)){
				this.pictureBox1.Image = Image.FromFile(_img2);
			}
			else
			{
				this.pictureBox1.Image = Image.FromFile(_img1);
			}
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			MouseEventArgs mouse = (MouseEventArgs)e;

			if ((mouse.X > 90 && mouse.X < 120) && (mouse.Y > 250 && mouse.Y < 270))
			{
				MessageBox.Show("코가 선택되었습니다.");
			}
		}
	}
}
