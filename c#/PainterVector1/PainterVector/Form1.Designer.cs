namespace PainterVector
{
	partial class Form1
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
			this.pFigureType1 = new PainterVector.PFigureType();
			this.pLineWidth1 = new PainterVector.PLineWidth();
			this.menu1 = new PainterVector.PMenu();
			this.pDraw1 = new PainterVector.PDraw();
			this.SuspendLayout();
			// 
			// pFigureType1
			// 
			this.pFigureType1.Location = new System.Drawing.Point(407, 71);
			this.pFigureType1.Name = "pFigureType1";
			this.pFigureType1.Size = new System.Drawing.Size(109, 31);
			this.pFigureType1.TabIndex = 3;
			// 
			// pLineWidth1
			// 
			this.pLineWidth1.Location = new System.Drawing.Point(407, 39);
			this.pLineWidth1.Name = "pLineWidth1";
			this.pLineWidth1.Size = new System.Drawing.Size(109, 26);
			this.pLineWidth1.TabIndex = 2;
			// 
			// menu1
			// 
			this.menu1.Location = new System.Drawing.Point(2, 1);
			this.menu1.Name = "menu1";
			this.menu1.Size = new System.Drawing.Size(494, 32);
			this.menu1.TabIndex = 1;
			// 
			// pDraw1
			// 
			this.pDraw1.Location = new System.Drawing.Point(12, 39);
			this.pDraw1.Name = "pDraw1";
			this.pDraw1.Size = new System.Drawing.Size(389, 337);
			this.pDraw1.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 388);
			this.Controls.Add(this.pFigureType1);
			this.Controls.Add(this.pLineWidth1);
			this.Controls.Add(this.menu1);
			this.Controls.Add(this.pDraw1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private PDraw pDraw1;
		private PMenu menu1;
		private PLineWidth pLineWidth1;
		private PFigureType pFigureType1;
	}
}

