namespace DataBaseApi
{
	public class Person
	{
		public int Id { get; set; }
		public string Fn { get; set; }
		public string Ln { get; set; }
		public int Age { get; set; }

		public Person(int id, string fn, string ln, int age)
		{
			this.Id = id;
			this.Fn = fn;
			this.Ln = ln;
			this.Age = age;
		}
	}
}