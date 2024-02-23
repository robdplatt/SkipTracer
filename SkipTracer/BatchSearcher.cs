using EFR.SkipTracer.Models;
using EFR.SkipTracer.Sources;
using System.Collections.ObjectModel;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace EFR.SkipTracer;

public class BatchSearcher : IDisposable
{
    //private Source[] Sources;
    //private WebSearch.WebSearch? WebSearch { get; set; } //= new WebSearch.WebSearch();

    private bool Headless { get; init; }

    public BatchSearcher(bool headless = true)
    {
        Headless = headless;
    }

    private Source[] GetAllSources()
    {
        return new Source[]
            {
                Source.FastPeopleSearch,
                Source.SearchPeopleFree,             
                //Source.TruePeopleSearch,
                Source.CyberBackgroundChecks,
                Source.SmartBackgroundChecks,
            };
    }

    private ReadOnlyCollection<ISearcher> GetSearchers(params Source[] sources)
    {
        if (sources.Length == 0)
            sources = GetAllSources();

        var Searchers = new List<ISearcher>();
        foreach (var source in sources)
        {
            Searchers.Add(source switch
            {
                Source.FastPeopleSearch => new Sources.FastPeopleSearch.Searcher(Headless),
                Source.SearchPeopleFree => new Sources.SearchPeopleFree.Searcher(Headless),
                Source.TruePeopleSearch => new Sources.TruePeopleSearch.Searcher(Headless),
                Source.CyberBackgroundChecks => new Sources.CyberBackgroundChecks.Searcher(Headless),
                Source.SmartBackgroundChecks => new Sources.SmartBackgroundChecks.Searcher(Headless),
                _ => throw new NotImplementedException()
            });
        }
        return Searchers.AsReadOnly();
    }

    public async Task<ReadOnlyCollection<SkipTracerResult>> SearchAsync(SkipTracerRequest request, params Source[] sources)
    {
        //WebSearch ??= new WebSearch.WebSearch(Headless);

        var Searchers = GetSearchers(sources);
        var searchTasks = Searchers.Select(async s =>
        {
            switch (request.Type)
            {
                case SkipTracerRequestType.NameCityState:
                    return await s.SearchByNameAsync(request.Name, request.City, request.State);

                case SkipTracerRequestType.PhoneNumber:
                    return await s.SearchByNumberAsync(request.PhoneNumber);

                case SkipTracerRequestType.AddressCityState:
                    return await s.SearchByAddressAsync(request.Address, request.City, request.State);

                default:
                    throw new NotImplementedException();
            }
        });

        var results = await Task.WhenAll(searchTasks);
        return results.SelectMany(result => result).ToList().AsReadOnly();
    }

    public ReadOnlyCollection<SkipTracerResult> Search(SkipTracerRequest request, params Source[] sources)
    {
        //WebSearch ??= new WebSearch.WebSearch(Headless);

        var Searchers = GetSearchers(sources);
        var searchTasks = Searchers.Select(s =>
        {
            switch (request.Type)
            {
                case SkipTracerRequestType.NameCityState:
                    return s.SearchByName(request.Name, request.City, request.State);

                case SkipTracerRequestType.PhoneNumber:
                    return s.SearchByNumber(request.PhoneNumber);

                case SkipTracerRequestType.AddressCityState:
                    return s.SearchByAddress(request.Address, request.City, request.State);

                default:
                    throw new NotImplementedException();
            }
        });

        var results = searchTasks.SelectMany(result => result);
        return results.ToList().AsReadOnly();
    }

    public ReadOnlyCollection<Uri> GetUris(SkipTracerRequest request, params Source[] sources)
    {
        var Searchers = GetSearchers(sources);
        var Results = Searchers.Select(s =>
        {
            switch (request.Type)
            {
                case SkipTracerRequestType.NameCityState:
                    return s.GetUriByName(request.Name, request.City, request.State);

                case SkipTracerRequestType.PhoneNumber:
                    return s.GetUriByPhoneNumber(request.PhoneNumber);

                case SkipTracerRequestType.AddressCityState:
                    return s.GetUriByAddress(request.Address, request.City, request.State);

                default:
                    throw new NotImplementedException();
            }
        });

        return Results.ToList().AsReadOnly();
    }

    public void Dispose()
    {
        //WebSearch?.Dispose();
    }

    //public async Task<ReadOnlyCollection<SkipTracerResult>> SearchByNameAsync(string name, string city, string state)
    //{
    //    var Searchers = GetSearchers();
    //    var searchTasks = Searchers.Select(s => s.SearchByNameAsync(name, city, state));
    //    var results = await Task.WhenAll(searchTasks);
    //    return results.SelectMany(result => result).ToList().AsReadOnly();
    //}

    //public async Task<ReadOnlyCollection<SkipTracerResult>> SearchByNumberAsync(string phoneNumber)
    //{
    //    var Searchers = GetSearchers();
    //    var searchTasks = Searchers.Select(s => s.SearchByNumberAsync(phoneNumber));
    //    var results = await Task.WhenAll(searchTasks);
    //    return results.SelectMany(result => result).ToList().AsReadOnly();
    //}

    //public async Task<ReadOnlyCollection<SkipTracerResult>> SearchByAddressAsync(string address, string city, string state)
    //{
    //    var Searchers = GetSearchers();
    //    var searchTasks = Searchers.Select(s => s.SearchByAddressAsync(address, city, state));
    //    var results = await Task.WhenAll(searchTasks);
    //    return results.SelectMany(result => result).ToList().AsReadOnly();
    //}

    //public ReadOnlyCollection<SkipTracerResult> SearchByName(string name, string city, string state)
    //{
    //    var Searchers = GetSearchers();
    //    var searchTasks = Searchers.Select(s => s.SearchByName(name, city, state));
    //    var results = searchTasks.SelectMany(result => result);
    //    return results.ToList().AsReadOnly();
    //}

    //public ReadOnlyCollection<SkipTracerResult> SearchByNumber(string phoneNumber)
    //{
    //    var Searchers = GetSearchers();
    //    var searchTasks = Searchers.Select(s => s.SearchByNumber(phoneNumber));
    //    var results = searchTasks.SelectMany(result => result);
    //    return results.ToList().AsReadOnly();
    //}

    //public ReadOnlyCollection<SkipTracerResult> SearchByAddress(string address, string city, string state)
    //{
    //    var Searchers = GetSearchers();
    //    var searchTasks = Searchers.Select(s => s.SearchByAddress(address, city, state));
    //    var results = searchTasks.SelectMany(result => result);
    //    return results.ToList().AsReadOnly();
    //}
}