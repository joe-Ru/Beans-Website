#pragma checksum "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\Home\ReportContent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b6853dbe0952b1dca3d4b41006c85b7d61c7f6e"
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
#line 1 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\_ViewImports.cshtml"
using Database_Design;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\_ViewImports.cshtml"
using Database_Design.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b6853dbe0952b1dca3d4b41006c85b7d61c7f6e", @"/Views/Home/ReportContent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"535ce76210fc797f300a691bb349119502fd60cc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ReportContent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Database_Design.Models.ReportContent>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h4 style=\"color:purple\">\r\n</h4>\r\n\r\n<h3><b>Please input your information below, along with a statement of the tech problem.</b></h3>\r\n     \r\n");
#nullable restore
#line 7 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
 using (Html.BeginForm("Form2", "Home", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- TODO: Review the below cosmetics, make it less squished together -->\r\n    <table>\r\n        <tr>\r\n            <td>First Name: </td>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextBoxFor(m => m.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Last Name: </td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextBoxFor(m => m.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Phone Number: </td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextBoxFor(m => m.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Email: </td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextBoxFor(m => m.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Statement: </td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextAreaFor(m => m.Statement));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Artist Product: </td>\r\n            <td>");
#nullable restore
#line 33 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextAreaFor(m => m.ArtistProduct));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Artist Profile Page: </td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
           Write(Html.TextAreaFor(m => m.ArtistLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\"><input type=\"submit\" value=\"Submit Form\" /></td>\r\n        </tr>\r\n        <!-- What should this button do? Email one of us? or automate it? -->\r\n    </table>\r\n");
#nullable restore
#line 44 "C:\Users\Gabriel\Desktop\Beans Website\Beans-Website\Database_Design\Database_Design\Views\Home\ReportContent.cshtml"
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
