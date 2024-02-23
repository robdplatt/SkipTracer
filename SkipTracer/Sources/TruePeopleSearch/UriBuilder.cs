using EFR.SkipTracer.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Sources.TruePeopleSearch;

internal static class UriBuilder
{
    public static Uri GetUriByName(string baseUrl, string name, string city, string state)
    {
        return new Uri($"{baseUrl}/results?name={name.Replace(" ", "%20")}&citystatezip={city.Replace(" ", "%20")},%20{state}");
    }

    public static Uri GetUriByPhoneNumber(string baseUrl, string phoneNumber)
    {
        return new Uri($"{baseUrl}/resultphone?phoneno={phoneNumber.Replace(" ",string.Empty)}");
    }

    public static Uri GetUriByAddress(string baseUrl, string address, string city, string state)
    {
        return new Uri($"{baseUrl}/resultaddress?streetaddress={address.Replace(" ","%20")}&citystatezip={city.Replace(" ", "%20")},%20{state}");
    }
}
