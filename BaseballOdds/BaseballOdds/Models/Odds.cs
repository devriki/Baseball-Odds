using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace BaseballOdds.Models
{
    public class Odds
    {
        public int OddsId { get; set; }
        public string HomeTeam { get; set; }
        public string AwayTeam { get; set; }
        public DateTime Date { get; set; }
        public double HomeOdds { get; set; }
        public double AwayOdds { get; set; }

    }

    public class WebReader
    {
        public List<Odds> odds;

        public WebReader()
        {
            string urlAddress = "http://www.oddschecker.com/baseball/mlb";
            string data = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
            request.Method = "GET";
            request.UserAgent = "Foo";
            request.Accept = "text/html";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;

                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else
                {
                    readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                }

                data = readStream.ReadToEnd();

                response.Close();
                readStream.Close();
            }

            List<string> result = new List<string>();

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(data);
            HtmlNode table = doc.DocumentNode.SelectSingleNode("//table[1]");
            foreach (var cell in table.SelectNodes(".//tr/td/p/span"))
            {

                string someVariable = cell.InnerText;
                Console.WriteLine(someVariable);
                result.Add(someVariable);

            }


            var today = DateTime.Today;


        }
    }


}