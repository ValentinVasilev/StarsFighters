#pragma checksum "D:\Важни\1.WEB DEVELOPMENT\0.Stars Fighters - Project\StarsFighters\StarsFighters\Views\Home\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "792e9d701e2ee97238c9dd08b1562c752b26f50c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
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
#line 1 "D:\Важни\1.WEB DEVELOPMENT\0.Stars Fighters - Project\StarsFighters\StarsFighters\Views\_ViewImports.cshtml"
using StarsFighters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Важни\1.WEB DEVELOPMENT\0.Stars Fighters - Project\StarsFighters\StarsFighters\Views\_ViewImports.cshtml"
using StarsFighters.Controllers.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"792e9d701e2ee97238c9dd08b1562c752b26f50c", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cf6261e588edd0261db43abe1b292532d90c1ab", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<StarsFighters.Controllers.Models.LoggedInViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Важни\1.WEB DEVELOPMENT\0.Stars Fighters - Project\StarsFighters\StarsFighters\Views\Home\Privacy.cshtml"
  
    ViewData["Title"] = "Privacy Policy";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "D:\Важни\1.WEB DEVELOPMENT\0.Stars Fighters - Project\StarsFighters\StarsFighters\Views\Home\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<p>Our Data base has:</p>\r\n<ul>\r\n    <li>Minerals: ");
#nullable restore
#line 9 "D:\Важни\1.WEB DEVELOPMENT\0.Stars Fighters - Project\StarsFighters\StarsFighters\Views\Home\Privacy.cshtml"
             Write(Model.Minerals);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Metal: ");
#nullable restore
#line 10 "D:\Важни\1.WEB DEVELOPMENT\0.Stars Fighters - Project\StarsFighters\StarsFighters\Views\Home\Privacy.cshtml"
          Write(Model.Metal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Gas: ");
#nullable restore
#line 11 "D:\Важни\1.WEB DEVELOPMENT\0.Stars Fighters - Project\StarsFighters\StarsFighters\Views\Home\Privacy.cshtml"
        Write(Model.Gas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    <li>Gold: ");
#nullable restore
#line 12 "D:\Важни\1.WEB DEVELOPMENT\0.Stars Fighters - Project\StarsFighters\StarsFighters\Views\Home\Privacy.cshtml"
         Write(Model.StarsCredits);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n</ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<StarsFighters.Controllers.Models.LoggedInViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
