using HtmlAgilityPack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductEvolutionV1._3.Core.Site
{
    internal class SiteParser : IParser<string[]>
    {
        public string[] Parse(HtmlDocument htmlDocument)
        {
            var list = new List<string>();
            ArrayList listPrise = new ArrayList();
            ArrayList listName = new ArrayList();

            foreach (HtmlNode node in htmlDocument.DocumentNode.SelectNodes("//div[contains(@class, 'iva-item-body-KLUuy')]//a[@title]"))
            {
                list.Add(node.InnerText);
            }

            foreach (HtmlNode node in htmlDocument.DocumentNode.SelectNodes("//div[contains(@class, 'iva-item-body-KLUuy')]//meta[contains(@itemprop, 'price')]"))
            {
                listPrise.Add(node.InnerText);
            }

            return list.ToArray();
        }
    }
}
