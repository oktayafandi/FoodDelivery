#pragma checksum "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d769f0d784acda0cdace933e111fafd63f8489a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Setting_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Setting/Index.cshtml")]
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
#line 1 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
using neyeyim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d769f0d784acda0cdace933e111fafd63f8489a2", @"/Areas/Manage/Views/Setting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2113aaca0a7a4fdc73c3f6dbb45d466430fe8837", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Setting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Setting>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
  
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
                <th class=""col-md-1"">Əlaqə nöm</th>
                <th class=""col-md-1"">Məlumat nöm</th>
                <th class=""col-md-2"">Əlaqə mail</th>
                <th class=""col-md-2"">Məlumat mail</th>
                <th class=""col-md-2"">Ünvan</th>
                <th class=""col-md-2"">İş saatı</th>
                <th class=""col-md-1""></th>
            </tr>
        </thead>

        <tbody>
");
#nullable restore
#line 27 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
            foreach (var item in Model)
            {
                i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr class=\"row\">\r\n                <td class=\"col-md-1\">");
#nullable restore
#line 31 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
                                Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"col-md-1\">");
#nullable restore
#line 32 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
                                Write(item.ContactPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"col-md-1\">");
#nullable restore
#line 33 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
                                Write(item.InfoPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"col-md-2\">");
#nullable restore
#line 34 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
                                Write(item.ContactMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"col-md-2\">");
#nullable restore
#line 35 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
                                Write(item.InfoMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"col-md-2\">");
#nullable restore
#line 36 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
                                Write(item.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"col-md-2\">");
#nullable restore
#line 37 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
                                Write(item.WorkTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td class=\"col-md-1\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d769f0d784acda0cdace933e111fafd63f8489a27081", async() => {
                WriteLiteral("Redaktə et");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 42 "C:\Users\User\Desktop\FinalProject\neyeyim\neyeyim\Areas\Manage\Views\Setting\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Setting>> Html { get; private set; }
    }
}
#pragma warning restore 1591
