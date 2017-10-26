using System;
using System.Runtime.Serialization;

namespace List
{
	public class EmptyArrayEx : Exception
	{
		public EmptyArrayEx()
		{
		}

		public EmptyArrayEx(string message) : base(message)
		{
		}

		public EmptyArrayEx(string message, EmptyArrayEx innerException) : base(message, innerException)
		{
		}

		protected EmptyArrayEx(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}
	}
}