using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;

namespace LocalizationTest
{
	class PluginManager
	{
		public static List<IPlugin> GetPlugins()
		{
			List<IPlugin> list = new List<IPlugin>();
			DirectoryInfo directoryInfo = new DirectoryInfo("../../plugins");
			foreach (var file in directoryInfo.GetFiles("*.json"))
			{
				StreamReader streamReader = new StreamReader(file.FullName);
				JToken token = JObject.Parse(streamReader.ReadToEnd());
				list.Add(new FirstPlugin(token["text"].ToString()));
			}
			return list;
		}
	}
}
