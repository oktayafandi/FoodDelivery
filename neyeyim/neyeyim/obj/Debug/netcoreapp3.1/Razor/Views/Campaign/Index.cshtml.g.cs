#pragma checksum "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Campaign\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ddcf20d6ebe2eaa43feee05dbae01987672e77d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Campaign_Index), @"mvc.1.0.view", @"/Views/Campaign/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ddcf20d6ebe2eaa43feee05dbae01987672e77d", @"/Views/Campaign/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb900363127bca3854ca107bde25ff7c9a2b1e4", @"/Views/_ViewImports.cshtml")]
    public class Views_Campaign_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CampaignViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<section class=\"cards animate__animated animate__fadeIn\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Campaign\Index.cshtml"
            foreach (var item in Model.Campaigns)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-12\">\r\n                    <div class=\"card\" style=\"width: 18rem;\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 349, "\"", 378, 2);
            WriteAttributeValue("", 355, "uploads/img/", 355, 12, true);
#nullable restore
#line 10 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Campaign\Index.cshtml"
WriteAttributeValue("", 367, item.Image, 367, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Campaign\Index.cshtml"
                                              Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 14 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Campaign\Index.cshtml"
                           Write(Html.Raw(item.Content));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <h2 class=\"card-title\">");
#nullable restore
#line 16 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Campaign\Index.cshtml"
                                              Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" AZN</h2>\r\n                            <a href=\"restdetail.html\" class=\"btn text-center\"\r\n                               style=\"background-color: #009de0; color: white;\">");
#nullable restore
#line 18 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Campaign\Index.cshtml"
                                                                           Write(item.Place.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 22 "C:\Users\User\Desktop\neyeyim\neyeyim\Views\Campaign\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</section>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CampaignViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
