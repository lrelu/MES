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
	public partial class Frm_RawData : Form
	{
		public Frm_RawData()
		{
			InitializeComponent();
		}

		public void View(int[,] raw)
		{
			for (int i = 0; i < raw.GetLength(0); i++)
				dgvRaw.Columns.Add(i.ToString(), i.ToString());
		}
	}
}
