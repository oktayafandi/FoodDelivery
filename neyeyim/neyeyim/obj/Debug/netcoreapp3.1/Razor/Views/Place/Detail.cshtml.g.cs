#pragma checksum "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aefaae87e05d946265e6a29d3d62ebc94a83d910"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aefaae87e05d946265e6a29d3d62ebc94a83d910", @"/Views/Place/Detail.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "aefaae87e05d946265e6a29d3d62ebc94a83d9104754", async() => {
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
                    <!--navbar area start-->
                    <nav>
                        <div class=""nav nav-tabs"" id=""nav-tab"" role=""tablist"">
                            <button class=""pagenav nav-link active"" id=""nav-home-tab"" data-bs-toggle=""tab""
                                    data-bs-target=""#nav-home"" type=""button"" role=""tab"" aria-controls=""nav-home""
                                    aria-selected=""true"" style=""color:#009de0;"">
                                Məlumat
                            </button>
                            <button class=""pagenav nav-link"" id=""nav-profile-tab"" data-bs-toggle=""tab""
                                    data-bs-target=""#nav-profile"" type=""button"" role=""tab"" aria-controls=""nav-profile""
                         ");
            WriteLiteral(@"           aria-selected=""false"" style=""color:#009de0;"">
                                Menyu
                            </button>
                            <button class=""pagenav nav-link"" id=""nav-contact-tab"" data-bs-toggle=""tab""
                                    data-bs-target=""#nav-contact"" type=""button"" role=""tab"" aria-controls=""nav-contact""
                                    aria-selected=""false"" style=""color:#009de0;"">
                                Dəyərləndir
                            </button>
                        </div>
                    </nav>
                    <!--navbar area end-->


                    <div class=""tab-content"" id=""nav-tabContent"" style=""padding: 30px;"">
                        <!--about area start-->
                        <div class=""tab-pane fade show active"" id=""nav-home"" role=""tabpanel"" aria-labelledby=""nav-home-tab"">
                            <div class=""col-lg-12 col-md-12 col-sm-12 col-xs-12"" style=""padding: 28px"">
                   ");
            WriteLiteral("             <div class=\"restaurants-detail\">\r\n                                    <h4>\"");
#nullable restore
#line 47 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                    Write(Model.Place.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" haqqında məlumatlar</h4>\r\n                                    <p class=\"restdetailtext\" style=\"padding-top: 20px\">Ünvanlar: ");
#nullable restore
#line 48 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                                             Write(Model.Place.Adress);

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
            WriteLiteral("</p>\r\n                                    <p class=\"restdetailtext\">Açılış-Bağlanış: ");
#nullable restore
#line 50 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                          Write(Model.Place.OpenTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 50 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                                                                    Write(Model.Place.CloseTime.ToString("HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"restdetailtext\">Servis haqqı: ");
#nullable restore
#line 51 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                       Write(Model.Place.Servisfee);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"restdetailtext\">Depozit: ");
#nullable restore
#line 52 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                  Write(Model.Place.Deposit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"restdetailtext\">Əlaqə nömrəsi: ");
#nullable restore
#line 53 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                        Write(Model.Place.ContactPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"restdetailtext\">\r\n                                        Tag:\r\n");
#nullable restore
#line 56 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                         foreach (var item in Model.Place.PlaceTags)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 58 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                             Write(item.Tag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 59 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <!--about area end-->\r\n\r\n                        <!--menu area start-->\r\n");
#nullable restore
#line 67 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                          
                            string i = "";
                        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""tab-pane fade"" id=""nav-profile"" role=""tabpanel"" aria-labelledby=""nav-profile-tab"">
                            <ul class=""nav nav-pills mb-3"" id=""pills-tab"" role=""tablist"" style=""justify-content: space-between; align-items: center;"">
");
#nullable restore
#line 72 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                 foreach (var item in Model.Place.PlaceMenus)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                     if (!i.Equals(item.MenuCategory.Name))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <li class=""nav-item section-3-button-1"" role=""presentation"">
                                            <button class=""pagenav nav-link section-3-button-1""
                                                    style=""padding: 3px 65px; border-radius: 22px !important;""");
            BeginWriteAttribute("id", "\r\n                                                    id=\"", 4790, "\"", 4893, 3);
#nullable restore
#line 79 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
WriteAttributeValue("", 4848, item.MenuCategory.Name, 4848, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4871, "-tab", 4871, 4, true);
            WriteAttributeValue(" ", 4875, "section3libutton1", 4876, 18, true);
            EndWriteAttribute();
            WriteLiteral(" data-bs-toggle=\"pill\"\r\n                                                    data-bs-target=\"#");
#nullable restore
#line 80 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                Write(item.MenuCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"button\" role=\"tab\"");
            BeginWriteAttribute("aria-controls", " aria-controls=\"", 5036, "\"", 5075, 1);
#nullable restore
#line 80 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
WriteAttributeValue("", 5052, item.MenuCategory.Name, 5052, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("aria-selected", "\r\n                                                    aria-selected=\"", 5076, "\"", 5241, 1);
#nullable restore
#line 81 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
WriteAttributeValue("", 5145, !Model.Place.PlaceMenus.First().MenuCategory.Name.Equals(item.MenuCategory.Name) ? false:true, 5145, 96, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"color:#009de0;\">\r\n                                                ");
#nullable restore
#line 82 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                           Write(item.MenuCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </button>\r\n                                        </li>\r\n");
#nullable restore
#line 85 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                     
                                    i = item.MenuCategory.Name;
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </ul>\r\n\r\n");
#nullable restore
#line 90 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                              
                                i = "";
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 93 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                             foreach (var item in Model.Place.PlaceMenus)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"tab-content\" id=\"pills-tabContent\">\r\n                                    <div");
            BeginWriteAttribute("class", " class=\"", 5950, "\"", 6074, 4);
            WriteAttributeValue("", 5958, "tab-pane", 5958, 8, true);
            WriteAttributeValue(" ", 5966, "fade", 5967, 5, true);
            WriteAttributeValue(" ", 5971, "show", 5972, 5, true);
#nullable restore
#line 96 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
WriteAttributeValue(" ", 5976, !Model.Place.PlaceMenus.First().MenuCategory.Name.Equals(item.MenuCategory.Name) ? "":"active", 5977, 97, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("id", " id=\"", 6075, "\"", 6103, 1);
#nullable restore
#line 96 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
WriteAttributeValue("", 6080, item.MenuCategory.Name, 6080, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"tabpanel\"");
            BeginWriteAttribute("aria-labelledby", " aria-labelledby=\"", 6120, "\"", 6165, 2);
#nullable restore
#line 96 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
WriteAttributeValue("", 6138, item.MenuCategory.Name, 6138, 23, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 6161, "-tab", 6161, 4, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                        <div class=\"col-lg-12 col-md-12 col-sm-12 col-xs-12\" style=\"padding-top: 20px\">\r\n                                            <div class=\"menu-detail\">\r\n                                                <h1");
            BeginWriteAttribute("class", " class=\"", 6412, "\"", 6478, 2);
            WriteAttributeValue("", 6420, "foodcap", 6420, 7, true);
#nullable restore
#line 99 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
WriteAttributeValue(" ", 6427, !i.Equals(item.MenuCategory.Name) ? "":"d-none", 6428, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    ");
#nullable restore
#line 100 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                               Write(item.MenuCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </h1>\r\n                                                <h4 class=\"foodtext\">\r\n                                                    ");
#nullable restore
#line 103 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                               Write(item.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 103 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                Write(item.FoodPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN<a");
            BeginWriteAttribute("href", " href=\"", 6775, "\"", 6782, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration: none"">
                                                        <i class=""plus fas fa-plus-square""></i>
                                                    </a>
                                                </h4>
                                                <p class=""fooddetailtext"">
                                                    ");
#nullable restore
#line 108 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                               Write(item.FoodContent);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </p>\r\n                                            </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 114 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                i = item.MenuCategory.Name;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <!--menu area end-->


                        <!--rate area start-->
                        <div class=""tab-pane fade"" id=""nav-contact"" role=""tabpanel"" aria-labelledby=""nav-contact-tab"">
                            <div id=""full-stars-example-two"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aefaae87e05d946265e6a29d3d62ebc94a83d91022611", async() => {
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
                BeginWriteAttribute("value", " value=\"", 9728, "\"", 9751, 1);
#nullable restore
#line 142 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
WriteAttributeValue("", 9736, Model.Place.Id, 9736, 15, false);

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
#line 150 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                 foreach (var comment in Model.Place.PlaceComments)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"userscomment col-lg-12 col-md-12 col-sm-12 col-xs-12\">\r\n                                        <h4 class=\"username\">");
#nullable restore
#line 153 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                        Write(comment.AppUser.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                                        <p class=\"usercmnt\" style=\"font-size: 22px;\">\r\n                                            ");
#nullable restore
#line 155 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                       Write(comment.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </p>\r\n                                        <p class=\"commentdatetime\">");
#nullable restore
#line 157 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                              Write(comment.CreatedAt.ToString("MMMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        <i class=\"fas fa-star\" style=\"color: #009de0;\">");
#nullable restore
#line 158 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                                                                  Write(comment.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                    </div>\r\n");
#nullable restore
#line 160 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Place\Detail.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n                        <!--rate area end-->\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>");
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
