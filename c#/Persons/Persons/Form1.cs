using System;
using System.Windows.Forms;

namespace Persons
{
	public partial class Form1 : Form
	{
		DataBase db = new DataBase();
		public Form1()
		{
			InitializeComponent();
			db.GridView = dataGridView1;
		}

		private void btnRead_Click(object sender, EventArgs e)
		{
			db.FillGrid();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			int id = Int32.Parse(idTextBox.Text);
			string firstName = firstNameTextBox.Text;
			string lastName = lastNameTextBox.Text;
			int age = Int32.Parse(ageTextBox.Text);
			db.AddPerson(id, firstName, lastName, age);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			int id = Int32.Parse(idTextBox.Text);
			string firstName = firstNameTextBox.Text;
			string lastName = lastNameTextBox.Text;
			int age = Int32.Parse(ageTextBox.Text);
			db.UpdatePerson(id, firstName, lastName, age);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int id = Int32.Parse(idTextBox.Text);
			db.DeletePerson(id);
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
