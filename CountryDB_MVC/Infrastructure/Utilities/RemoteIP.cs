using System.Net;

namespace CountryDB_MVC.Infrastructure.Utilities
{
    public static class RemoteIP
    {
        public static string GetIpAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }

            return "Local IP Address is not found!";
        }

        public static string IpAddress
        {
            get
            {
                return GetIpAddress();
            }
        }
    }
}
