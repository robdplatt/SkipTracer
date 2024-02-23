using EFR.SkipTracer.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Sources.CyberBackgroundChecks;

internal static class UriBuilder
{
    public static Uri GetUriByName(string baseUrl, string name, string city, string state)
    {
        return new Uri($"{baseUrl}/people/{name.Replace(" ", "-")}/{state}/{city.Replace(" ", "-")}");
    }

    public static Uri GetUriByPhoneNumber(string baseUrl, string phoneNumber)
    {
        return new Uri($"{baseUrl}/phone/{phoneNumber.ReplaceChars(new char[] { '(', ')', ' ' }, '-')}");
    }

    public static Uri GetUriByAddress(string baseUrl, string address, string city, string state)
    {
        return new Uri($"{baseUrl}/address/{address.Replace(" ","-")}/{city.Replace(" ", "-")}/{state}");
    }
}
