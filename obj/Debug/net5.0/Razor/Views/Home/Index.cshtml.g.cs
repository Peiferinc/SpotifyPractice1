#pragma checksum "C:\Users\Justin Peifer\source\repos\SpotifyPractice1\SpotifyPractice1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3379722c47fe9189521edc04d5b5e72773981d5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
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
#line 2 "C:\Users\Justin Peifer\source\repos\SpotifyPractice1\SpotifyPractice1\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3379722c47fe9189521edc04d5b5e72773981d5c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dd659e56250d65bc340328495b745a24b85322", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Models.Release>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Justin Peifer\source\repos\SpotifyPractice1\SpotifyPractice1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Newest Releases</h1>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\Justin Peifer\source\repos\SpotifyPractice1\SpotifyPractice1\Views\Home\Index.cshtml"
         foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card m-1\" style=\"width:350px;\">\r\n                    <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\Justin Peifer\source\repos\SpotifyPractice1\SpotifyPractice1\Views\Home\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.Artists));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 13 "C:\Users\Justin Peifer\source\repos\SpotifyPractice1\SpotifyPractice1\Views\Home\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                    <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Justin Peifer\source\repos\SpotifyPractice1\SpotifyPractice1\Views\Home\Index.cshtml"
                                    Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 608, "\"", 658, 1);
#nullable restore
#line 15 "C:\Users\Justin Peifer\source\repos\SpotifyPractice1\SpotifyPractice1\Views\Home\Index.cshtml"
WriteAttributeValue("", 614, Html.DisplayFor(modelItem => item.ImageUrl), 614, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"300\" alt=\"Release Picture\" />\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 733, "\"", 780, 1);
#nullable restore
#line 16 "C:\Users\Justin Peifer\source\repos\SpotifyPractice1\SpotifyPractice1\Views\Home\Index.cshtml"
WriteAttributeValue("", 740, Html.DisplayFor(modelItem => item.Link), 740, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Listen</a>\r\n                </div>\r\n");
#nullable restore
#line 18 "C:\Users\Justin Peifer\source\repos\SpotifyPractice1\SpotifyPractice1\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Models.Release>> Html { get; private set; }
    }
}
#pragma warning restore 1591
