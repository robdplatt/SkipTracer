using EFR.SkipTracer.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Sources.SearchPeopleFree;

internal static class UriBuilder
{
    public static Uri GetUriByName(string baseUrl, string name, string city, string state)
    {
        return new Uri($"{baseUrl}/find/{name.Replace(" ", "-")}/{state}/{city.Replace(" ", "-")}");
    }

    public static Uri GetUriByPhoneNumber(string baseUrl, string phoneNumber)
    {
        return new Uri($"{baseUrl}/phone-lookup/{phoneNumber.ReplaceChars(new char[] { '(', ')', ' ' }, '-')}");
    }

    public static Uri GetUriByAddress(string baseUrl, string address, string city, string state)
    {
        if (city.Equals("New York", StringComparison.OrdinalIgnoreCase))
            city = "ny";

        return new Uri($"{baseUrl}/address/{state}/{ParseCity(city)}/{GetFormattedStreet(address)}/{GetFormattedNumber(address)}".ToLower());
    }

    private static string GetFormattedNumber(string address)
    {
        return $"{address.Split(' ')[0]}";
    }

    private static string GetFormattedStreet(string address)
    {
        string pattern = @"^(\d+)\s+(.*)$";
        Match match = Regex.Match(address, pattern);
        if (match.Success)
        {
            string numberPart = match.Groups[1].Value;
            string restPart = match.Groups[2].Value;

            return $"{restPart.Replace(" ", "-")}";
        }

        return string.Empty;
    }

    private static string ParseCity(string city)
    {
        string ParsedCity = city;

        if (city.Equals("New York", StringComparison.OrdinalIgnoreCase))
            ParsedCity = "ny";

        return ParsedCity;
    }
}
