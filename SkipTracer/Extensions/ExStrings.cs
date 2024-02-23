using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.Extensions;

public static class ExStrings
{

    public static string ReplaceChars(this string str, char[] chars, char c)
    {
        return ReplaceChars(str, chars, c.ToString());
    }

    public static string ReplaceChars(this string str, char[] chars, string s)
    {
        var NewStr = new StringBuilder(str);

        foreach (var ch in chars)
        {
            NewStr.Replace(ch.ToString(), s);
        }

        return NewStr.ToString();
    }
}
