#pragma checksum "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/FoodListByCategory/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17cff1f4e15abf7508c42f99720760ddaca6ae51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_FoodListByCategory_Default), @"mvc.1.0.view", @"/Views/Default/Components/FoodListByCategory/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17cff1f4e15abf7508c42f99720760ddaca6ae51", @"/Views/Default/Components/FoodListByCategory/Default.cshtml")]
    public class Views_Default_Components_FoodListByCategory_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/FoodListByCategory/Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\" style=\"width: 18rem;\">\n\n    <img");
            BeginWriteAttribute("src", " src=\"", 130, "\"", 136, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\n    <div class=\"card-body\">\n        <h5 class=\"card-title\">");
#nullable restore
#line 8 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/FoodListByCategory/Default.cshtml"
                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <p class=\"card-text\">");
#nullable restore
#line 9 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/FoodListByCategory/Default.cshtml"
                        Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <p class=\"card-text\">");
#nullable restore
#line 10 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/FoodListByCategory/Default.cshtml"
                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (₺)</p>\n        <p class=\"card-text\">");
#nullable restore
#line 11 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/FoodListByCategory/Default.cshtml"
                        Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n\n</div>\n");
#nullable restore
#line 15 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Default/Components/FoodListByCategory/Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
