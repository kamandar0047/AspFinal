#pragma checksum "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a2661503cf5f460c5feef8e0ab1bab7f9aaf60c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_User_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a2661503cf5f460c5feef8e0ab1bab7f9aaf60c", @"/Areas/AdminPanel/Views/User/Index.cshtml")]
    public class Areas_AdminPanel_Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AspNet_Final.Areas.AdminPanel.ViewModels.UserVM>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\User\Index.cshtml"
   
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""card-body"">
    <h5 class=""card-title"">Table dark</h5>
    <table class=""mb-0 table table-dark"">
        <thead>
            <tr>

                <th>Username</th>
                <th>Email</th>
                <th>Role</th>
            </tr>
        </thead>
        <tbody>
          

            }
");
#nullable restore
#line 23 "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\User\Index.cshtml"
             foreach (var user in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>   <td>");
#nullable restore
#line 25 "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\User\Index.cshtml"
                      Write(user.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </td> <td>");
#nullable restore
#line 25 "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\User\Index.cshtml"
                                                Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td> <td>");
#nullable restore
#line 25 "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\User\Index.cshtml"
                                                                      Write(user.Role);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\User\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AspNet_Final.Areas.AdminPanel.ViewModels.UserVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
