#pragma checksum "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35cf8da5d1dcec5b1bf713fe440b5fbd7cf6eae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HelpPage_Views_Help_Index), @"mvc.1.0.view", @"/Areas/HelpPage/Views/Help/Index.cshtml")]
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
#line 1 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml"
using System.Web.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml"
using System.Web.Http.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml"
using System.Web.Http.Description;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml"
using System.Collections.ObjectModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml"
using MB.Presentation.Areas.HelpPage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35cf8da5d1dcec5b1bf713fe440b5fbd7cf6eae2", @"/Areas/HelpPage/Views/Help/Index.cshtml")]
    public class Areas_HelpPage_Views_Help_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Collection<ApiDescription>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Areas/HelpPage/HelpPage.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml"
  
    ViewBag.Title = "ASP.NET Web API Help Page";

    // Group APIs by controller
    ILookup<HttpControllerDescriptor, ApiDescription> apiGroups = Model.ToLookup(api => api.ActionDescriptor.ControllerDescriptor);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35cf8da5d1dcec5b1bf713fe440b5fbd7cf6eae25219", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<header class=\"help-page\">\r\n    <div class=\"content-wrapper\">\r\n        <div class=\"float-left\">\r\n            <h1>");
#nullable restore
#line 19 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml"
           Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
        </div>
    </div>
</header>
<div id=""body"" class=""help-page"">
    <section class=""featured"">
        <div class=""content-wrapper"">
            <h2>Introduction</h2>
            <p>
                Provide a general description of your APIs here.
            </p>
        </div>
    </section>
    <section class=""content-wrapper main-content clear-fix"">
");
#nullable restore
#line 33 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml"
         foreach (var group in apiGroups)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml"
       Write(Html.DisplayFor(m => group, "ApiGroup"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\Index.cshtml"
                                                    
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </section>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Collection<ApiDescription>> Html { get; private set; }
    }
}
#pragma warning restore 1591
