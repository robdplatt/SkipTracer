using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Models;

public struct SkipTracerRequest
{
    public string Name { get; init; }
    public string PhoneNumber { get; init; }
    public string Address { get; init; }
    public string City { get; init; }
    public string State { get; init; }
    public string Zip { get; init; }

    public required SkipTracerRequestType Type { get; init; }
}