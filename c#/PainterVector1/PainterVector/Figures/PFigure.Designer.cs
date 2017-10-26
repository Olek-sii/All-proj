namespace PainterVector
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
			this.SuspendLayout();
			// 
			// PFigure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "PFigure";
			this.Size = new System.Drawing.Size(110, 131);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.PFigure_Paint);
			this.Enter += new System.EventHandler(this.PFigure_Enter);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PFigure_KeyDown);
			this.Leave += new System.EventHandler(this.PFigure_Leave);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseDown);
			this.MouseEnter += new System.EventHandler(this.PFigure_MouseEnter);
			this.MouseLeave += new System.EventHandler(this.PFigure_MouseLeave);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PFigure_MouseUp);
			this.ResumeLayout(false);

		}

		#endregion
	}
}
