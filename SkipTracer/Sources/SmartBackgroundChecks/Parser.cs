using EFR.SkipTracer.Models;
using HtmlAgilityPack;
using OpenQA.Selenium.DevTools.V119.DOM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Sources.SmartBackgroundChecks;

public class Parser : IParser
{
    public ReadOnlyCollection<SkipTracerResult> ParseResult(SourceResult result)
    {
        return ParseHtml(result.Html);
    }

    public ReadOnlyCollection<SkipTracerResult> ParseHtml(string html, SourceResult? result = null)
    {
        var ParsedResults = new List<SkipTracerResult>();

        var Doc = new HtmlAgilityPack.HtmlDocument();
        Doc.LoadHtml(html);

        var Nodes = Doc.DocumentNode.SelectNodes("//div[@class='p-1 w-100 lh-20px']");

        if (Nodes == null)
            return ParsedResults.AsReadOnly();

        foreach (var node in Nodes)
        {
            var Url = node.Descendants("a")
                    .Where(a => a.GetAttributeValue("href", "").Contains("/people/"))
                    .Select(a => a.GetAttributeValue("href", ""))
                    .FirstOrDefault();

            string NameCityAge = node.SelectSingleNode("//h2/a")?.InnerText;
            if (string.IsNullOrEmpty(NameCityAge))
                NameCityAge = node.SelectSingleNode("//h2").InnerText;

            string[] NameCityAgeParts = NameCityAge.Split(new string[] { " - ", " - Age " }, StringSplitOptions.RemoveEmptyEntries);
            string FullName = NameCityAgeParts[0];

            string Age = NameCityAgeParts.Last();
            if (Age.Contains("Age"))
                Age = Age.Split(' ')[1];

            // Extract home addresses
            var Addresses = node.Descendants("a")
                            .Where(node => node.GetAttributeValue("title", "").Contains("Reverse Address Search"))
                            .Select(a => a.InnerText)
                            .ToList();

            // Extract phone numbers
            var PhoneNumbers = node.Descendants("a")
                                .Where(node => node.GetAttributeValue("title", "").Contains("Unlock Phone Numbers"))
                                .Select(a => a.InnerText.Trim())
                                .ToList();

            // Extract AKA names
            string akaNames = node.Descendants("div")
                            .FirstOrDefault(d => d.InnerText.Contains("AKAs"))?
                                .NextSibling.InnerText.Trim();
            string[] akaNamesArray = akaNames?.Split("&#183;", StringSplitOptions.RemoveEmptyEntries);
            var Aliases = akaNamesArray?.Select(name => name.Trim()).ToList();

            var Result = new SkipTracerResult()
            {
                //Name = Name,
                FullName = FullName,
                Aliases = Aliases?.AsReadOnly(),
                Age = Age,
                Addresses = Addresses.ToList().AsReadOnly(),
                PhoneNumbers = PhoneNumbers.AsReadOnly(),
                MoreInfoURL = Url,
                Source = result,
            };

            ParsedResults.Add(Result);
        }

        return ParsedResults.AsReadOnly();
    }
}