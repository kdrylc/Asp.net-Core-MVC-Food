#pragma checksum "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84812500c2d77ef106e01eedf54a47475d259068"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_Index), @"mvc.1.0.view", @"/Views/Food/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84812500c2d77ef106e01eedf54a47475d259068", @"/Views/Food/Index.cshtml")]
    public class Views_Food_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreAndFood.Data.Models.Food>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Id
                </th>
                <th>
                    Name
                </th>
                <th>
                    Description
                </th>
                <th>
                    Stock
                </th>
                <th>
                    Price(₺)
                </th>
                <th>
                    Category
                </th>
                <th>Update</th>
                <th>Delete</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 34 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 37 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 38 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 39 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 40 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
               Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 41 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (₺)</td>\n                <td>");
#nullable restore
#line 42 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
               Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1100, "\"", 1129, 2);
            WriteAttributeValue("", 1107, "/Food/FoodGet/", 1107, 14, true);
#nullable restore
#line 43 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
WriteAttributeValue("", 1121, item.Id, 1121, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Update</a></td>\n                <td><a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1192, "\"", 1220, 2);
            WriteAttributeValue("", 1199, "/Food/Delete/", 1199, 13, true);
#nullable restore
#line 44 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
WriteAttributeValue("", 1212, item.Id, 1212, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\n            </tr>\n");
#nullable restore
#line 46 "/Users/kadiryolcu/Projects/CoreAndFood/CoreAndFood/Views/Food/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n    <a href=\"/Food/FAdd\" class=\"btn btn-success\">New Food</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591