using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Models;

public class SourceResult
{
    public required Sources.Source Type { get; init; }
    public required string URL { get; init; }
    public required string Html { get; init; }
}
