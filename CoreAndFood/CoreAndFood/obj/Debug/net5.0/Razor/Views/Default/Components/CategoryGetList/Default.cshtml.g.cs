#pragma checksum "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/CategoryGetList/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02ca246ecfbd784518c22850dbd26f2955ca4f39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_CategoryGetList_Default), @"mvc.1.0.view", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02ca246ecfbd784518c22850dbd26f2955ca4f39", @"/Views/Default/Components/CategoryGetList/Default.cshtml")]
    public class Views_Default_Components_CategoryGetList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<ul class=\"list-group\">\n    <li class=\"list-group-item active\" aria-current=\"true\">Kategoriler</li>\n");
#nullable restore
#line 4 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/CategoryGetList/Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\"><a");
            BeginWriteAttribute("href", " href=\"", 230, "\"", 270, 2);
            WriteAttributeValue("", 237, "/Default/CategoryGetList/", 237, 25, true);
#nullable restore
#line 6 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/CategoryGetList/Default.cshtml"
WriteAttributeValue("", 262, item.Id, 262, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 6 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/CategoryGetList/Default.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\n");
#nullable restore
#line 7 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/CategoryGetList/Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreAndFood.Data.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591