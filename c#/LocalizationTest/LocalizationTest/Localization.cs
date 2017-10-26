using System.IO;
using Newtonsoft.Json.Linq;

namespace LocalizationTest {
	public class Localization {
		private static string currLocale = "en";
		public static string Locale { set { currLocale = value; OnLocalChange(); } }

		public delegate void OnLocalChangeDelegate();
		public static event OnLocalChangeDelegate OnLocalChange;

		public static string GetText(string id)
		{
			string locFile = "";
			if (currLocale == "en")
				locFile = "../../locale_en.json";
			else 
				locFile = "../../locale_ru.json";

			string res = "qwerty";
			using (StreamReader streamReader = new StreamReader(locFile)) {
				JToken token = JObject.Parse(streamReader.ReadToEnd());
				res = token[id].ToString();
			}

			return res;
		}
	}
}
