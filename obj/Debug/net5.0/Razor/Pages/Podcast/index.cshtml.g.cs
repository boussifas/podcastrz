#pragma checksum "/home/boussifas/Documents/others/Podcast_rz/Podcastrz/Pages/Podcast/index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "114f64162423288acfaf5a6e811aec10c9cd1a21"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Podcastrz.Pages.Podcast.Pages_Podcast_index), @"mvc.1.0.razor-page", @"/Pages/Podcast/index.cshtml")]
namespace Podcastrz.Pages.Podcast
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/home/boussifas/Documents/others/Podcast_rz/Podcastrz/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/boussifas/Documents/others/Podcast_rz/Podcastrz/Pages/_ViewImports.cshtml"
using Podcastrz;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/boussifas/Documents/others/Podcast_rz/Podcastrz/Pages/_ViewImports.cshtml"
using Podcastrz.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"114f64162423288acfaf5a6e811aec10c9cd1a21", @"/Pages/Podcast/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14e5f080cd58a2afa29af8d1469d3c1bbbd11f38", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Podcast_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "/home/boussifas/Documents/others/Podcast_rz/Podcastrz/Pages/Podcast/index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome To Podcaster </h1>\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Podcast_index> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Podcast_index> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Podcast_index>)PageContext?.ViewData;
        public Pages_Podcast_index Model => ViewData.Model;
    }
}
#pragma warning restore 1591
