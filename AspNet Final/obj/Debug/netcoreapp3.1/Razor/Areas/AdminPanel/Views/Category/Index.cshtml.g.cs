#pragma checksum "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb1e4fad622639d1f13c5f3a53e12157272e8984"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_AdminPanel_Views_Category_Index), @"mvc.1.0.view", @"/Areas/AdminPanel/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb1e4fad622639d1f13c5f3a53e12157272e8984", @"/Areas/AdminPanel/Views/Category/Index.cshtml")]
    public class Areas_AdminPanel_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AspNet_Final.Areas.AdminPanel.Controllers.CategoryController>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ideapad\source\repos\AspNet Final\AspNet Final\Areas\AdminPanel\Views\Category\Index.cshtml"
      
        ViewData["Title"] = "Index";
        //int count = 1;
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""row"">
        <div class=""col-12 my-3"">
            <a asp-action=""Create"" class=""btn btn-success"">Create</a>
        </div>
        <div class=""col-lg-12 ion-grid-margin stretch-card"">
            <div class=""card"">
                <div class=""card-body"">
                    <h5 class=""card-title"">Categories</h5>
                    <table class=""mb-0 table table-dark"">
                        <thead>
                            <tr>
                                <th>#</th>
                                <th>Category name</th>
                                <th>IsDeleted</th>
                                <th>Setting</th>
                            </tr>
                        </thead>
                        <tbody>
");
            WriteLiteral("\r\n                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n   ");
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
