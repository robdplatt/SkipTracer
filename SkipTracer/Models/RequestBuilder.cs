using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Models;

public static class RequestBuilder
{
    public static SkipTracerRequest CreateRequestByName(string name, string city, string state)
    {
        return new SkipTracerRequest()
        {
            Type = SkipTracerRequestType.NameCityState,
            Name = name,
            City = city,
            State = state,
        };
    }

    private static string FormatNumber(string phoneNumber)
    {
        return phoneNumber.Replace("(", "").Replace(")", "").Replace(" ", "-");
    }

    public static SkipTracerRequest CreateRequestByNumber(string phoneNumber)
    {
        return new SkipTracerRequest()
        {
            Type = SkipTracerRequestType.PhoneNumber,
            PhoneNumber = FormatNumber(phoneNumber),
        };
    }

    public static SkipTracerRequest CreateRequestByAddress(string address, string city, string state)
    {
        return new SkipTracerRequest()
        {
            Type = SkipTracerRequestType.AddressCityState,
            Address = address,
            City = city,
            State = state,
        };
    }

    //public static SkipTracerRequest CreateSkipTracerRequestByZip(string Address, string Zip)
    //{
    //    return new SkipTracerRequest()
    //    {
    //        Type = SkipTracerRequestType.AddressZip,
    //        Address = Address,
    //        Zip = Zip
    //    };
    //}
}