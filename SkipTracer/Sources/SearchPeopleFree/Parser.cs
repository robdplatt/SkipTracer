using EFR.SkipTracer.Models;
using HtmlAgilityPack;
using OpenQA.Selenium.DevTools.V119.DOM;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Sources.SearchPeopleFree;

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

        var Nodes = Doc.DocumentNode.SelectNodes("//ol[@class='inline']/li[@class='toc l-i mb-5']");

        if (Nodes == null)
            return ParsedResults.AsReadOnly();

        foreach (var node in Nodes.Where(node => node.InnerText.Contains("More Free Details ⇒")))
        {
            var Url = node.Descendants("a")
                    .Where(a => a.InnerText.Trim() == "More Free Details ⇒")
                    .Select(a => a.GetAttributeValue("href", ""))
                    .FirstOrDefault();

            var AgeValue = node.Descendants("h3")
                           .FirstOrDefault(node => node.Attributes["class"]?.Value == "mb-3")
                           ?.Descendants("span")
                           .FirstOrDefault()
                           ?.InnerText.Trim();

            string Age = Regex.Match(AgeValue ?? "", @"\d+").Value;

            var Name = node.Descendants("i")
                        .FirstOrDefault(i => i.InnerText.Contains("Home address, vacation, business, rental and apartment property addresses for"))
                        ?.InnerText
                        .Replace("Home address, vacation, business, rental and apartment property addresses for ", "")
                        .Trim();

            var FullName = node.Descendants("h2")
                        .First().InnerText.Trim();
            FullName = FullName.Substring(0, FullName.IndexOf(" in "));

            string GoesBy = string.Empty;
            var NameLine = node.Descendants("h2")
                        .FirstOrDefault()?.InnerText.Trim();
            if (NameLine?.Contains("also ") == true)
                GoesBy = NameLine.Split(Environment.NewLine)[1].Replace("also ", "");

            List<string> Aliases = new() { GoesBy };

            var Addresses = node.Descendants("li")
                             .Where(li => li.GetAttributeValue("class", "") == "col-lg-6")
                            .SelectMany(li => li.Descendants("a"))
                            .Where(a => a.GetAttributeValue("href", "").Contains("address"))
                            .Select(a => a.InnerText.Trim())
                            .ToList();

            var PhoneNumbers = node.Descendants("li")
                            .Where(li => li.GetAttributeValue("class", "") == "col-md-6 col-lg-4")
                            .SelectMany(li => li.Descendants("a"))
                            .Where(a => a.GetAttributeValue("href", "").Contains("phone-lookup"))
                            .Select(a => a.InnerText.Trim())
                            .ToList();

            var Result = new SkipTracerResult()
            {
                Name = Name,
                FullName = FullName,
                Aliases = Aliases.AsReadOnly(),
                Age = Age,
                Addresses = Addresses.AsReadOnly(),
                PhoneNumbers = PhoneNumbers.AsReadOnly(),
                MoreInfoURL = "https://www.searchpeoplefree.com/" + Url,
                Source = result
            };

            ParsedResults.Add(Result);
        }

        return ParsedResults.AsReadOnly();
    }
}