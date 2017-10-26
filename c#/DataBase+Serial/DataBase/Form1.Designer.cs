namespace DataBaseWinForms
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.fnTextBox = new System.Windows.Forms.TextBox();
            this.lnTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dbSelector = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(445, 276);
            this.dataGridView.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(11, 308);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(100, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(11, 282);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // fnTextBox
            // 
            this.fnTextBox.Location = new System.Drawing.Point(117, 282);
            this.fnTextBox.Name = "fnTextBox";
            this.fnTextBox.Size = new System.Drawing.Size(100, 20);
            this.fnTextBox.TabIndex = 3;
            // 
            // lnTextBox
            // 
            this.lnTextBox.Location = new System.Drawing.Point(223, 282);
            this.lnTextBox.Name = "lnTextBox";
            this.lnTextBox.Size = new System.Drawing.Size(100, 20);
            this.lnTextBox.TabIndex = 4;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(329, 282);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(117, 308);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(100, 23);
            this.btnRead.TabIndex = 6;
            this.btnRead.Text = "read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(223, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(329, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dbSelector
            // 
            this.dbSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dbSelector.FormattingEnabled = true;
            this.dbSelector.Items.AddRange(new object[] {
            "MsSQL",
            "MySQL",
            "H2",
            "CSV",
            "JSON",
            "XML",
            "YAML"});
            this.dbSelector.Location = new System.Drawing.Point(12, 337);
            this.dbSelector.Name = "dbSelector";
            this.dbSelector.Size = new System.Drawing.Size(99, 21);
            this.dbSelector.TabIndex = 9;
            this.dbSelector.SelectedIndexChanged += new System.EventHandler(this.dbSelector_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 370);
            this.Controls.Add(this.dbSelector);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.lnTextBox);
            this.Controls.Add(this.fnTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "DB";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox fnTextBox;
		private System.Windows.Forms.TextBox lnTextBox;
		private System.Windows.Forms.TextBox ageTextBox;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ComboBox dbSelector;
	}
}

