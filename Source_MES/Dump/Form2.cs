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
	public partial class Form2 : Form
	{
		private Form1 _frm;
		public Form2(Form frm)
		{
			InitializeComponent();
			this._frm = (Form1)frm;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// 폼 종료
			this.Close();

			// 메인폼 변경
			this._frm.LoadData();
		}
	}
}
