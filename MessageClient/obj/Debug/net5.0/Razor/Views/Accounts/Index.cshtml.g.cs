#pragma checksum "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Accounts/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2a42516d280e54fd64f28ce132142d4eaae263b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Index), @"mvc.1.0.view", @"/Views/Accounts/Index.cshtml")]
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
#line 1 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/_ViewImports.cshtml"
using MessageClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/_ViewImports.cshtml"
using MessageClient.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Accounts/Index.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2a42516d280e54fd64f28ce132142d4eaae263b", @"/Views/Accounts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701cf33a27672f1bf3b84aa0f1e49909aebc1033", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Accounts/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Accounts/Index.cshtml"
 if (User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>Hello ");
#nullable restore
#line 9 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Accounts/Index.cshtml"
      Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</p>\n");
#nullable restore
#line 10 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Accounts/Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <a");
            BeginWriteAttribute("href", " href=\'", 146, "\'", 176, 1);
#nullable restore
#line 13 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Accounts/Index.cshtml"
WriteAttributeValue("", 153, Url.Action("Register"), 153, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Register</button></a>\n  <a");
            BeginWriteAttribute("href", " href=\'", 212, "\'", 239, 1);
#nullable restore
#line 14 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Accounts/Index.cshtml"
WriteAttributeValue("", 219, Url.Action("Login"), 219, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button>Log In</button></a>\n");
#nullable restore
#line 15 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Accounts/Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
