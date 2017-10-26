using System;

namespace DataBaseApi
{
	public class DBFactory
	{
		public static IPerson_DAO getInstance(string key)
		{
			IPerson_DAO db = null;

			switch (key)
			{
				case "MsSQL": db = new PersonDAO_MsSQL(); break;
				case "MySQL": db = new PersonDAO_MySQL(); break;
				case "H2": db = new PersonDAO_H2(); break;
				default: throw new ArgumentException();
			}

			return db;
		}
	}
}