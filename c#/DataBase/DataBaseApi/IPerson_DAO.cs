using System.Collections.Generic;

namespace DataBaseApi
{
    public interface IPerson_DAO
    {
		void Create(Person p);
		List<Person> Read();
		void Update(Person p);
		void Delete(Person p);
	}
}