namespace PaintWF
{
    partial class PColor
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dlgColor = new System.Windows.Forms.ColorDialog();
            this.bSetColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSetColor
            // 
            this.bSetColor.Location = new System.Drawing.Point(0, 0);
            this.bSetColor.Name = "bSetColor";
            this.bSetColor.Size = new System.Drawing.Size(75, 23);
            this.bSetColor.TabIndex = 0;
            this.bSetColor.Text = "Set Color";
            this.bSetColor.UseVisualStyleBackColor = true;
            this.bSetColor.Click += new System.EventHandler(this.SetColor);
            // 
            // PColor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bSetColor);
            this.Name = "PColor";
            this.Size = new System.Drawing.Size(74, 23);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog dlgColor;
        private System.Windows.Forms.Button bSetColor;
    }
}
