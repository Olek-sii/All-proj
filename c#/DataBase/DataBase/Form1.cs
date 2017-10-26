using DataBaseApi;
using System;
using System.Windows.Forms;

namespace DataBaseWinForms
{
	public partial class Form1 : Form
	{
		TableModel tm = new TableModel();

		public Form1()
		{
			InitializeComponent();

			dbSelector.SelectedIndex = 0;

			tm.SetDataBase("MsSQL");
		}

		private Person GetPerson()
		{
			int id = Int32.Parse(idTextBox.Text);
			string fn = fnTextBox.Text;
			string ln = lnTextBox.Text;
			int age = Int32.Parse(ageTextBox.Text);
			return new Person(id, fn, ln, age);
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			tm.Create(GetPerson());
		}

		private void btnRead_Click(object sender, EventArgs e)
		{
			dataGridView.DataSource = tm.Read();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			tm.Update(GetPerson());
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			tm.Delete(GetPerson());
		}

		private void dbSelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			tm.SetDataBase(dbSelector.SelectedItem.ToString());
		}
	}
}