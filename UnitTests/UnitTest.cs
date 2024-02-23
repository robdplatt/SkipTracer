using EFR.SkipTracer;
using EFR.SkipTracer.Models;

namespace UnitTests;

public class Tests
{
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
        var Results1 = await Searcher.SearchAsync(Request1);
        Assert.That(Results1, Is.Not.Empty);

        var Request2 = RequestBuilder.CreateRequestByNumber("740-638-2293");
        var Results2 = await Searcher.SearchAsync(Request2);

        Assert.That(Results2, Is.Not.Empty);

        var Request3 = RequestBuilder.CreateRequestByAddress("344 Cambridge N St", "Cumberland", "OH");
        var Results3 = await Searcher.SearchAsync(Request3);

        Assert.That(Results3, Is.Not.Empty);
    }

    [Test]
    public async Task SearchByNameAsync()
    {
        var Request = RequestBuilder.CreateRequestByName("John Doe", "New York", "NY");
        var Results = await Searcher.SearchAsync(Request);

        Assert.That(Results, Is.Not.Empty);
    }

    [Test]
    public async Task SearchByNumberAsync()
    {
        var Request = RequestBuilder.CreateRequestByNumber("740-638-2293");
        var Results = await Searcher.SearchAsync(Request);

        Assert.That(Results, Is.Not.Empty);
    }

    [Test]
    public async Task SearchByAddressAsync()
    {
        var Request = RequestBuilder.CreateRequestByAddress("123 Main St", "New York", "NY");
        var Results = await Searcher.SearchAsync(Request);

        Assert.That(Results, Is.Not.Empty);
    }

    [Test]
    public void SearchByName()
    {
        var Request = RequestBuilder.CreateRequestByName("John Doe", "Gig Harbor", "WA");
        var Results = Searcher.Search(Request);

        Assert.That(Results, Is.Not.Empty);
    }

    [Test]
    public void SearchByNumber()
    {
        var Request = RequestBuilder.CreateRequestByNumber("740-638-2293");
        var Results = Searcher.Search(Request);

        Assert.That(Results, Is.Not.Empty);
    }

    [Test]
    public void SearchByAddress()
    {
        var Request = RequestBuilder.CreateRequestByAddress("123 Main St", "New York", "NY");
        var Results = Searcher.Search(Request);

        Assert.That(Results, Is.Not.Empty);
    }

    [Test]
    public async Task SearchByName2Async()
    {
        var Request = RequestBuilder.CreateRequestByName("John Doe", "Gig Harbor", "WA");
        var Results = await Searcher.SearchAsync(Request);

        Assert.That(Results, Is.Not.Empty);
    }
}