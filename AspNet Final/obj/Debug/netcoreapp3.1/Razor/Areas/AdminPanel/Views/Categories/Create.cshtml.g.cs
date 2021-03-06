#pragma checksum "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\Categories\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87e09b8743af4e24225ca38322463727fd8f44c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Categories_Create), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Categories/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87e09b8743af4e24225ca38322463727fd8f44c6", @"/Areas/AdminPanel/Views/Categories/Create.cshtml")]
    public class Areas_AdminPanel_Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNet_Final.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\Categories\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Create</h2>

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
            <div class=""form-group"">
                <div class=""checkbox"">
                    <label>
                        <input asp-for=""Deleted"" /> ");
#nullable restore
#line 23 "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\Categories\Create.cshtml"
                                               Write(Html.DisplayNameFor(model => model.Deleted));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </label>
                </div>
            </div>
            <div class=""form-group"">
                <label asp-for=""IsDeleted"" class=""control-label""></label>
                <input asp-for=""IsDeleted"" class=""form-control"" />
                <span asp-validation-for=""IsDeleted"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AspNet_Final.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
