#pragma checksum "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4be3d9cad1b238826c5d2764eaa726d6a62e328b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Details), @"mvc.1.0.view", @"/Views/Messages/Details.cshtml")]
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
#line 1 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Details.cshtml"
using MessageClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4be3d9cad1b238826c5d2764eaa726d6a62e328b", @"/Views/Messages/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701cf33a27672f1bf3b84aa0f1e49909aebc1033", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageClient.Models.Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h4>Message Details</h4>\n<hr />\n<h5>User: ");
#nullable restore
#line 6 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Details.cshtml"
     Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h5>Topic: ");
#nullable restore
#line 7 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Details.cshtml"
      Write(Topic.GetDetails(Model.TopicId).Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n<h6>");
#nullable restore
#line 8 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Details.cshtml"
Write(Model.PostDate.ToString("dddd, dd MMMM yyyy hh:mm tt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n<hr />\n<p>");
#nullable restore
#line 10 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Details.cshtml"
Write(Html.DisplayFor(model => model.MessageBody));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n\n");
#nullable restore
#line 12 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Details.cshtml"
 if(User.Identity.IsAuthenticated && User.Identity.Name == Model.Username)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <a");
            BeginWriteAttribute("href", " href=\'", 389, "\'", 457, 1);
#nullable restore
#line 14 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Details.cshtml"
WriteAttributeValue("", 396, Url.Action("Edit", "Messages", new { id = Model.MessageId }), 396, 61, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-primary\">Edit This Message</button></a>\n  <br>\n  <a");
            BeginWriteAttribute("href", " href=\'", 533, "\'", 603, 1);
#nullable restore
#line 16 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Details.cshtml"
WriteAttributeValue("", 540, Url.Action("Delete", "Messages", new { id = Model.MessageId }), 540, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-danger\">Delete This Message</button></a>\n");
#nullable restore
#line 17 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Details.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageClient.Models.Message> Html { get; private set; }
    }
}
#pragma warning restore 1591
