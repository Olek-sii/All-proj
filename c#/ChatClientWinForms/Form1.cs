using System;
using System.Windows.Forms;

namespace ChatClientWinForms
{
	public partial class Form1 : Form
	{
		Client client;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			client = new Client(ref richTextBox1);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			client.Close();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			client.Send(textBox1.Text);
		}
	}
}
