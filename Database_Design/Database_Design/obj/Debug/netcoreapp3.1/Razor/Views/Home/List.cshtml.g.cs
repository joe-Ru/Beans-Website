#pragma checksum "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d6dc59d706015b267cbe4accc464c0173a21535"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
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
#line 1 "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\_ViewImports.cshtml"
using Database_Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\_ViewImports.cshtml"
using Database_Design.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6dc59d706015b267cbe4accc464c0173a21535", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ac8ebc9feff2606e2f3aaf1161cd2db786f45b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AccountModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n");
#nullable restore
#line 3 "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\Home\List.cshtml"
     foreach (Database_Design.Models.AccountModel r in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 6 "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\Home\List.cshtml"
           Write(r.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 7 "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\Home\List.cshtml"
           Write(r.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 8 "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\Home\List.cshtml"
           Write(r.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 9 "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\Home\List.cshtml"
           Write(r.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 10 "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\Home\List.cshtml"
           Write(r.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 11 "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\Home\List.cshtml"
           Write(r.Password);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <br />\r\n        </tr>\r\n");
#nullable restore
#line 14 "C:\Users\Jack\Downloads\Beans-Website-master\Beans-Website-master\Database_Design\Database_Design\Views\Home\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AccountModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
