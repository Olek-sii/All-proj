using System.Collections.Generic;
using System.IO;

namespace PersonSerialization
{
	public class PersonSerializationReaderWriter
	{
		public static List<Person> FromXML(string path)
		{
			List<Person> temp = new List<Person>();
			StreamReader data = new StreamReader(path);
			string str;
			while (!data.EndOfStream)
			{
				str = data.ReadLine();
				Person p = new Person();
				p.FromXML(str);
				temp.Add(p);
			}
			data.Close();
			return temp;
		}
		public static List<Person> FromCSV(string path)
		{
			List<Person> temp = new List<Person>();
			StreamReader data = new StreamReader(path);
			string str;
			data.ReadLine();
			while (!data.EndOfStream)
			{
				str = data.ReadLine();
				Person p = new Person();
				p.FromCSV(str);
				temp.Add(p);
			}
			data.Close();
			return temp;
		}
		public static List<Person> FromJson(string path)
		{
			List<Person> temp = new List<Person>();
			StreamReader data = new StreamReader(path);
			string str;
			while (!data.EndOfStream)
			{
				str = data.ReadLine();
				Person p = new Person();
				p.FromJson(str);
				temp.Add(p);
			}
			data.Close();
			return temp;
		}
		public static List<Person> FromYAML(string path)
		{
			List<Person> temp = new List<Person>();
			StreamReader data = new StreamReader(path);
			string str = "";
			while (!data.EndOfStream)
			{
				for (int i = 0; i < 4; ++i)
				{
					str += data.ReadLine() + "\n";
				}
				Person p = new Person();
				p.FromYAML(str);
				temp.Add(p);
				str = "";
				data.ReadLine();
			}
			data.Close();
			return temp;
		}
		public static void ToXML(List<Person> persons, string path)
		{
			StreamWriter sw = new StreamWriter(path);
			foreach (Person p in persons)
			{
				sw.WriteLine(p.ToXML());
			}
			sw.Close();
		}
		public static void ToCSV(List<Person> persons, string path)
		{
			StreamWriter sw = new StreamWriter(path);
			sw.WriteLine("Id, FirstName, LastName, Age");
			foreach (Person p in persons)
			{
				sw.WriteLine(p.ToCSV());
			}
			sw.Close();
		}
		public static void ToYAML(List<Person> persons, string path)
		{
			StreamWriter sw = new StreamWriter(path);
			foreach (Person p in persons)
			{
				sw.WriteLine(p.ToYAML());
			}
			sw.Close();
		}
		public static void ToJson(List<Person> persons, string path)
		{
			StreamWriter sw = new StreamWriter(path);
			foreach (Person p in persons)
			{
				sw.WriteLine(p.ToJson());
			}
			sw.Close();
		}
	}
}
