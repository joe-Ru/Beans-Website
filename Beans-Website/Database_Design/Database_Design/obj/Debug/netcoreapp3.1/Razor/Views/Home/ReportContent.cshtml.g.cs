#pragma checksum "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\Home\ReportContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef021a6508fcbcb8a7cda3a5d89b02e673aaed87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ReportContent), @"mvc.1.0.view", @"/Views/Home/ReportContent.cshtml")]
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
#line 2 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\_ViewImports.cshtml"
using Database_Design.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\_ViewImports.cshtml"
using Database_Design.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\_ViewImports.cshtml"
using Database_Design.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef021a6508fcbcb8a7cda3a5d89b02e673aaed87", @"/Views/Home/ReportContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46fa5e21deae1ae6389978b723d49e1d0248302d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ReportContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Database_Design.Models.ReportContent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4 style=\"color:purple\">\n</h4>\n\n<h3><b>Please input your information below, along with a statement of the problem with a product uploaded</b></h3>\n     \n");
#nullable restore
#line 7 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
 using (Html.BeginForm("Form2", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- TODO: Review the below cosmetics, make it less squished together -->\n    <table>\n        <tr>\n            <td>First Name: </td>\n            <td>");
#nullable restore
#line 13 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Last Name: </td>\n            <td>");
#nullable restore
#line 17 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Phone Number: </td>\n            <td>");
#nullable restore
#line 21 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextBoxFor(m => m.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Email: </td>\n            <td>");
#nullable restore
#line 25 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Statement: </td>\n            <td>");
#nullable restore
#line 29 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextAreaFor(m => m.Statement));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Artist Product: </td>\n            <td>");
#nullable restore
#line 33 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextAreaFor(m => m.ArtistProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td>Artist Profile Page: </td>\n            <td>");
#nullable restore
#line 37 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextAreaFor(m => m.ArtistLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n        <tr>\n            <td colspan=\"2\"><input type=\"submit\" value=\"Submit Form\" /></td>\n        </tr>\n        <!-- What should this button do? Email one of us? or automate it? -->\n    </table>\n");
#nullable restore
#line 44 "C:\Users\n01394107\Downloads\Beans-Website-Trey-2- (1)\Beans-Website-Trey-2-\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Database_Design.Models.ReportContent> Html { get; private set; }
    }
}
#pragma warning restore 1591