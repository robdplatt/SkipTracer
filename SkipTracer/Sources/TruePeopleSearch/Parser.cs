using EFR.SkipTracer.Models;
using HtmlAgilityPack;
using OpenQA.Selenium.DevTools.V119.DOM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Sources.TruePeopleSearch;

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

        var Nodes = Doc.DocumentNode.SelectNodes("//div[@class='card card-body shadow-form card-summary pt-3']");

        if (Nodes == null)
            return ParsedResults.AsReadOnly();

        foreach (var node in Nodes)
        {
            var Url = node.Descendants("a")
           .Where(a => a.InnerText.Trim() == "View Details &nbsp;")
           .Select(a => a.GetAttributeValue("href", ""))
           .FirstOrDefault();

            var FullName = node.Descendants("div")
                         .FirstOrDefault(d => d.Attributes["class"]?.Value == "h4")?.InnerText.Trim();

            var Age = node.Descendants("span")
                    .FirstOrDefault(s => s.Attributes["class"]?.Value == "content-label" && s.InnerText.Trim() == "Age")?
                    .ParentNode.SelectSingleNode("span[@class='content-value']")?.InnerText.Trim();

            var CurrentLocation = node.Descendants("span")
                                .FirstOrDefault(s => s.Attributes["class"]?.Value == "content-label" && s.InnerText.Trim() == "Lives in")?
                                .ParentNode.SelectSingleNode("span[@class='content-value']")?.InnerText.Trim();

            var PastLocations = node.Descendants("span")
                                .FirstOrDefault(s => s.Attributes["class"]?.Value == "content-label" && s.InnerText.Trim() == "Used to live in")?
                                .ParentNode.SelectSingleNode("span[@class='content-value']")?.InnerText.Trim();

            List<string> Addresses = new();
            if (!string.IsNullOrEmpty(CurrentLocation))
                Addresses.Add(CurrentLocation);
            if (!string.IsNullOrEmpty(PastLocations))
                Addresses.AddRange(PastLocations.Split(", "));

            var Result = new SkipTracerResult()
            {
                FullName = FullName,
                Age = Age,
                Addresses = Addresses.AsReadOnly(),
                MoreInfoURL = "https://www.truepeoplesearch.com/" + Url,
                Source = result,
            };

            ParsedResults.Add(Result);
        }

        return ParsedResults.AsReadOnly();
    }
}