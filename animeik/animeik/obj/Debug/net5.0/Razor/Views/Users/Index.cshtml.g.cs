#pragma checksum "C:\Users\Hassan\Desktop\.Net projects\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d4ec986e70b3a62c98c618baae2ae9b243e9827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "C:\Users\Hassan\Desktop\.Net projects\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\_ViewImports.cshtml"
using animeik;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hassan\Desktop\.Net projects\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\_ViewImports.cshtml"
using animeik.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d4ec986e70b3a62c98c618baae2ae9b243e9827", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cf84c05be49bfe609698b79df22ecb03679115f", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Hassan\Desktop\.Net projects\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Users\Index.cshtml"
  
    Layout = "_Layout";
    var users = (List<User>) ViewData["users"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<div>\r\n");
#nullable restore
#line 9 "C:\Users\Hassan\Desktop\.Net projects\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Users\Index.cshtml"
     foreach (var user in users)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card\" style=\"width: 18rem; margin: 1em\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 13 "C:\Users\Hassan\Desktop\.Net projects\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Users\Index.cshtml"
                                  Write(user.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 327, "\"", 377, 2);
            WriteAttributeValue("", 334, "https://localhost:5001/anime/index/", 334, 35, true);
#nullable restore
#line 14 "C:\Users\Hassan\Desktop\.Net projects\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Users\Index.cshtml"
WriteAttributeValue("", 369, user.id, 369, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">");
#nullable restore
#line 14 "C:\Users\Hassan\Desktop\.Net projects\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Users\Index.cshtml"
                                                                                         Write(user.username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'s favorite anime</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\Hassan\Desktop\.Net projects\Project02_EF_ASP.NET_MVC\animeik\animeik\Views\Users\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
