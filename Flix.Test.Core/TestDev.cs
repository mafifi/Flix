using System;
using System.IO;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Xml;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Flix.Test.Core
{
    [TestClass]
    public class TestDev
    {
        [TestMethod]
        public void TestGetChannels()
        {
            var request =
                WebRequest.CreateHttp(
                    "http://itv.d-net.tw:7788/live.jsp?active=463051693213&pass=A7216616B258693738C4B593B5B7395D&mac=203927ae4e7fa2a");
            var responseTask = request.GetResponseAsync();
            var response = responseTask.Result;
            var contentType = new ContentType(response.ContentType);
            XmlDocument xml;
            using (var reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(contentType.CharSet)))
            {
                var encodedString = reader.ReadToEnd();
                var decodedBytes = Convert.FromBase64String(encodedString);
                var decodedString = Encoding.UTF8.GetString(decodedBytes, 0, decodedBytes.Length);
                xml = new XmlDocument();
                xml.LoadXml(decodedString);
            }

            
        }
    }
}
