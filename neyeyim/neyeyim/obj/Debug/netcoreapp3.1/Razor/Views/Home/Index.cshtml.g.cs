#pragma checksum "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aff01a55dd9a7e59e797ee9cf02cdfce184dc7ad"
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
#line 1 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\_ViewImports.cshtml"
using neyeyim.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\_ViewImports.cshtml"
using neyeyim.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aff01a55dd9a7e59e797ee9cf02cdfce184dc7ad", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb900363127bca3854ca107bde25ff7c9a2b1e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("book-modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "place", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration: none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<!--Start of Slider Area-->\r\n<div id=\"carouselExampleControls\" class=\"carousel slide\" data-ride=\"carousel\">\r\n    <div class=\"carousel-inner\">\r\n        <div class=\"carousel-item active\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 225, "\"", 232, 0);
            EndWriteAttribute();
            WriteLiteral("><img class=\"d-block w-100\" src=\"uploads/img/1.jpg\" alt=\"First slide\"></a>\r\n        </div>\r\n        <div class=\"carousel-item\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 376, "\"", 383, 0);
            EndWriteAttribute();
            WriteLiteral("><img class=\"d-block w-100\" src=\"uploads/img/2.png\" alt=\"Second slide\"></a>\r\n        </div>\r\n        <div class=\"carousel-item\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 528, "\"", 535, 0);
            EndWriteAttribute();
            WriteLiteral(@"><img class=""d-block w-100"" src=""uploads/img/3.jpg"" alt=""Second slide""></a>
        </div>
    </div>
    <a class=""carousel-control-prev"" href=""#carouselExampleControls"" role=""button"" data-slide=""prev"">
        <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleControls"" role=""button"" data-slide=""next"">
        <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
        <span class=""sr-only"">Next</span>
    </a>
</div>
<!--End of Slider Area-->

<!--Start of Selected places Area-->
<section class=""cards animate__animated animate__fadeIn"">
    <div class=""container"">
        <div class=""row"">
            <h1 class=""cardcaption"" style=""padding: 20px;"">Seçilmiş məkanlar</h1>
");
#nullable restore
#line 32 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
             foreach (var item in Model.Places)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff01a55dd9a7e59e797ee9cf02cdfce184dc7ad6493", async() => {
                WriteLiteral("\r\n                        <div class=\"card\" style=\"width: 18rem; border-bottom: 5px solid #009de0;\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 1771, "\"", 1800, 2);
                WriteAttributeValue("", 1777, "uploads/img/", 1777, 12, true);
#nullable restore
#line 37 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
WriteAttributeValue("", 1789, item.Image, 1789, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <h class=\"restname\">");
#nullable restore
#line 39 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h>\r\n                                <p class=\"Category-name\">");
#nullable restore
#line 40 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                    Write(item.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <hr>\r\n                                <i class=\"fas fa-star\" style=\"color: #009de0;\"> ");
#nullable restore
#line 42 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                           Write(item.Rate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 47 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<!--End of Selected places Area-->
<!--Start of Most Popular places Area-->
<section class=""cards4 animate__animated animate__fadeIn"" style=""background-color: #F8F9FA;"">
    <div class=""container"">
        <div class=""row"">
            <h1 class=""cardcaption"" style=""padding: 20px;"">Ən populyar məkanlar</h1>
");
#nullable restore
#line 57 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
             foreach (var item in Model.Places)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff01a55dd9a7e59e797ee9cf02cdfce184dc7ad11732", async() => {
                WriteLiteral("\r\n                        <div class=\"card\" style=\"width: 18rem; border-bottom: 5px solid #009de0;\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 3047, "\"", 3076, 2);
                WriteAttributeValue("", 3053, "uploads/img/", 3053, 12, true);
#nullable restore
#line 62 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
WriteAttributeValue("", 3065, item.Image, 3065, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <h class=\"restname\">");
#nullable restore
#line 64 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h>\r\n                                <p class=\"Category-name\">");
#nullable restore
#line 65 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                    Write(item.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <hr>\r\n                                <i class=\"fas fa-star\" style=\"color: #009de0;\"> ");
#nullable restore
#line 67 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                           Write(item.Rate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 60 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 72 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </div>
    </div>
</section>
<!--End of Most Popular places Area-->
<!--Start of Last Ordered places Area-->
<section class=""cards4 animate__animated animate__fadeIn"">
    <div class=""container"">
        <div class=""row"">
            <h1 class=""cardcaption"" style=""padding: 20px;"">Ən son sifariş verdiyiniz məkanlar</h1>
");
#nullable restore
#line 82 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
             foreach (var item in Model.Places)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-4\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aff01a55dd9a7e59e797ee9cf02cdfce184dc7ad16953", async() => {
                WriteLiteral("\r\n                        <div class=\"card\" style=\"width: 18rem; border-bottom: 5px solid #009de0;\">\r\n                            <img");
                BeginWriteAttribute("src", " src=\"", 4306, "\"", 4335, 2);
                WriteAttributeValue("", 4312, "uploads/img/", 4312, 12, true);
#nullable restore
#line 87 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
WriteAttributeValue("", 4324, item.Image, 4324, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <h class=\"restname\">");
#nullable restore
#line 89 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h>\r\n                                <p class=\"Category-name\">");
#nullable restore
#line 90 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                    Write(item.Category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                <hr>\r\n                                <i class=\"fas fa-star\" style=\"color: #009de0;\"> ");
#nullable restore
#line 92 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                           Write(item.Rate);

#line default
#line hidden
#nullable disable
                WriteLiteral("</i>\r\n                            </div>\r\n                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 97 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n<!--End of Last Ordered places Area-->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
