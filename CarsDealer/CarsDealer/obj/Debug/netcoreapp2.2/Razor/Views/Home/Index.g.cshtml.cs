#pragma checksum "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a32ebec4ff197675bdf20061b5dc4124aa3c7c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\_ViewImports.cshtml"
using CarsDealer;

#line default
#line hidden
#line 2 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\_ViewImports.cshtml"
using CarsDealer.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a32ebec4ff197675bdf20061b5dc4124aa3c7c6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb2ab060c43e8ec0dc600d58e1963d9f68c198bb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "CARS";

#line default
#line hidden
            BeginContext(61, 85, true);
            WriteLiteral("\r\n<h2>Cars</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>");
            EndContext();
            BeginContext(147, 41, false);
#line 12 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.Single().Make));

#line default
#line hidden
            EndContext();
            BeginContext(188, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(212, 42, false);
#line 13 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.Single().Model));

#line default
#line hidden
            EndContext();
            BeginContext(254, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(278, 41, false);
#line 14 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.Single().Year));

#line default
#line hidden
            EndContext();
            BeginContext(319, 23, true);
            WriteLiteral("</th>\r\n            <th>");
            EndContext();
            BeginContext(343, 42, false);
#line 15 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(x => x.Single().Price));

#line default
#line hidden
            EndContext();
            BeginContext(385, 49, true);
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 19 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
           
            foreach (var car in Model)
            {

#line default
#line hidden
            BeginContext(502, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(549, 8, false);
#line 23 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
                   Write(car.Make);

#line default
#line hidden
            EndContext();
            BeginContext(557, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(589, 9, false);
#line 24 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
                   Write(car.Model);

#line default
#line hidden
            EndContext();
            BeginContext(598, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(630, 8, false);
#line 25 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
                   Write(car.Year);

#line default
#line hidden
            EndContext();
            BeginContext(638, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(670, 9, false);
#line 26 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
                   Write(car.Price);

#line default
#line hidden
            EndContext();
            BeginContext(679, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 28 "Z:\OneDrive - RETEA Systemy Informatyczne\DevProjects\CarsDealer\CarsDealer\Views\Home\Index.cshtml"
            }
        

#line default
#line hidden
            BeginContext(735, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
