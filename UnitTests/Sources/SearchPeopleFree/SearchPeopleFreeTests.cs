using EFR.SkipTracer;
using EFR.SkipTracer.Models;
using EFR.SkipTracer.Sources;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Sources.SearchPeopleFree;

public class SearchPeopleFreeTests
{
    private Source Source { get; } = Source.SearchPeopleFree;
    private BatchSearcher Searcher;

    [SetUp]
    public void Setup()
    {
        Searcher = new BatchSearcher(false);
    }

    [TearDown]
    public void TearDown()
    {
        Searcher.Dispose();
    }

    [Test]
    public async Task MultiSearchTestAsync()
    {
        var Request1 = RequestBuilder.CreateRequestByName("John Doe", "New York", "NY");
        var Results1 = await Searcher.SearchAsync(Request1, Source);
        Assert.That(Results1, Is.Not.Empty);

        var Request2 = RequestBuilder.CreateRequestByNumber("740-638-2293");
        var Results2 = await Searcher.SearchAsync(Request2, Source);

        Assert.That(Results2, Is.Not.Empty);

        var Request3 = RequestBuilder.CreateRequestByAddress("344 Cambridge N St", "Cumberland", "OH");
        var Results3 = await Searcher.SearchAsync(Request3, Source);

        Assert.That(Results3, Is.Not.Empty);
    }

    [Test]
    public async Task SearchByNameAsync()
    {
        var Request = RequestBuilder.CreateRequestByName("John Doe", "New York", "NY");
        var Results = await Searcher.SearchAsync(Request, Source);

        Assert.That(Results, Is.Not.Empty);
    }

    [Test]
    public async Task SearchByNumberAsync()
    {
        var Request = RequestBuilder.CreateRequestByNumber("740-638-2293");
        var Results = await Searcher.SearchAsync(Request, Source);

        Assert.That(Results, Is.Not.Empty);
    }

    [Test]
    public async Task SearchByAddressAsync()
    {
        var Request = RequestBuilder.CreateRequestByAddress("344 Cambridge N St", "Cumberland", "OH");
        var Results = await Searcher.SearchAsync(Request, Source);

        Assert.That(Results, Is.Not.Empty);
    }

    [Test]
    public void GetUriByName()
    {
        var Request = RequestBuilder.CreateRequestByName("John Doe", "New York", "NY");

        var Uri = Searcher.GetUris(Request, Source);
        Assert.That(Uri, Is.Not.Empty);
        Assert.That(Uri[0].AbsoluteUri, Is.EqualTo("https://www.searchpeoplefree.com/find/John-Doe/NY/New-York"));
    }

    [Test]
    public void GetUriByNumber()
    {
        var Request = RequestBuilder.CreateRequestByNumber("555-555-5555");

        var Uri = Searcher.GetUris(Request, Source);
        Assert.That(Uri, Is.Not.Empty);
        Assert.That(Uri[0].AbsoluteUri, Is.EqualTo("https://www.searchpeoplefree.com/phone-lookup/555-555-5555"));
    }

    [Test]
    public void GetUriByAddress()
    {
        var Request = RequestBuilder.CreateRequestByAddress("123 Main St", "New York", "NY");

        var Uri = Searcher.GetUris(Request, Source);
        Assert.That(Uri, Is.Not.Empty);
        Assert.That(Uri[0].AbsoluteUri, Is.EqualTo("https://www.searchpeoplefree.com/address/ny/ny/main-st/123"));
    }

    [Test]
    public void TestParser()
    {
        var Html = Properties.Resources.SearchPeopleFreeSample;
        var Results = new EFR.SkipTracer.Sources.SearchPeopleFree.Parser().ParseHtml(Html);

        Assert.That(Results, Is.Not.Empty);
    }
}