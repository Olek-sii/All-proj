namespace PainterVector
{
	partial class PMenu
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lineWidthToolStripMenuItem = new System.Windows.Forms.ToolStripComboBox();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorToolStripMenuItem,
            this.lineWidthToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(150, 27);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// colorToolStripMenuItem
			// 
			this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
			this.colorToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
			this.colorToolStripMenuItem.Text = "color";
			this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
			// 
			// lineWidthToolStripMenuItem
			// 
			this.lineWidthToolStripMenuItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lineWidthToolStripMenuItem.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
			this.lineWidthToolStripMenuItem.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "10"});
			this.lineWidthToolStripMenuItem.Name = "lineWidthToolStripMenuItem";
			this.lineWidthToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
			this.lineWidthToolStripMenuItem.SelectedIndexChanged += new System.EventHandler(this.lineWidthToolStripMenuItem_SelectedIndexChanged);
			// 
			// PMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.menuStrip1);
			this.Name = "PMenu";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
		private System.Windows.Forms.ToolStripComboBox lineWidthToolStripMenuItem;
	}
}
