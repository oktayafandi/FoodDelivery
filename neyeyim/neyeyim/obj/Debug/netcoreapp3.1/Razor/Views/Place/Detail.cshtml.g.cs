#pragma checksum "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0066c048367e71a7b9ec23e34f92f7185483545"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Place_Detail), @"mvc.1.0.view", @"/Views/Place/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0066c048367e71a7b9ec23e34f92f7185483545", @"/Views/Place/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb900363127bca3854ca107bde25ff7c9a2b1e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Place_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlaceDetailViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addcomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"container animate__animated animate__fadeInLeft\">\r\n            <div class=\"row\">\r\n                <div class=\"restcaption col-lg-12 col-md-12 col-sm-12 col-xs-12 d-flex\" style=\"padding: 30px;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f0066c048367e71a7b9ec23e34f92f71854835454754", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 320, "~/uploads/img/", 320, 14, true);
#nullable restore
#line 10 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
AddHtmlAttributeValue("", 334, Model.Place.Logo, 334, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <h1>");
#nullable restore
#line 11 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                   Write(Model.Place.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                </div>
            </div>
        </div>

        <div class=""container animate__animated animate__fadeIn"">
            <div class=""row"">
                <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"">
                    <nav>
                        <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                            <button class=""pagenav nav-link active"" id=""nav-home-tab"" data-bs-toggle=""tab""
                                    data-bs-target=""#nav-home"" type=""button"" role=""tab"" aria-controls=""nav-home""
                                    aria-selected=""true"" style=""color:#009de0;"">
                                Məlumat
                            </button>
                            <button class=""pagenav nav-link"" id=""nav-profile-tab"" data-bs-toggle=""tab""
                                    data-bs-target=""#nav-profile"" type=""button"" role=""tab"" aria-controls=""nav-profile""
                                    aria-selected=""false"" style=""color:");
            WriteLiteral(@"#009de0;"">
                                Menyu
                            </button>
                            <button class=""pagenav nav-link"" id=""nav-contact-tab"" data-bs-toggle=""tab""
                                    data-bs-target=""#nav-contact"" type=""button"" role=""tab"" aria-controls=""nav-contact""
                                    aria-selected=""false"" style=""color:#009de0;"">
                                Dəyərləndir
                            </button>
                        </div>
                    </nav>
                    <div class=""tab-content"" id=""nav-tabContent"" style=""padding: 30px;"">

                        <div class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel""
                             aria-labelledby=""nav-home-tab"">
                            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"" style=""padding: 28px"">
                                <div class=""restaurants-detail"">
                                    <h4>""");
#nullable restore
#line 44 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                    Write(Model.Place.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" haqqında məlumatlar</h4>\r\n                                    <p class=\"restdetailtext\" style=\"padding-top: 20px\">\r\n                                        Ünvanlar: ");
#nullable restore
#line 46 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                             Write(Model.Place.Adress);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </p>\r\n                                    <p class=\"restdetailtext\">Açılış-Bağlanış: ");
#nullable restore
#line 48 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                          Write(Model.Place.OpenCloseTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"restdetailtext\">Status: ");
#nullable restore
#line 49 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                 Write(Model.Place.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"restdetailtext\">Servis haqqı: ");
#nullable restore
#line 50 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                       Write(Model.Place.Servisfee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"restdetailtext\">Depozit: ");
#nullable restore
#line 51 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                  Write(Model.Place.Deposit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"restdetailtext\">Əlaqə nömrəsi: ");
#nullable restore
#line 52 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                        Write(Model.Place.ContactPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"restdetailtext\">Tag: \r\n");
#nullable restore
#line 54 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                    foreach (var item in Model.Place.PlaceTags)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                       <span>");
#nullable restore
#line 56 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                        Write(item.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 57 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    </p>
                                </div>
                            </div>
                        </div>


                        <div class=""tab-pane fade"" id=""nav-profile"" role=""tabpanel"" aria-labelledby=""nav-profile-tab"">
");
#nullable restore
#line 65 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                            foreach (var item in Model.Place.PlaceMenus)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"" style=""justify-content: space-between; align-items: center;"">
                                    <li class=""nav-item section-3-button-1"" role=""presentation"">
                                        <button class=""pagenav nav-link section-3-button-1""
                                                style=""padding: 3px 65px; border-radius: 22px !important;""
                                                id=""pills-home-tab section3libutton1"" data-bs-toggle=""pill""
                                                data-bs-target=""#pills-home"" type=""button"" role=""tab"" aria-controls=""pills-home""
                                                aria-selected=""false"" style=""color:#009de0;"">
                                            ");
#nullable restore
#line 74 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                       Write(item.MenuCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </button>\r\n                                    </li>\r\n                                </ul>\r\n");
            WriteLiteral(@"                                <div class=""tab-content"" id=""pills-tabContent"">
                                    <div class=""tab-pane fade show active"" id=""pills-home"" role=""tabpanel"" aria-labelledby=""pills-home-tab"">
                                        <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"" style=""padding-top: 20px"">
                                            <div class=""menu-detail"">
                                                <h1 class=""foodcap"">Burgerlər</h1>

                                                <h4 class=""foodtext"">
                                                    ");
#nullable restore
#line 86 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                               Write(item.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 86 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                Write(item.FoodPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN<a");
            BeginWriteAttribute("href", " href=\"", 5521, "\"", 5528, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                                        <i class=""plus fas fa-plus-square""></i>
                                                    </a>
                                                </h4>
                                                <p class=""fooddetailtext"">
                                                    ");
#nullable restore
#line 91 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                               Write(item.FoodContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 97 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n\r\n                        <div class=\"tab-pane fade\" id=\"nav-contact\" role=\"tabpanel\" aria-labelledby=\"nav-contact-tab\">\r\n                            <div id=\"full-stars-example-two\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0066c048367e71a7b9ec23e34f92f718548354516576", async() => {
                WriteLiteral(@"
                                    <div class=""rating-group"">
                                        <input disabled checked class=""rating__input rating__input--none"" name=""Rate"" id=""rating3-none"" value=""0"" type=""radio"">

                                        <label aria-label=""1 star"" class=""rating__label"" for=""rating3-1""> <i class=""rating__icon rating__icon--star fa fa-star""></i> </label>
                                        <input class=""rating__input"" name=""Rate"" id=""rating3-1"" value=""1"" type=""radio"">

                                        <label aria-label=""2 stars"" class=""rating__label"" for=""rating3-2""> <i class=""rating__icon rating__icon--star fa fa-star""></i> </label>
                                        <input class=""rating__input"" name=""Rate"" id=""rating3-2"" value=""2"" type=""radio"">

                                        <label aria-label=""3 stars"" class=""rating__label"" for=""rating3-3""> <i class=""rating__icon rating__icon--star fa fa-star""></i> </label>
                      ");
                WriteLiteral(@"                  <input class=""rating__input"" name=""Rate"" id=""rating3-3"" value=""3"" type=""radio"">

                                        <label aria-label=""4 stars"" class=""rating__label"" for=""rating3-4""> <i class=""rating__icon rating__icon--star fa fa-star""></i> </label>
                                        <input class=""rating__input"" name=""Rate"" id=""rating3-4"" value=""4"" type=""radio"">

                                        <label aria-label=""5 stars"" class=""rating__label"" for=""rating3-5""> <i class=""rating__icon rating__icon--star fa fa-star""></i> </label>
                                        <input class=""rating__input"" name=""Rate"" id=""rating3-5"" value=""5"" type=""radio"">
                                    </div>
                                    <input type=""hidden"" name=""PlaceId""");
                BeginWriteAttribute("value", " value=\"", 8287, "\"", 8310, 1);
#nullable restore
#line 121 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
WriteAttributeValue("", 8295, Model.Place.Id, 8295, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                    <div class=""mb-3"">
                                        <label for=""exampleFormControlTextarea1"" class=""form-label""></label>
                                        <textarea name=""Text"" class=""form-control"" id=""exampleFormControlTextarea1"" rows=""3""></textarea>
                                        <button type=""submit"" class=""cmntbtn btn"">Paylaş</button>
                                    </div>
                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                <hr>\r\n");
#nullable restore
#line 129 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                foreach (var comment in Model.Place.PlaceComments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"userscomment col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n                                        <h4 class=\"username\">");
#nullable restore
#line 132 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                        Write(comment.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <p class=\"usercmnt\">\r\n                                            ");
#nullable restore
#line 134 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                       Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <p>");
#nullable restore
#line 136 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                      Write(comment.CreatedAt.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <i class=\"fas fa-star\" style=\"color: #009de0;\">");
#nullable restore
#line 137 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                                  Write(comment.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                    </div>\r\n");
#nullable restore
#line 139 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlaceDetailViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
