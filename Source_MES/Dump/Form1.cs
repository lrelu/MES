using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dump
{
	public partial class Form1 : Form
	{
		private Random _rand = new Random();
		private delegate void ChangeCircularPBValueDelegate(int value);

		public Form1()
		{
			InitializeComponent();
			this.circularProgressBar1.Minimum = 0;
			this.circularProgressBar1.Maximum = 100;
			this.circularProgressBar1.Value = 70;
			this.circularProgressBar1.Text = "70";

			this.circularProgressBar1.Update();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			// 스레드 사용 기본
			Thread thread = new Thread(new ThreadStart(Run));
			thread.Start();
		}

		private void SetValue(int value)
		{
			if (this.circularProgressBar1.InvokeRequired)
			{
				ChangeCircularPBValueDelegate run = new ChangeCircularPBValueDelegate(SetValue);
				this.Invoke(run, new object[] { value });
			}
			else
			{
				this.circularProgressBar1.Value = value;
				this.circularProgressBar1.Text = value.ToString();
				this.circularProgressBar1.Update();

				//this.progressBar1.Value = value;
				//this.progressBar1.Update();
			}
		}

		private void Run()
		{
			//외부 스레드에서 컨트롤을 수정하기 때문에 디버그시 오류가 발생함
			//while (true)
			//{
			//	int temp = this.circularProgressBar1.Value + _rand.Next(-5, 5);
			//	this.circularProgressBar1.Value = temp;
			//	this.circularProgressBar1.Text = temp.ToString();
			//	this.circularProgressBar1.Update();
			//	Thread.Sleep(100);
			//}

			// invoke required 방식으로 변경
			while (true)
			{
				int temp = this.circularProgressBar1.Value + _rand.Next(-5, 5);
				this.SetValue(temp);
				Thread.Sleep(100);
			}
			
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			// 값 불러오기
			this.label1.Text = "Load by Form Load";
			this.textBox1.Text = "Load by Form Load";

			this.trackBar1.Visible = false;
		}

		public void LoadData()
		{
			// 값 불러오기
			this.label1.Text = "Load by Function";
			this.textBox1.Text = "Load by Function";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form2 form2 = new Form2(this);
			form2.Show();
		}

		private void textBox3_Enter(object sender, EventArgs e)
		{
			this.trackBar1.Visible = true;
			this.trackBar1.Value = int.Parse(this.textBox3.Text.Trim());
		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			this.textBox3.Text = this.trackBar1.Value.ToString();
		}

		private void trackBar1_Leave(object sender, EventArgs e)
		{
			this.trackBar1.Visible = false;
		}

		private void textBox3_Leave(object sender, EventArgs e)
		{
			if (!this.trackBar1.Focused)
				this.trackBar1.Visible = false;
		}
	}
}
