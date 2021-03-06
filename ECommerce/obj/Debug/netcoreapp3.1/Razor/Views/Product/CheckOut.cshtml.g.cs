#pragma checksum "C:\Workspace\ECommerce\ECommerce\Views\Product\CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1d5b23777f30a5a3c80eb81b151e52f68ba404c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_CheckOut), @"mvc.1.0.view", @"/Views/Product/CheckOut.cshtml")]
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
#line 1 "C:\Workspace\ECommerce\ECommerce\Views\_ViewImports.cshtml"
using ECommerce;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\ECommerce\ECommerce\Views\_ViewImports.cshtml"
using ECommerce.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1d5b23777f30a5a3c80eb81b151e52f68ba404c", @"/Views/Product/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec470632cb3b1b75499bc0cdcc8d1831e35eecad", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Sepet>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Workspace\ECommerce\ECommerce\Views\Product\CheckOut.cshtml"
  
    ViewData["Title"] = "CheckOut";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>CheckOut</h1>

<div class=""container"">
    <div class=""page-header clearfix detailHeading"">
        <h2 class=""text-muted"">CheckOut Detail</h2>
    </div>
</div>

<div class=""container"">
    <div class=""page-header clearfix detailHeading"">
        <div id=""productsTable"">
            <table class=""table table-condensed"" id=""productIndexTable"">
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>Quantity</th>
                        <th>Sub Total</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 27 "C:\Workspace\ECommerce\ECommerce\Views\Product\CheckOut.cshtml"
                     foreach (var product in Model.sepetDetayList)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"productRow\">\r\n                            <td");
            BeginWriteAttribute("class", " class=\"", 851, "\"", 859, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 30 "C:\Workspace\ECommerce\ECommerce\Views\Product\CheckOut.cshtml"
                                    Write(product.product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td");
            BeginWriteAttribute("class", " class=\"", 921, "\"", 929, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 31 "C:\Workspace\ECommerce\ECommerce\Views\Product\CheckOut.cshtml"
                                    Write(product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td");
            BeginWriteAttribute("class", " class=\"", 986, "\"", 994, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Workspace\ECommerce\ECommerce\Views\Product\CheckOut.cshtml"
                                    Write(product.subTotal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 34 "C:\Workspace\ECommerce\ECommerce\Views\Product\CheckOut.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    
                </tbody>
                
            </table>
        </div>
    </div>
</div>

<div class=""container"">
    <div class=""page-header clearfix detailHeading"">
        <table class=""table table-condensed"" id=""productSummaryTable"">
            <tbody>
                <tr>Total: ");
#nullable restore
#line 48 "C:\Workspace\ECommerce\ECommerce\Views\Product\CheckOut.cshtml"
                      Write(Model.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</tr>\r\n            </tbody>\r\n        </table>\r\n</div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sepet> Html { get; private set; }
    }
}
#pragma warning restore 1591
