#pragma checksum "G:\CSharp_test\Asp.Net\WebLeslieApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e1812622e1224370bc322c1872bb960648781c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 2 "G:\CSharp_test\Asp.Net\WebLeslieApp\Views\_ViewImports.cshtml"
using WebLeslieApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e1812622e1224370bc322c1872bb960648781c0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d068a0e5497887ee6ccc59335fbc515cb63ae3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "G:\CSharp_test\Asp.Net\WebLeslieApp\Views\Home\Index.cshtml"
   
    var book = ViewData["Book"] as BookModel;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<section class=\"jumbotron text-center\">\r\n    <div class=\"container\">\r\n        <h1>Welcome to Bookstore</h1>\r\n");
            WriteLiteral(@"        <p class=""lead text-muted"">
            Specifies that a Razor Page model property should be set
            with the current PageContext when creating the model
            instance. The property must have a public set method.
        </p>
        <p>
            <a href=""#"" class=""btn btn-primary my-2"">Search books</a>
        </p>
    </div>
</section>
<div class=""py-5 bg-light"">
    <div class=""container"">
        <h3>Top books</h3>
        <div class=""row"">
            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""></rect><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
                    <div class=""card-body"">
                       ");
            WriteLiteral(@" <p class=""card-text"">This section will be used to display the short description of book</p>
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View details</a>
                            </div>
                            <small class=""text-muted"">Author name</small>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""></rect><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
   ");
            WriteLiteral(@"                 <div class=""card-body"">
                        <p class=""card-text"">This section will be used to display the short description of book</p>
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View details</a>
                            </div>
                            <small class=""text-muted"">Author name</small>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""card mb-4 shadow-sm"">
                    <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c""></rect><text x=""");
            WriteLiteral(@"50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>
                    <div class=""card-body"">
                        <p class=""card-text"">This section will be used to display the short description of book</p>
                        <div class=""d-flex justify-content-between align-items-center"">
                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View details</a>
                            </div>
                            <small class=""text-muted"">Author name</small>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            //alert(\"document is ready\");\r\n        })\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
