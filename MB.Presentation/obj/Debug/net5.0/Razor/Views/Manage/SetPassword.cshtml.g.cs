#pragma checksum "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de042f0b2682ef4435e5a6a807b7e81392f2e45a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_SetPassword), @"mvc.1.0.view", @"/Views/Manage/SetPassword.cshtml")]
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
#line 1 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\_ViewImports.cshtml"
using MB.Presentation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\_ViewImports.cshtml"
using MB.Presentation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de042f0b2682ef4435e5a6a807b7e81392f2e45a", @"/Views/Manage/SetPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fbbfcdf9d35bab89d1f54e1ec1c64990294ad42", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_SetPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MB.Presentation.Models.SetPasswordViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
  
    ViewBag.Title = "Create Password";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n<p class=\"text-info\">\r\n    You do not have a local username/password for this site. Add a local\r\n    account so you can log in without an external login.\r\n</p>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
 using (Html.BeginForm("SetPassword", "Manage", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Create Local Login</h4>\r\n    <hr />\r\n");
#nullable restore
#line 18 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 20 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
   Write(Html.LabelFor(m => m.NewPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
       Write(Html.PasswordFor(m => m.NewPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 26 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
   Write(Html.LabelFor(m => m.ConfirmPassword, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
       Write(Html.PasswordFor(m => m.ConfirmPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Set password\" class=\"btn btn-default\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
}

#line default
#line hidden
#nullable disable
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 38 "C:\Users\mhyri\source\repos\Master_Bloger\MB.Presentation\Views\Manage\SetPassword.cshtml"
Write(Scripts.Render("~/bundles/jqueryval"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MB.Presentation.Models.SetPasswordViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
