namespace GetEdge
{
	partial class Frm_RawData
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
			this.dgvRaw = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvRaw)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvRaw
			// 
			this.dgvRaw.AllowUserToAddRows = false;
			this.dgvRaw.AllowUserToDeleteRows = false;
			this.dgvRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRaw.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvRaw.Location = new System.Drawing.Point(0, 0);
			this.dgvRaw.Name = "dgvRaw";
			this.dgvRaw.ReadOnly = true;
			this.dgvRaw.RowTemplate.Height = 27;
			this.dgvRaw.Size = new System.Drawing.Size(674, 543);
			this.dgvRaw.TabIndex = 0;
			// 
			// Frm_RawData
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 543);
			this.Controls.Add(this.dgvRaw);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Frm_RawData";
			this.Text = "Frm_RawData";
			((System.ComponentModel.ISupportInitialize)(this.dgvRaw)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvRaw;
	}
}