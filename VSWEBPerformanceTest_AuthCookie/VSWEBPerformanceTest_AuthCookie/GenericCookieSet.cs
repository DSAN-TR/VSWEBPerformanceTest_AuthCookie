using Microsoft.VisualStudio.TestTools.WebTesting;
using System.ComponentModel;

namespace VSWEBPerformanceTest_AuthCookie
{
    [Description("This plugin can be used to set cookies for each request")]
    public class GenericCookieSet : WebTestPlugin
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public string Path { get; set; } = "/";

        public string Domain { get; set; }

        public override void PreRequest(object sender, PreRequestEventArgs e)
        {
            if (!string.IsNullOrEmpty(Domain))
            {
                e.Request.Cookies.Add(new System.Net.Cookie(Name, Value, Path, Domain));
            }

            e.Request.Cookies.Add(new System.Net.Cookie(Name, Value, Path));
        }
    }
}
