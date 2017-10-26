using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Persons
{
	class DataBase
	{

		public DataGridView GridView { get; set; }

		string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\projects\c#\Persons\Persons\db.mdf;";

		public void FillGrid()
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "SELECT * FROM [persons]";
					command.CommandType = CommandType.Text;
					command.ExecuteNonQuery();
					DataTable dt = new DataTable();
					SqlDataAdapter adapter = new SqlDataAdapter(command);
					adapter.Fill(dt);
					GridView.DataSource = dt;
				}
			}
		}

		public void AddPerson(int id, string firstName, string lastName, int age)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "INSERT INTO [persons]  VALUES ('" +
						+ id + "','" + firstName + "','" + lastName + "','" + age + "')";
					command.CommandType = CommandType.Text;
					command.ExecuteNonQuery();
				}
			}
		}

		public void UpdatePerson(int id, string firstName, string lastName, int age)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "UPDATE [persons]" + 
						"SET FirstName = '" + firstName +
						"', Lastname='" + lastName +
						"', Age = '" + age + "'" +
						"WHERE ID = '" + id + "'";
					command.CommandType = CommandType.Text;
					command.ExecuteNonQuery();
				}
			}
		}

		public void DeletePerson(int id)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				connection.Open();
				using (var command = connection.CreateCommand())
				{
					command.CommandText = "DELETE FROM [persons]" +
						"WHERE ID = '" + id + "'";
					command.CommandType = CommandType.Text;
					command.ExecuteNonQuery();
				}
			}
		}
	}
}
