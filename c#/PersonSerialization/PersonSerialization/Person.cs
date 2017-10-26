using System;

namespace PersonSerialization
{
	public class Person
	{
		private int Id;
		private string FirstName;
		private string LastName;
		private int Age;
		public Person(int Id, string FirstName, string LastName, int Age)
		{
			Init(Id, FirstName, LastName, Age);
		}
		public Person()
		{

		}
		public void Init(int Id, string FirstName, string LastName, int Age)
		{
			this.Id = Id;
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.Age = Age;
		}
		public string ToJson()
		{
			string json_string = "{";
			json_string += "Id:" + Id + ",";
			json_string += "FirstName:" + FirstName + ",";
			json_string += "LastName:" + LastName + ",";
			json_string += "Age:" + Age + "";
			json_string += "}";
			return json_string;
		}
		public void FromJson(string json_string)
		{
			string[] args = json_string.Split(':', ',', '}');
			Id = Int32.Parse(args[1]);
			FirstName = args[3];
			LastName = args[5];
			Age = Int32.Parse(args[7]);
		}
		public string ToCSV()
		{
			string csv_string = "";
			csv_string += Id + ", ";
			csv_string += FirstName + ", ";
			csv_string += LastName + ", ";
			csv_string += Age;
			return csv_string;
		}
		public void FromCSV(string csv_string)
		{
			string[] args = csv_string.Split(',');
			Id = Int32.Parse(args[0].Trim(' '));
			FirstName = args[1].Trim(' ');
			LastName = args[2].Trim(' ');
			Age = Int32.Parse(args[3].Trim(' '));
		}
		public string ToXML()
		{
			string xml_string = "<Person>";
			xml_string += "<Id>" + Id + "</Id>";
			xml_string += "<FirstName>" + FirstName + "</FirstName>";
			xml_string += "<LastName>" + LastName + "</LastName>";
			xml_string += "<Age>" + Age + "</Age>";
			xml_string += "</Person>";
			return xml_string;
		}
		public void FromXML(string xml_string)
		{
			string[] args = xml_string.Split('<', '>');
			Id = Int32.Parse(args[4]);
			FirstName = args[8];
			LastName = args[12];
			Age = Int32.Parse(args[16]);
		}
		public string ToYAML()
		{
			string yaml_string = "";
			yaml_string += "Id:" + Id;
			yaml_string += "\nFirstName:" + FirstName;
			yaml_string += "\nLastName:" + LastName;
			yaml_string += "\nAge:" + Age + "\n";
			return yaml_string;
		}
		public void FromYAML(string yaml_string)
		{
			string[] args = yaml_string.Split('\n', ':');
			Id = Int32.Parse(args[1]);
			FirstName = args[3];
			LastName = args[5];
			Age = Int32.Parse(args[7]);
		}
	}
}
