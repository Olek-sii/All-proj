using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.IO;
using Newtonsoft.Json;

namespace Server
{
	class Server
	{
		public Server()
		{
			PullMessages pullMessages = new PullMessages();
			HttpListener listener = new HttpListener();
			listener.Prefixes.Add("http://localhost:8080/");
			listener.Start();

			listener.BeginGetContext(ar =>
			{
				HttpListener l = (HttpListener)ar.AsyncState;

				while (true)
				{
					HttpListenerContext ctx = l.GetContext();
					ctx.Response.StatusCode = 200;
					string name = ctx.Request.QueryString["name"];
					string message = ctx.Request.QueryString["message"];
					DateTime dateTime = DateTime.Now;

					pullMessages.AddMessage(name, message, dateTime);

					StreamWriter writer = new StreamWriter(ctx.Response.OutputStream);

					writer.WriteLine("callback({0})", JsonConvert.SerializeObject(pullMessages.GetMessages(dateTime)));

					//Dictionary<string, string> json = new Dictionary<string, string>();
					//if (name == null)
					//	writer.WriteLine("<H1>Hello</H1>");
					//else
					//	writer.WriteLine("<P>Hello, {0}</P>", name);
					//foreach (string header in ctx.Request.Headers.Keys)
					//{
					//	json.Add(header, ctx.Request.Headers[header]);
					//}

					Console.WriteLine("[{0}] {1}: {2}", dateTime, name, message);



					//writer.WriteLine("callback({0})", JsonConvert.SerializeObject());

					writer.Close();
					ctx.Response.Close();
				}
				l.Stop();

			}, listener);
		}
	}
}
