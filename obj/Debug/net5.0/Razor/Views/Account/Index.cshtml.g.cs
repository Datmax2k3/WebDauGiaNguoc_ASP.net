#pragma checksum "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "384df4cc299639065e809bb44c1da453f63073eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\_ViewImports.cshtml"
using WebDauGiaGiaNguoc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\_ViewImports.cshtml"
using WebDauGiaGiaNguoc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"384df4cc299639065e809bb44c1da453f63073eb", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94303144d0549f4c8cb56bfa29c5269067ec92c", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebDauGiaGiaNguoc.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutLogin.cshtml";
    int randomNumber = ViewBag.RandomNumber ?? 1; // Sử dụng toán tử null-coalescing để cung cấp giá trị mặc định

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
 if (User.Identity.IsAuthenticated)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container"">
        <h4 style=""float:right;"">Welcome to your Profile Page or you can <a href=""/Account/Logout"">Logout</a></h4>
    </div>
    <div class=""container"">
        <div class=""card-body"">
            <div class=""d-flex flex-column align-items-center text-center"">
                <img");
            BeginWriteAttribute("src", " src=\"", 606, "\"", 677, 3);
            WriteAttributeValue("", 612, "https://bootdey.com/img/Content/avatar/avatar", 612, 45, true);
#nullable restore
#line 17 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
WriteAttributeValue("", 657, @randomNumber, 657, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 673, ".png", 673, 4, true);
            EndWriteAttribute();
            WriteLiteral(" alt=\"Admin\" class=\"rounded-circle\" width=\"150\">\r\n                <div class=\"mt-3\">\r\n");
#nullable restore
#line 19 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
                     if (Model != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4>");
#nullable restore
#line 21 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
                       Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <p>Avatar: ");
#nullable restore
#line 22 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
                              Write(randomNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                        <p class=""text-secondary mb-1"">Full Stack Developer</p>
                        <p class=""text-muted font-size-sm"">Bay Area, San Francisco, CA</p>
                        <button class=""btn btn-primary"">Follow</button>
                        <button class=""btn btn-outline-primary"">Message</button>
");
#nullable restore
#line 27 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>No user found.</p>\r\n");
#nullable restore
#line 31 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <h4 class=""mb-0"">Họ tên</h4>
                    </div>
                    <div style=""font-size:18px;"" class=""col-sm-6 text-secondary"">
                        ");
#nullable restore
#line 38 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
                   Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <h4 class=""mb-0"">Email</h4>
                    </div>
                    <div style=""font-size:18px;"" class=""col-sm-6 text-secondary"">
                        ");
#nullable restore
#line 47 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
                   Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <h4 class=""mb-0"">Số điện thoại</h4>
                    </div>
                    <div style=""font-size:18px;"" class=""col-sm-6 text-secondary"">
                        ");
#nullable restore
#line 56 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
                   Write(Model.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <h4 class=""mb-0"">Địa chỉ</h4>
                    </div>
                    <div style=""font-size:18px;"" class=""col-sm-6 text-secondary"">
                        ");
#nullable restore
#line 65 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
                   Write(Model.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <hr>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <h4 class=""mb-0"">Số tiền hiện có</h4>
                    </div>
                    <div style=""font-size:18px;"" class=""col-sm-6 text-secondary"">
                        ");
#nullable restore
#line 74 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
                   Write(Model.Balance);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <hr>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n");
#nullable restore
#line 82 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Please go to the <a href=\"/Account/Login\">Login page</a> </h1>\r\n");
#nullable restore
#line 86 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Account\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebDauGiaGiaNguoc.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
