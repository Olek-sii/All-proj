namespace PaintWF
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
			this.pFigure1 = new PaintWF.PFigure();
			this.pWidth1 = new PaintWF.PWidth();
			this.pColor1 = new PaintWF.PColor();
			this.pDraw1 = new PaintWF.PDraw();
			this.pSaving1 = new PaintWF.PSaving();
			this.pOpening1 = new PaintWF.POpening();
			this.SuspendLayout();
			// 
			// pFigure1
			// 
			this.pFigure1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.pFigure1.Location = new System.Drawing.Point(359, 80);
			this.pFigure1.Name = "pFigure1";
			this.pFigure1.Size = new System.Drawing.Size(85, 123);
			this.pFigure1.TabIndex = 3;
			// 
			// pWidth1
			// 
			this.pWidth1.Location = new System.Drawing.Point(359, 41);
			this.pWidth1.Name = "pWidth1";
			this.pWidth1.Size = new System.Drawing.Size(74, 21);
			this.pWidth1.TabIndex = 2;
			// 
			// pColor1
			// 
			this.pColor1.Location = new System.Drawing.Point(359, 12);
			this.pColor1.Name = "pColor1";
			this.pColor1.Size = new System.Drawing.Size(74, 23);
			this.pColor1.TabIndex = 1;
			// 
			// pDraw1
			// 
			this.pDraw1.Figures = null;
			this.pDraw1.Location = new System.Drawing.Point(0, 0);
			this.pDraw1.Name = "pDraw1";
			this.pDraw1.Size = new System.Drawing.Size(353, 293);
			this.pDraw1.TabIndex = 0;
			// 
			// pSaving1
			// 
			this.pSaving1.Location = new System.Drawing.Point(361, 240);
			this.pSaving1.Name = "pSaving1";
			this.pSaving1.Size = new System.Drawing.Size(73, 22);
			this.pSaving1.TabIndex = 4;
			// 
			// pOpening1
			// 
			this.pOpening1.Location = new System.Drawing.Point(360, 259);
			this.pOpening1.Name = "pOpening1";
			this.pOpening1.Size = new System.Drawing.Size(74, 23);
			this.pOpening1.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.CadetBlue;
			this.ClientSize = new System.Drawing.Size(464, 293);
			this.Controls.Add(this.pOpening1);
			this.Controls.Add(this.pSaving1);
			this.Controls.Add(this.pFigure1);
			this.Controls.Add(this.pWidth1);
			this.Controls.Add(this.pColor1);
			this.Controls.Add(this.pDraw1);
			this.Name = "Form1";
			this.Text = "Paint";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
			this.ResumeLayout(false);

        }

        #endregion

        private PDraw pDraw1;
        private PColor pColor1;
        private PWidth pWidth1;
        private PFigure pFigure1;
        private PSaving pSaving1;
        private POpening pOpening1;
    }
}

