using EFR.SkipTracer.Models;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V119.HeadlessExperimental;
using OpenQA.Selenium.Interactions;
using SeleniumUndetectedChromeDriver;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EFR.SkipTracer.WebSearch;

internal class WebSearch : IDisposable
{
    private bool Headless { get; set; }
    private bool IsInitialized { get; set; } = false;
    private ChromeOptions? Options { get; set; }
    private UndetectedChromeDriver? Driver { get; set; }

    internal WebSearch(bool headless)
    {
        Headless = headless;    
    }

    private void Initialize()
    {
        Options = new ChromeOptions();
        Options.PageLoadStrategy = PageLoadStrategy.Eager;
        //https://peter.sh/experiments/chromium-command-line-switches/
        Options.AddArgument("--disable-gpu");
        Options.AddArgument("--disable-popup-blocking");
        Options.AddArgument("--disable-notifications");

        //Options.AddArgument("--window-position=-32000,-32000");

        //options.AddArgument("--load-extension=P:\\Cloud\\SynologyDrive\\EF Recovery\\EFR.SkipTracer\\EFR.SkipTracer\\Resources\\nopecha-extension");
        //options.AddArgument("--load-extension=P:\\Cloud\\SynologyDrive\\EF Recovery\\EFR.SkipTracer\\EFR.SkipTracer\\Resources\\hlifkpholllijblknnmbfagnkjneagid\\0.0.13_0,P:\\Cloud\\SynologyDrive\\EF Recovery\\EFR.SkipTracer\\EFR.SkipTracer\\Resources\\nopecha-extension");

        //Driver = UndetectedChromeDriver.Create(options: Options, driverExecutablePath: new ChromeDriverInstaller().Auto().Result, headless: headless);
        Driver = UndetectedChromeDriver.Create(options: Options, driverExecutablePath: new ChromeDriverInstaller().Auto().Result, headless: Headless);
        IsInitialized = true;
    }

    internal async Task<SourceResult> GetWebResultsAsync(Uri uri, Sources.Source source)
    {
        if (!IsInitialized)
            Initialize();

        Driver!.GoToUrl(uri.AbsoluteUri);
        //Driver.ExecuteScript($"window.open('{uri}','_blank');");
        await Task.Delay(100);
        //Driver.SwitchTo().Window(Driver.WindowHandles[Driver.WindowHandles.Count - 1]);
        var HtmlContent = Driver.ExecuteScript("return document.documentElement.outerHTML;") as string;

        return new SourceResult() { Html = HtmlContent, URL = uri.ToString(), Type = source };
    }

    internal SourceResult GetWebResults(Uri uri, Sources.Source source)
    {
        if (!IsInitialized)
            Initialize();

        Driver!.GoToUrl(uri.AbsoluteUri);
        //Driver.ExecuteScript($"window.open('{uri}','_blank');");
        Thread.Sleep(100);
        //Driver.SwitchTo().Window(Driver.WindowHandles[Driver.WindowHandles.Count - 1]);
        var HtmlContent = Driver.ExecuteScript("return document.documentElement.outerHTML;") as string;

        return new SourceResult() { Html = HtmlContent, URL = uri.ToString(), Type = source };
    }

    public void Dispose()
    {
        Driver?.Quit();
        Driver?.Dispose();
    }
}