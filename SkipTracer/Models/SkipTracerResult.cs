using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Models;

public struct SkipTracerResult
{
    public SourceResult? Source { get; init; }

    public string Name { get; init; }
    public string FullName { get; init; }
    public ReadOnlyCollection<string> Aliases { get; init; }
    public string Age { get; init; }
    public ReadOnlyCollection<string>? Addresses { get; init; }

    //public required string City { get; init; }
    //public required string State { get; init; }
    //public required string Zip { get; init; }
    public ReadOnlyCollection<string> PhoneNumbers { get; init; }

    public string MoreInfoURL { get; init; }
}