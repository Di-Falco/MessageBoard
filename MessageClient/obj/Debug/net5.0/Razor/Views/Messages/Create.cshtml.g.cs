#pragma checksum "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9bf75e2f8e27c0fb1a10562d745e4b38ba59551"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Create), @"mvc.1.0.view", @"/Views/Messages/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9bf75e2f8e27c0fb1a10562d745e4b38ba59551", @"/Views/Messages/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"701cf33a27672f1bf3b84aa0f1e49909aebc1033", @"/Views/_ViewImports.cshtml")]
    public class Views_Messages_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MessageClient.Models.Message>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h4>New Post</h4>\n\n");
#nullable restore
#line 9 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Create.cshtml"
Write(Html.HiddenFor(model => model.Username));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Create.cshtml"
Write(Html.HiddenFor(model => model.TopicId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Create.cshtml"
Write(Html.Label("Post Text:"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Create.cshtml"
Write(Html.TextBoxFor(model => model.MessageBody));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/difalcoa/Desktop/epicodus/MessageBoard.Solution/MessageClient/Views/Messages/Create.cshtml"
                                              
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