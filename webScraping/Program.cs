using HtmlAgilityPack;
using ScrapySharp.Extensions;
using System;
using System.Linq;

namespace webScraping
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = "https://www.lawikitech.com";
            HtmlWeb web = new HtmlWeb();
            HtmlDocument html = web.Load(url);

            //Taking the body tag from the web page
            //HtmlNode node = html.DocumentNode.CssSelect("body").First();
            //Console.WriteLine(node.InnerHtml);

            //Displaying the innerText from every tags that have as the attribute "[class='entry-title h3']" in the webpage
            var nodes = html.DocumentNode.CssSelect("[class='entry-title h3']").Select(x => x.InnerText).Distinct();
            nodes.ToList().ForEach(e =>
            {
                Console.WriteLine(e);
            });
        }
    }
}
