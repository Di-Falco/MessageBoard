#pragma checksum "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e369fee0d17ec54ca99c025468c01b6dda4377f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e369fee0d17ec54ca99c025468c01b6dda4377f", @"/Views/Shared/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701cf33a27672f1bf3b84aa0f1e49909aebc1033", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"navbar sticky-top navbar-expand-lg justify-content-start\">\n  &emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;&emsp;\n  <a");
            BeginWriteAttribute("href", " href=\'", 126, "\'", 161, 1);
#nullable restore
#line 3 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
WriteAttributeValue("", 133, Url.Action("Index", "Home"), 133, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-header\">Home</button></a>&ensp;\n  <a");
            BeginWriteAttribute("href", " href=\'", 222, "\'", 259, 1);
#nullable restore
#line 4 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
WriteAttributeValue("", 229, Url.Action("Index", "Topics"), 229, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-header\">View Topics</button></a>&ensp;\n  <a");
            BeginWriteAttribute("href", " href=\'", 327, "\'", 366, 1);
#nullable restore
#line 5 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
WriteAttributeValue("", 334, Url.Action("Index", "Messages"), 334, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-header\">View All Messages</button></a>\n");
#nullable restore
#line 6 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
   using (Html.BeginForm("LogOff", "Accounts"))
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" class=\"btn btn-primary login\" value=\"Log out\" />\n");
#nullable restore
#line 9 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("</nav>\n<div class=\"jumbotron text-left\">\n  <h3>");
#nullable restore
#line 12 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
 Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n  <h5>");
#nullable restore
#line 13 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Shared/Header.cshtml"
 Write(ViewBag.Subtitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n</div>");
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
