#pragma checksum "D:\nuevaApp\Views\Personal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f2688522d8dce041cd34eb0c096654695dfd3ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Index), @"mvc.1.0.view", @"/Views/Personal/Index.cshtml")]
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
#line 1 "D:\nuevaApp\Views\_ViewImports.cshtml"
using nuevaApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nuevaApp\Views\_ViewImports.cshtml"
using nuevaApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f2688522d8dce041cd34eb0c096654695dfd3ae", @"/Views/Personal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49c48149c7a78e85fface22f56a37096e8eab6ce", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Personal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Pagina Personal</h1>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\nuevaApp\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.name,"Name : "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 4 "D:\nuevaApp\Views\Personal\Index.cshtml"
                               Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\nuevaApp\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.lastname,"LastName : "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "D:\nuevaApp\Views\Personal\Index.cshtml"
                                       Write(Model.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\nuevaApp\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.age,"Age : "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "D:\nuevaApp\Views\Personal\Index.cshtml"
                             Write(Model.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Personal> Html { get; private set; }
    }
}
#pragma warning restore 1591
