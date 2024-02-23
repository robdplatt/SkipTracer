using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Models;

public interface IParser
{
    ReadOnlyCollection<SkipTracerResult> ParseResult(SourceResult result);
    ReadOnlyCollection<SkipTracerResult> ParseHtml(string html,SourceResult? result = null);
}
