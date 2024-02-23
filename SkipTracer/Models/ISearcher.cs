using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Models;

public interface ISearcher
{
    Uri GetUriByName(string name, string city, string state);
    Uri GetUriByPhoneNumber(string phoneNumber);
    Uri GetUriByAddress(string address, string city, string state);
    Task<ReadOnlyCollection<SkipTracerResult>> SearchByNameAsync(string name, string city, string state);

    Task<ReadOnlyCollection<SkipTracerResult>> SearchByNumberAsync(string phoneNumber);

    Task<ReadOnlyCollection<SkipTracerResult>> SearchByAddressAsync(string address, string city, string state);

    ReadOnlyCollection<SkipTracerResult> SearchByName(string name, string city, string state);

    ReadOnlyCollection<SkipTracerResult> SearchByNumber(string phoneNumber);

    ReadOnlyCollection<SkipTracerResult> SearchByAddress(string address, string city, string state);
}