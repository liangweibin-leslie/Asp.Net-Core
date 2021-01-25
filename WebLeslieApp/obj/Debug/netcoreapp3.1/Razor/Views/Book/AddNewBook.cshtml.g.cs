#pragma checksum "G:\CSharp_test\Asp.Net\WebLeslieApp\Views\Book\AddNewBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1978928126c4b1932b5f35415dfe51046ccd6579"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_AddNewBook), @"mvc.1.0.view", @"/Views/Book/AddNewBook.cshtml")]
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
#line 1 "G:\CSharp_test\Asp.Net\WebLeslieApp\Views\_ViewImports.cshtml"
using WebLeslieApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1978928126c4b1932b5f35415dfe51046ccd6579", @"/Views/Book/AddNewBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89d5b9fe635218c2bb2b8b48d17729e03d54a1e5", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_AddNewBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\CSharp_test\Asp.Net\WebLeslieApp\Views\Book\AddNewBook.cshtml"
  
    ViewData["Title"] = "AddNewBook";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h3 class=""display-4"">Add New Book</h3>
    <form method=""post"">
        <div class=""form-group"">
            <label asp-for=""Title"">Title</label>
            <input type=""text"" asp-for=""Title"" class=""form-control""/>
        </div>

        <div class=""form-group"">
            <label asp-for=""Author"">Author</label>
            <input type=""text"" asp-for=""Author"" class=""form-control""/>
        </div>

        <div class=""form-group"">
            <label asp-for=""Description"">Description</label>
            <input type=""text"" asp-for=""Description"" class=""form-control""/>
        </div>

        <div class=""form-group"">
            <input type=""submit"" value=""Add book"" class=""btn-primary""/>
        </div>
    </form>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
