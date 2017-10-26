namespace PaintWF
{
	partial class PFigure
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
			this.components = new System.ComponentModel.Container();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SetColor = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SetColor});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(120, 26);
			// 
			// SetColor
			// 
			this.SetColor.Name = "SetColor";
			this.SetColor.Size = new System.Drawing.Size(119, 22);
			this.SetColor.Text = "SetColor";
			this.SetColor.Click += new System.EventHandler(this.SetColor_Click);
			// 
			// PFigure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Transparent;
			this.Name = "PFigure";
			this.Size = new System.Drawing.Size(10, 10);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.PFigure_Paint);
			this.Enter += new System.EventHandler(this.PFigure_Enter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PFigure_KeyDown);
			this.Leave += new System.EventHandler(this.PFigure_Leave);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseDown);
			this.MouseEnter += new System.EventHandler(this.PFigure_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.PFigure_MouseLeave);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseUp);
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem SetColor;
	}
}
