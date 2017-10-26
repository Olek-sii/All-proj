using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ChatClientWinForms
{
	class Client
	{
		TcpClient tcpClient;
		NetworkStream stream;
		RichTextBox _output;

		public Client(ref RichTextBox output)
		{
			tcpClient = new TcpClient();
			tcpClient.Connect(IPAddress.Parse("127.0.0.1"), 8888);
			stream = tcpClient.GetStream();
			_output = output;

			Thread thread = new Thread(new ThreadStart(ReceiveMessages));
			thread.Start();
		}

		public void Send(string message)
		{
			try
			{
				byte[] data = System.Text.Encoding.UTF8.GetBytes(message);
				stream.Write(data, 0, data.Length);
			}
			catch
			{
			}
		}

		public void Close()
		{
			stream.Close();
			tcpClient.Close();
		}

		private void ReceiveMessages()
		{
			while (true)
			{


				try
				{
					byte[] dataResponce = new byte[64];
					int nBytes = stream.Read(dataResponce, 0, dataResponce.Length);
					string s = "Server: " + Encoding.UTF8.GetString(dataResponce, 0, nBytes) + '\n';
					_output.Invoke(new MethodInvoker(delegate {
						_output.AppendText(s);
					}));
				}
				catch
				{

				}
			}
		}
	}
}
