using EFR.SkipTracer;
using EFR.SkipTracer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests;

public class UriTests
{
    [Test]
    public void GetUris()
    {
        var Request = RequestBuilder.CreateRequestByName("John Doe", "New York", "NY");
        var Searcher = new BatchSearcher();

        var Uris = Searcher.GetUris(Request);

        Assert.That(Uris, Is.Not.Empty);
    }
}