#pragma checksum "C:\Users\tcoll\Documents\GitHub\Beans-Website\Database_Design\Database_Design\Views\Shared\ProductSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "298ff425f227df15a9d1c84634ee3d28046d689c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ProductSummary), @"mvc.1.0.view", @"/Views/Shared/ProductSummary.cshtml")]
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
#line 2 "C:\Users\tcoll\Documents\GitHub\Beans-Website\Database_Design\Database_Design\Views\_ViewImports.cshtml"
using Database_Design.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tcoll\Documents\GitHub\Beans-Website\Database_Design\Database_Design\Views\_ViewImports.cshtml"
using Database_Design.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"298ff425f227df15a9d1c84634ee3d28046d689c", @"/Views/Shared/ProductSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9915a3e5cbbb51e988af98af4729de6629b24a7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ProductSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"d-flex justify-content-center\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 69, "\"", 104, 1);
#nullable restore
#line 3 "C:\Users\tcoll\Documents\GitHub\Beans-Website\Database_Design\Database_Design\Views\Shared\ProductSummary.cshtml"
WriteAttributeValue("", 75, Url.Content(@Model.ImageUrl), 75, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 105, "\"", 111, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" />\r\n</div>\r\n<div class=\"d-flex justify-content-center\">\r\n    <h4>");
#nullable restore
#line 6 "C:\Users\tcoll\Documents\GitHub\Beans-Website\Database_Design\Database_Design\Views\Shared\ProductSummary.cshtml"
   Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</div>\r\n<div class=\"d-flex justify-content-center\">\r\n    <p>");
#nullable restore
#line 9 "C:\Users\tcoll\Documents\GitHub\Beans-Website\Database_Design\Database_Design\Views\Shared\ProductSummary.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n<div class=\"d-flex justify-content-center\">\r\n    <h4>Price: ");
#nullable restore
#line 12 "C:\Users\tcoll\Documents\GitHub\Beans-Website\Database_Design\Database_Design\Views\Shared\ProductSummary.cshtml"
          Write(Model.ProductPrice.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n</div> ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591