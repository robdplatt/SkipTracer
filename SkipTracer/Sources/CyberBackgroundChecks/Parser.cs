using EFR.SkipTracer.Models;
using HtmlAgilityPack;
using OpenQA.Selenium.DevTools.V119.DOM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Sources.CyberBackgroundChecks;

public class Parser : IParser
{
    public ReadOnlyCollection<SkipTracerResult> ParseResult(SourceResult result)
    {
        return ParseHtml(result.Html);
    }

    public ReadOnlyCollection<SkipTracerResult> ParseHtml(string html, SourceResult? result = null)
    {
        List<SkipTracerResult> ParsedResults = new();

        var Doc = new HtmlAgilityPack.HtmlDocument();
        Doc.LoadHtml(html);

        var nodes = Doc.DocumentNode.Descendants("div")
                    .Where(node => node.GetAttributeValue("class", "").Contains("card-hover"));//("//div[contains(@class='card-hover'])");

        foreach (var node in nodes)
        {
            var Url = node.Descendants("a")
                    .Where(a => a.GetAttributeValue("class", "") == "btn btn-primary btn-block")
                    .Select(a => a.GetAttributeValue("href", ""))
                    .FirstOrDefault();

            var Age = node.Descendants("span")
                            .FirstOrDefault(node => node.GetAttributeValue("class", "") == "age")?.InnerText.Trim();

            var Name = node.Descendants("span")
                            .FirstOrDefault(node => node.GetAttributeValue("class", "") == "name-searched-on")?.InnerText.Trim();

            var FullName = node.Descendants("span")
                            .FirstOrDefault(node => node.GetAttributeValue("class", "") == "name-given")?.InnerText.Trim();

            var Aliases = node.Descendants("span")
                            .Where(node => node.GetAttributeValue("class", "") == "aka")
                            .Select(node => node.InnerText.Trim())
                            .ToList();

            var Address = node.Descendants("span")
                            .Where(node => node.GetAttributeValue("class", "") == "address")
                            .Select(node => node.InnerText.Trim())
                            .ToList();

            var Addresses = node.Descendants("a")
                            .Where(node => node.GetAttributeValue("class", "") == "address")
                            .Select(node => node.InnerText.Trim())
                            .ToList();

            var PhoneNumbers = node.Descendants("a")
                            .Where(node => node.GetAttributeValue("class", "") == "phone")
                            .Select(node => node.InnerText.Trim())
                            .ToList();

            var Result = new SkipTracerResult()
            {
                Name = Name,
                FullName = FullName,
                Aliases = Aliases.AsReadOnly(),
                Age = Age,
                Addresses = Addresses.AsReadOnly(),
                PhoneNumbers = PhoneNumbers.AsReadOnly(),
                MoreInfoURL = "https://www.cyberbackgroundchecks.com/" + Url,
            };

            ParsedResults.Add(Result);
        }

        return ParsedResults.AsReadOnly();
    }
}