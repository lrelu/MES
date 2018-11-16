using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GDSMap_Nuget
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Load += ViewMap;
		}

		public void ViewMap(object sendor, EventArgs e)
		{
			this.webBrowser1.Navigate("http://localhost");
		}
	}
}
