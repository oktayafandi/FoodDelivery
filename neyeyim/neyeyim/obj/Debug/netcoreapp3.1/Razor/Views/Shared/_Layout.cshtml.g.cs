#pragma checksum "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5916408b2124776df05ff8291ff3ba099fb29ee3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5916408b2124776df05ff8291ff3ba099fb29ee3", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06dbfdd97164da5b3c8c4c8243fbd02cae7bdd71", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5916408b2124776df05ff8291ff3ba099fb29ee33227", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <title>Document</title>
    <link rel=""stylesheet"" href=""css/home.css"" />
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"" />
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin />
    <link href=""https://fonts.googleapis.com/css2?family=Oswald:wght@500&display=swap"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/css/bootstrap.min.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/ionicons/2.0.1/css/ionicons.min.css"" />
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"" />
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"" />
 ");
                WriteLiteral(@"   <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin />
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Teko:wght@500&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css2?family=Big+Shoulders+Stencil+Display:wght@100&display=swap"" rel=""stylesheet"" />
    <link rel=""stylesheet"" href=""https://pro.fontawesome.com/releases/v5.10.0/css/all.css"" integrity=""sha384-AYmEC3Yw5cVb3ZcuHtOA93w35dYTsvhLPVnYs9eStHfGJvOvKxVfELGroGkvsg+p"" crossorigin=""anonymous"" />
    <link rel=""stylesheet"" type=""text/css"" href=""//cdn.jsdelivr.net/npm/slick-carousel@1.8.1/slick/slick.css"" />
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.1.1/animate.min.css"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5916408b2124776df05ff8291ff3ba099fb29ee36215", async() => {
                WriteLiteral(@"
    <!--Start of Tawk.to Script-->
    <script type=""text/javascript"">
        var Tawk_API = Tawk_API || {}, Tawk_LoadStart = new Date();
        (function () {
            var s1 = document.createElement(""script""), s0 = document.getElementsByTagName(""script"")[0];
            s1.async = true;
            s1.src = 'https://embed.tawk.to/60f2e76e649e0a0a5cccacc6/1faqdg1vd';
            s1.charset = 'UTF-8';
            s1.setAttribute('crossorigin', '*');
            s0.parentNode.insertBefore(s1, s0);
        })();
    </script>
    <!--End of Tawk.to Script-->

    <!--Start of Top and Nav Bars-->
    <header>

        <div class=""topbar"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""topbar-right text-md-right animate__animated animate__fadeInDown"">
                            <a href=""login.html"" style=""color: #707174; margin-right: 13px; text-decoration: none;"">
                ");
                WriteLiteral(@"                <i class=""fas fa-sign-in-alt"">
                                    Daxil ol
                                </i>
                            </a>
                            <a href=""register.html"" style=""color: #707174; margin-right: 13px; text-decoration: none;"">
                                <i class=""fas fa-user-friends""> Qeydiyyat</i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
        </div>

        <nav class=""navbar navbar-expand-lg navbar-light"">
            <div class=""container"" style=""position: relative;"">
                <img");
                BeginWriteAttribute("src", " src=\"", 3652, "\"", 3658, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""size: 50px;"" class=""navbar-brand"" href=""#""></img>
                <buttons class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent""
                         aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </buttons>
                <div class=""navtext collapse navbar-collapse animate__animated animate__fadeInDown"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav me-auto mb-2 mb-lg-0"">
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" style=""color: #009DE0"" href=""homepage.html"">Ana səhifə</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link active"" aria-current=""page"" style=""color: #009DE0"" href=""allrest.html"">Məkanlar</a>
                        </li>
      ");
                WriteLiteral(@"                  <li class=""nav-item"">
                            <a class=""nav-link active"" style=""color: #009DE0"" href=""campaigns.html"">Kampaniyalar</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link active"" style=""color: #009DE0"" href=""workad.html"">İş elanları</a>
                        </li>
                    </ul>
                    <div class=""navicons"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 5162, "\"", 5169, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"color: #009DE0;\"><i class=\"searchbtn fas fa-search\"></i></a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 5266, "\"", 5273, 0);
                EndWriteAttribute();
                WriteLiteral(@" style=""color: #009DE0;""><i class=""searchbtn fas fa-hashtag""></i></a>
                        <a href=""restdetail.html"" style=""color: #009DE0;""><i class=""fas fa-dice""></i></a>
                        <a href=""basketdetail.html"" style=""color: #009DE0; position: relative;"">
                            <i class=""fas fa-shopping-basket""></i>
                        </a>
                    </div>
                </div>
                <div class=""searchform"">
                    <form class=""d-flex"">
                        <input class=""form-control me-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                    </form>
                </div>
            </div>
        </nav>
    </header>
    <!--End of Top and Nav Bars-->

    <main class=""main-content"">
        ");
#nullable restore
#line 106 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </main>

    <!--Start of Footer-->
    <div class=""footer-basic bg-light"">
        <footer>
            <div class=""social"">
                <a href=""https://www.instagram.com""><i class=""icon ion-social-instagram""></i></a>
                <a href=""https://www.twitter.com""><i class=""icon ion-social-twitter""></i></a>
                <a href=""https://www.facebook.com""><i class=""icon ion-social-facebook""></i></a>
            </div>
            <ul class=""list-inline"">
                <li class=""footer-text list-inline-item"">
                    <a href=""homepage.html"">Ana səhifə</a>
                </li>
                <li class=""footer-text list-inline-item"">
                    <a href=""about.html"">Haqqımızda</a>
                </li>
                <li class=""footer-text list-inline-item""><a href=""contact.html"">Əlaqə</a></li>
            </ul>
            <p class=""copyright"">""Nə Yeyim?"" © 2021</p>
        </footer>
    </div>
    <!--End of Footer-->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script src=""https://code.jquery.com/jquery-3.6.0.min.js"" integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
<script src=""js/index.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.3/js/bootstrap.bundle.min.js""></script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.min.js"" integrity=""sha384-cVKIPhGWiC2Al4u+LWgxfKTRIcfu0JTxR+EQDz/bgldoEyl4H0zUF0QKbrJ0EcQF"" crossorigin=""anonymous""></script>
</html>");
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
