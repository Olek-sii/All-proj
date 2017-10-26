using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace DataBaseApi
{
	class PersonDAO_MySQL : IPerson_DAO
	{
        string connectionString = @"server=localhost;user id=root;password=123456;persistsecurityinfo=True;database=persons";

        public void Create(Person p)
		{
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand(
                    "INSERT INTO persons (Id, FirstName, LastName, Age) " +
                    $"VALUES ({p.Id}, '{p.Fn}', '{p.Ln}', {p.Age})", connection);
                command.ExecuteNonQuery();
            }
        }

		public List<Person> Read()
		{
            List<Person> persons = new List<Person>();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("SELECT * FROM persons;", connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string fn = reader.GetString(1);
                    string ln = reader.GetString(2);
                    int age = reader.GetInt32(3);
                    persons.Add(new Person(id, fn, ln, age));
                }

            }
            return persons;
        }

		public void Update(Person p)
		{
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("UPDATE persons " +
                    $"SET FirstName='{p.Fn}', LastName='{p.Ln}', Age={p.Age}" +
                    $" WHERE Id = {p.Id};", connection);
                command.ExecuteNonQuery();
            }
        }

		public void Delete(Person p)
		{
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                MySqlCommand command = new MySqlCommand("Delete FROM persons " +
                    $"WHERE Id = {p.Id};", connection);
                command.ExecuteNonQuery();
            }
        }
	}
}