#pragma checksum "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc773c2e6f58858ced39a5a6118375f4b2a5749a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Header), @"mvc.1.0.view", @"/Views/Shared/Header.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc773c2e6f58858ced39a5a6118375f4b2a5749a", @"/Views/Shared/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701cf33a27672f1bf3b84aa0f1e49909aebc1033", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"jumbotron text-center\">\n  <h1>");
#nullable restore
#line 2 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
 Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n  <h2>");
#nullable restore
#line 3 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
 Write(ViewBag.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n");
#nullable restore
#line 4 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
   using (Html.BeginForm("LogOff", "Account"))
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-primary login\" value=\"Log out\" />\n");
#nullable restore
#line 7 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n<nav class=\"navbar sticky-top navbar-expand-lg justify-content-center\">\n  <a");
            BeginWriteAttribute("href", " href=\'", 303, "\'", 338, 1);
#nullable restore
#line 10 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
WriteAttributeValue("", 310, Url.Action("Index", "Home"), 310, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">Home</button></a>&ensp;\n  <a");
            BeginWriteAttribute("href", " href=\'", 400, "\'", 437, 1);
#nullable restore
#line 11 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
WriteAttributeValue("", 407, Url.Action("Index", "Topics"), 407, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">View Topics</button></a>&ensp;\n  <a");
            BeginWriteAttribute("href", " href=\'", 506, "\'", 545, 1);
#nullable restore
#line 12 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
WriteAttributeValue("", 513, Url.Action("Index", "Messages"), 513, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">View All Messages</button></a>\n</nav>");
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
