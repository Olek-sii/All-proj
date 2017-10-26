using System.Collections.Generic;

namespace DataBaseApi
{
	class PersonDAO_H2 : IPerson_DAO
	{
		List<Person> persons = new List<Person>();

		public void Create(Person p)
		{
			persons.Add(p);
		}

		public List<Person> Read()
		{
			return persons;
		}

		public void Update(Person p)
		{
			Person foundP = persons.Find(x => x.Id == p.Id);
			foundP.Fn = p.Fn;
			foundP.Ln = p.Ln;
			foundP.Age = p.Age;
		}

		public void Delete(Person p)
		{
			p = persons.Find(x => x.Id == p.Id);
			persons.Remove(p);
		}
	}
}