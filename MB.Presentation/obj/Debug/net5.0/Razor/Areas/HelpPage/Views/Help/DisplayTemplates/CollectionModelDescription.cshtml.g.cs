#pragma checksum "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\DisplayTemplates\CollectionModelDescription.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b7b6846c6eb2e14db152da2ddd890cc97d333e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_HelpPage_Views_Help_DisplayTemplates_CollectionModelDescription), @"mvc.1.0.view", @"/Areas/HelpPage/Views/Help/DisplayTemplates/CollectionModelDescription.cshtml")]
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
#line 1 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\DisplayTemplates\CollectionModelDescription.cshtml"
using MB.Presentation.Areas.HelpPage.ModelDescriptions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b7b6846c6eb2e14db152da2ddd890cc97d333e7", @"/Areas/HelpPage/Views/Help/DisplayTemplates/CollectionModelDescription.cshtml")]
    public class Areas_HelpPage_Views_Help_DisplayTemplates_CollectionModelDescription : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CollectionModelDescription>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\DisplayTemplates\CollectionModelDescription.cshtml"
 if (Model.ElementDescription is ComplexTypeModelDescription)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\DisplayTemplates\CollectionModelDescription.cshtml"
Write(Html.DisplayFor(m => m.ElementDescription));

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Areas\HelpPage\Views\Help\DisplayTemplates\CollectionModelDescription.cshtml"
                                               
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CollectionModelDescription> Html { get; private set; }
    }
}
#pragma warning restore 1591
