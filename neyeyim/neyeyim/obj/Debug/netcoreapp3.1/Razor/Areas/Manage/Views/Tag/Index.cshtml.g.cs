#pragma checksum "C:\Users\User\Desktop\neyeyim\neyeyim\Areas\Manage\Views\Tag\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4aa5c5b52c2989743dd07d4cfe50e9c491eb911c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Tag_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Tag/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\neyeyim\neyeyim\Areas\Manage\Views\Tag\Index.cshtml"
using neyeyim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4aa5c5b52c2989743dd07d4cfe50e9c491eb911c", @"/Areas/Manage/Views/Tag/Index.cshtml")]
    public class Areas_Manage_Views_Tag_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Tag>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\neyeyim\neyeyim\Areas\Manage\Views\Tag\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";

    int i = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">

    <table class=""table table-bordered"">
        <thead>
            <tr class=""row"">
                <th class=""col-md-1"">#</th>
                <th class=""col-md-8"">Ad</th>

            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 23 "C:\Users\User\Desktop\neyeyim\neyeyim\Areas\Manage\Views\Tag\Index.cshtml"
             foreach (var item in Model)
            {
                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr class=\"row\">\r\n                    <td class=\"col-md-1\">");
#nullable restore
#line 27 "C:\Users\User\Desktop\neyeyim\neyeyim\Areas\Manage\Views\Tag\Index.cshtml"
                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"col-md-8\">");
#nullable restore
#line 28 "C:\Users\User\Desktop\neyeyim\neyeyim\Areas\Manage\Views\Tag\Index.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 30 "C:\Users\User\Desktop\neyeyim\neyeyim\Areas\Manage\Views\Tag\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </tbody>
    </table>

    <nav aria-label=""Page navigation example"">
        <ul class=""pagination"">
            <li class=""page-item""><a class=""page-link"" href=""#"">Previous</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
            <li class=""page-item""><a class=""page-link"" href=""#"">Next</a></li>
        </ul>
    </nav>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Tag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
