#pragma checksum "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\Category\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56bd9f4a382b8c3683f69a19c8de7c646d161c19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Category_Create), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Category/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56bd9f4a382b8c3683f69a19c8de7c646d161c19", @"/Areas/AdminPanel/Views/Category/Create.cshtml")]
    public class Areas_AdminPanel_Views_Category_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNet_Final.Areas.AdminPanel.Controllers.CategoryController>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\Category\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h4>Category</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""IsDeleted"" /> 
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""Deleted"" class=""control-label""></label>
                <input asp-for=""Deleted"" class=""form-control"" />
                <span asp-validation-for=""Deleted"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type");
            WriteLiteral("=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
            DefineSection("Script", async() => {
                WriteLiteral("\r\n\r\n<partial name=\"_ValidationPartial\">\r\n ");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNet_Final.Areas.AdminPanel.Controllers.CategoryController> Html { get; private set; }
    }
}
#pragma warning restore 1591