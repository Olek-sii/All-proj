namespace PaintWF
{
    partial class PWidth
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
            this.comboWidth = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboWidth
            // 
            this.comboWidth.FormattingEnabled = true;
            this.comboWidth.Location = new System.Drawing.Point(0, 0);
            this.comboWidth.Name = "comboWidth";
            this.comboWidth.Size = new System.Drawing.Size(74, 21);
            this.comboWidth.TabIndex = 0;
            this.comboWidth.SelectedIndexChanged += new System.EventHandler(this.SetWidth);
            // 
            // PWidth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboWidth);
            this.Name = "PWidth";
            this.Size = new System.Drawing.Size(74, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboWidth;
    }
}
