using System;
using System.Collections.Generic;
using System.Linq;

namespace Server
{
	public class Message
	{
		public string name;
		public string message;
		public DateTime date;

		public Message(string name, string message, DateTime date)
		{
			this.name = name;
			this.message = message;
			this.date = date;
		}
	}

	public class PullMessages
	{
		List<Message> _messages = new List<Message>();

		public void AddMessage(string name, string message, DateTime date)
		{
			_messages.Add(new Message(name, message, date));
		}

		public List<Message> GetMessages(DateTime date)
		{
			List<Message> list = new List<Message>();
			list.AddRange(_messages.Where((x) => x.date < date));
			return list;
		}
	}
}
