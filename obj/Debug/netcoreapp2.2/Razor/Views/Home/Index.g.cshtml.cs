#pragma checksum "/Users/Guest/Desktop/MessagesClient/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c861ac972bcfca5ecee0520bc2b521c488537192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/Guest/Desktop/MessagesClient/Views/_ViewImports.cshtml"
using MessagesClient;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/MessagesClient/Views/_ViewImports.cshtml"
using MessagesClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c861ac972bcfca5ecee0520bc2b521c488537192", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6414cc97f5fab9b2a9dd4f42f8271475602b36e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MessagesClient.Models.Message>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 39, true);
            WriteLiteral("\r\n<h2>All Articles</h2>\r\n<hr />\r\n<ol>\r\n");
            EndContext();
#line 6 "/Users/Guest/Desktop/MessagesClient/Views/Home/Index.cshtml"
     foreach (var message in Model)
    {

#line default
#line hidden
            BeginContext(134, 63, true);
            WriteLiteral("        <li>\r\n            <ul>\r\n                <li>MessageId: ");
            EndContext();
            BeginContext(198, 47, false);
#line 10 "/Users/Guest/Desktop/MessagesClient/Views/Home/Index.cshtml"
                          Write(Html.DisplayFor(modelItem => message.MessageId));

#line default
#line hidden
            EndContext();
            BeginContext(245, 37, true);
            WriteLiteral("</li>\r\n                <li>Username: ");
            EndContext();
            BeginContext(283, 46, false);
#line 11 "/Users/Guest/Desktop/MessagesClient/Views/Home/Index.cshtml"
                         Write(Html.DisplayFor(modelItem => message.UserName));

#line default
#line hidden
            EndContext();
            BeginContext(329, 40, true);
            WriteLiteral("</li>\r\n                <li>MessageText: ");
            EndContext();
            BeginContext(370, 49, false);
#line 12 "/Users/Guest/Desktop/MessagesClient/Views/Home/Index.cshtml"
                            Write(Html.DisplayFor(modelItem => message.MessageText));

#line default
#line hidden
            EndContext();
            BeginContext(419, 42, true);
            WriteLiteral("</li>\r\n                <li>MessageNumber: ");
            EndContext();
            BeginContext(462, 51, false);
#line 13 "/Users/Guest/Desktop/MessagesClient/Views/Home/Index.cshtml"
                              Write(Html.DisplayFor(modelItem => message.MessageNumber));

#line default
#line hidden
            EndContext();
            BeginContext(513, 40, true);
            WriteLiteral("</li>\r\n                <li>MessageNote: ");
            EndContext();
            BeginContext(554, 49, false);
#line 14 "/Users/Guest/Desktop/MessagesClient/Views/Home/Index.cshtml"
                            Write(Html.DisplayFor(modelItem => message.MessageNote));

#line default
#line hidden
            EndContext();
            BeginContext(603, 63, true);
            WriteLiteral("</li>\r\n                <hr>\r\n            </ul>\r\n        </li>\r\n");
            EndContext();
#line 18 "/Users/Guest/Desktop/MessagesClient/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(673, 5, true);
            WriteLiteral("</ol>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MessagesClient.Models.Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
