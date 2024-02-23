using EFR.SkipTracer.Models;
using HtmlAgilityPack;
using OpenQA.Selenium.DevTools.V119.DOM;
using OpenQA.Selenium.DevTools.V119.Emulation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Sources.FastPeopleSearch;

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

        var Nodes = Doc.DocumentNode.SelectNodes("//div[@class='card-block']");

        if (Nodes == null)
            return ParsedResults.AsReadOnly();

        foreach (var node in Nodes)
        {
            var Url = node.Descendants("h2")
                    .Where(node => node.GetAttributeValue("class", "").Equals("card-title"))
                    .SelectMany(node => node.Descendants("a"))
                    .Select(a => a.GetAttributeValue("href", ""))
                    .FirstOrDefault();

            var Age = node.Descendants("h3")
                    .Where(node => node.InnerText.Trim() == "Age:")
                    .Select(node => node.NextSibling.InnerText.Trim())
                    .FirstOrDefault();

            var Name = node.Descendants("span")
                        .FirstOrDefault(span => span.GetAttributeValue("class", "") == "larger")
                         ?.InnerText.Trim();

            var FullName = node.Descendants("h3")
                        .Where(node => node.InnerText.Trim() == "Full Name:")
                        .Select(node => node.NextSibling.InnerText.Trim())
                        .FirstOrDefault();

            var GoesBy = node.Descendants("span")
                        .FirstOrDefault(span => span.GetAttributeValue("style", "") == "font-weight:normal;font-size:18px")
                         ?.InnerText.Trim().Replace("Goes By ", "");

            List<string> Aliases = new() { GoesBy };

            var CurrentAddress = node.Descendants("h3")
                                .Where(node => node.InnerText.Trim() == "Current Home Address:")
                                .Select(node => node.NextSibling.NextSibling.NextSibling.SelectSingleNode("strong/a").InnerText.Trim().Replace(Environment.NewLine, ", "))
                                .FirstOrDefault();

            var PastAddresses = node.Descendants("div")
                        .Where(div => div.GetAttributeValue("class", "") == "col-sm-12 col-md-6")
                        .SelectMany(div => div.Descendants("a"))
                        .Select(a => a.InnerText.Trim().Replace(Environment.NewLine, ", "))
                        .ToList();

            var Addresses = PastAddresses;
            if (!string.IsNullOrEmpty(CurrentAddress))
                Addresses.Insert(0, CurrentAddress);

            var PhoneNumbers = node.Descendants("a")
                            .Where(a => a.GetAttributeValue("class", "") == "nowrap" && a.GetAttributeValue("title", "").Contains("Search people with phone number"))
                            .Select(a => a.InnerText.Trim()).ToList();

            var Result = new SkipTracerResult()
            {
                Name = Name,
                FullName = FullName,
                Aliases = Aliases.AsReadOnly(),
                Age = Age,
                Addresses = Addresses.ToList().AsReadOnly(),
                PhoneNumbers = PhoneNumbers.AsReadOnly(),
                MoreInfoURL = "https://www.fastpeoplesearch.com/" + Url,
                Source = result
            };

            ParsedResults.Add(Result);
        }

        return ParsedResults.AsReadOnly();
    }
}