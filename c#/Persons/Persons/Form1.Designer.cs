namespace Persons
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
			this.btnRead = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idTextBox = new System.Windows.Forms.TextBox();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.ageTextBox = new System.Windows.Forms.TextBox();
			this.btnCreate = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRead
			// 
			this.btnRead.Location = new System.Drawing.Point(449, 201);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(100, 23);
			this.btnRead.TabIndex = 0;
			this.btnRead.Text = "read";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(443, 294);
			this.dataGridView1.TabIndex = 1;
			// 
			// idTextBox
			// 
			this.idTextBox.Location = new System.Drawing.Point(449, 56);
			this.idTextBox.Name = "idTextBox";
			this.idTextBox.Size = new System.Drawing.Size(100, 20);
			this.idTextBox.TabIndex = 2;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(449, 87);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.firstNameTextBox.TabIndex = 3;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(449, 116);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.lastNameTextBox.TabIndex = 4;
			// 
			// ageTextBox
			// 
			this.ageTextBox.Location = new System.Drawing.Point(449, 146);
			this.ageTextBox.Name = "ageTextBox";
			this.ageTextBox.Size = new System.Drawing.Size(101, 20);
			this.ageTextBox.TabIndex = 5;
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(449, 172);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(100, 23);
			this.btnCreate.TabIndex = 6;
			this.btnCreate.Text = "create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(449, 230);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(100, 23);
			this.btnUpdate.TabIndex = 7;
			this.btnUpdate.Text = "update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(449, 259);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(100, 23);
			this.btnDelete.TabIndex = 8;
			this.btnDelete.Text = "delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "MsSQL",
            "H2"});
			this.comboBox1.Location = new System.Drawing.Point(450, 13);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 9;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(579, 294);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.ageTextBox);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.idTextBox);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnRead);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.TextBox idTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox ageTextBox;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.ComboBox comboBox1;
	}
}

