﻿using Microsoft.VisualStudio.TestTools.WebTesting;

namespace VSWEBPerformanceTest_AuthCookie
{
    public class GenericCookieSet : WebTestPlugin
    {
        public string Name { get; set; }
        public string Value { get; set; }

        public string Path { get; set; } = "/";

        public string Domain { get; set; }

        public override void PreRequest(object sender, PreRequestEventArgs e)
        {
            e.Request.Cookies.Add(new System.Net.Cookie(Name, Value, Path, Domain));
        }
    }
}