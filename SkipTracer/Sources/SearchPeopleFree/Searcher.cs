using EFR.SkipTracer.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EFR.SkipTracer.Sources.SearchPeopleFree;

internal class Searcher : ISearcher
{
    private string BaseUrl { get; } = "https://www.searchpeoplefree.com";
    private Source Source { get; } = Source.SearchPeopleFree;
    //private WebSearch.WebSearch WebSearch { get; }
    private bool Headless { get; }
    //internal Searcher(WebSearch.WebSearch webSearch)
    //{
    //    WebSearch = webSearch;
    //}
    internal Searcher(bool headless)
    {
        Headless = headless;
    }

    public Uri GetUriByName(string name, string city, string state) => UriBuilder.GetUriByName(BaseUrl, name, city, state);
    public Uri GetUriByPhoneNumber(string phoneNumber) => UriBuilder.GetUriByPhoneNumber(BaseUrl, phoneNumber);
    public Uri GetUriByAddress(string address, string city, string state) => UriBuilder.GetUriByAddress(BaseUrl, address, city, state);

    public ReadOnlyCollection<SkipTracerResult> SearchByName(string name, string city, string state)
    {
        using var Search = new WebSearch.WebSearch(Headless);
        var Result = Search.GetWebResults(GetUriByName(name, city, state), Source);

        var results = new Parser().ParseResult(Result);
        return results.AsReadOnly();
    }

    public ReadOnlyCollection<SkipTracerResult> SearchByNumber(string phoneNumber)
    {
        using var Search = new WebSearch.WebSearch(Headless);
        var Result = Search.GetWebResults(GetUriByPhoneNumber(phoneNumber), Source);

        var Results = new Parser().ParseResult(Result);
        return Results.AsReadOnly();
    }

    public ReadOnlyCollection<SkipTracerResult> SearchByAddress(string address, string city, string state)
    {
        using var Search = new WebSearch.WebSearch(Headless);
        var Result = Search.GetWebResults(GetUriByAddress(address, city, state), Source);

        var Results = new Parser().ParseResult(Result);
        return Results.AsReadOnly();
    }

    public async Task<ReadOnlyCollection<SkipTracerResult>> SearchByNameAsync(string name, string city, string state)
    {
        using var Search = new WebSearch.WebSearch(Headless);
        var Result = await Search.GetWebResultsAsync(GetUriByName(name, city, state), Source);

        var Results = new Parser().ParseResult(Result);
        return Results.AsReadOnly();
    }

    public async Task<ReadOnlyCollection<SkipTracerResult>> SearchByNumberAsync(string phoneNumber)
    {
        using var Search = new WebSearch.WebSearch(Headless);
        var Result = await Search.GetWebResultsAsync(GetUriByPhoneNumber(phoneNumber), Source);

        var Results = new Parser().ParseResult(Result);
        return Results.AsReadOnly();
    }

    public async Task<ReadOnlyCollection<SkipTracerResult>> SearchByAddressAsync(string address, string city, string state)
    {
        using var Search = new WebSearch.WebSearch(Headless);
        var Result = await Search.GetWebResultsAsync(GetUriByAddress(address, city, state), Source);

        var Results = new Parser().ParseResult(Result);
        return Results.AsReadOnly();
    }

  
}