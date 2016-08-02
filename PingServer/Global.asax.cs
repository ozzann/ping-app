using System.Net.NetworkInformation;
using System.Web;

namespace PingServer
{
	public class Global : HttpApplication
	{
		protected void Application_Start()
		{
			string hostName = "facebook.com";
			PingIt(hostName);
		}

		private string PingIt(string hostName)
		{
			Ping pingSender = new Ping();
			int timeout = 120;
			PingReply reply = pingSender.Send(hostName, timeout);
			if (reply.Status == IPStatus.Success)
			{
				return "Hello world";
			}

			return "";
		}
	}
}
