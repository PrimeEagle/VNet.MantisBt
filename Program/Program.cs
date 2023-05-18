using System;
using System.Threading.Tasks;
using VNet.MantisBt;

namespace Program
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            const string token = "pHIz2M83qcvWP_C-NbNswvTG4rsj3Y77";
            const string baseUrl = "http://matrix.tplinkdns.com/mantisbt";

            var mantis = new MantisBt(new Uri(baseUrl), token);

            var result = await mantis.GetIssue(4);
        }
    }
}
