#pragma checksum "C:\Users\Lucas\Desktop\todos\Jambo_dev\Views\Shared\_Template.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c02b118443067b34da86b5cdc1e5571065dd1703"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Template), @"mvc.1.0.view", @"/Views/Shared/_Template.cshtml")]
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
#line 1 "C:\Users\Lucas\Desktop\todos\Jambo_dev\Views\_ViewImports.cshtml"
using Jambo_dev;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lucas\Desktop\todos\Jambo_dev\Views\_ViewImports.cshtml"
using Jambo_dev.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c02b118443067b34da86b5cdc1e5571065dd1703", @"/Views/Shared/_Template.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cba9b3d4cd702c91ee1004f4ad807d8617943f03", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Template : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table cellpadding=\"0\" cellspacing=\"0\" width=\"600\">\r\n    <tr>\r\n        <td>\r\n            <b>");
#nullable restore
#line 4 "C:\Users\Lucas\Desktop\todos\Jambo_dev\Views\Shared\_Template.cshtml"
          Write(Model.first_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 4 "C:\Users\Lucas\Desktop\todos\Jambo_dev\Views\Shared\_Template.cshtml"
                            Write(Model.last_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" !</b>\r\n        </td>\r\n    </tr>\r\n    <br>\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 10 "C:\Users\Lucas\Desktop\todos\Jambo_dev\Views\Shared\_Template.cshtml"
       Write(Model.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n\r\n\r\n");
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
