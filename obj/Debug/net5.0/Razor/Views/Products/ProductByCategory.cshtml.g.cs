#pragma checksum "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a65e430ea8716e26a029b30d6304374d51369f63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_ProductByCategory), @"mvc.1.0.view", @"/Views/Products/ProductByCategory.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a65e430ea8716e26a029b30d6304374d51369f63", @"/Views/Products/ProductByCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d94303144d0549f4c8cb56bfa29c5269067ec92c", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_ProductByCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebDauGiaGiaNguoc.Models.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Account/Login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
  
    ViewData["Title"] = "ProductByCategory";
    Layout = "~/Views/Shared/_LayoutProduct.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- SECTION -->\r\n<div class=\"section\">\r\n    <!-- container -->\r\n    <div class=\"container\">\r\n        <!-- row -->\r\n");
#nullable restore
#line 13 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
           var printedCategories = new HashSet<string>(); 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
         foreach (var item in Model)
        {
            if (!printedCategories.Contains(item.Category.CategoryName))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>");
#nullable restore
#line 19 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
   Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>");
#nullable restore
#line 19 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                                        printedCategories.Add(item.Category.CategoryName);
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 23 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-4 col-xs-6\">\r\n                    <div class=\"product\" style=\"margin-bottom:42px\">\r\n                        <div class=\"product-img\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 902, "\"", 924, 2);
            WriteAttributeValue("", 908, "..", 908, 2, true);
#nullable restore
#line 28 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
WriteAttributeValue("", 910, item.ImageUrl, 910, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 925, "\"", 931, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <div class=\"product-label\">\r\n");
#nullable restore
#line 30 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                                 if (item.CurrentPrice <= item.EddingPrice)
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"new\">\r\n                                            Đã đấu giá xong");
#nullable restore
#line 33 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                                                                  
                                }
                                else
                                {
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"new\" style=\"background-color: lawngreen; border-color: lawngreen; \">\r\n                                            Đang đấu giá");
#nullable restore
#line 38 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                                                               
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"product-body\">\r\n                    <p class=\"product-category\">");
#nullable restore
#line 43 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                                           Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <h3 class=\"product-name\"><a href=\"#\">");
#nullable restore
#line 44 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                                                    Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                    <h3 class=\"product-name\" style=\"margin:0\"><a href=\"#\">Giá khởi điểm</a></h3><del class=\"product-old-price\">");
#nullable restore
#line 45 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                                                                                                                          Write(item.StartingPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</del>\r\n");
#nullable restore
#line 46 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                     if (item.ResultBidUser == "Chưa có")
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><span>Chưa có người đấu giá</span></p>\r\n");
#nullable restore
#line 49 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><span style=\"color:deepskyblue\">");
#nullable restore
#line 52 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                                                      Write(item.ResultBidUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span><span>đã đấu giá với mức giá</span></p>\r\n");
#nullable restore
#line 53 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h4 class=\"product-price\" style=\"margin-top:10px\">");
#nullable restore
#line 54 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                                                                 Write(item.CurrentPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                </div>\r\n                <div class=\"add-to-cart\">\r\n");
#nullable restore
#line 57 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                     if (item.CurrentPrice <= item.EddingPrice)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a65e430ea8716e26a029b30d6304374d51369f6312463", async() => {
                WriteLiteral("\r\n                            <button class=\"add-to-cart-btn\" disabled><i class=\"fa fa-shopping-cart\" style=\"padding: 0 8px\"></i>Ngưng đấu giá </button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2638, "~/Products/ProductDetails?id=", 2638, 29, true);
#nullable restore
#line 59 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
AddHtmlAttributeValue("", 2667, item.ProductID, 2667, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                    }
                    else
                    {
                        if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a65e430ea8716e26a029b30d6304374d51369f6314739", async() => {
                WriteLiteral("\r\n                                <button class=\"add-to-cart-btn\"><i class=\"fa fa-shopping-cart\" style=\"padding: 0 8px\"></i>Đấu giá </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3064, "~/Products/ProductDetails?id=", 3064, 29, true);
#nullable restore
#line 67 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
AddHtmlAttributeValue("", 3093, item.ProductID, 3093, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a65e430ea8716e26a029b30d6304374d51369f6316933", async() => {
                WriteLiteral("\r\n                                <button class=\"add-to-cart-btn\"><i class=\"fa fa-shopping-cart\" style=\"padding: 0 8px\"></i>Đấu giá </button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 76 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n        <!-- /product -->\r\n");
            WriteLiteral("        <div class=\"clearfix visible-sm visible-xs\"></div>\r\n");
#nullable restore
#line 85 "C:\Users\LENOVO\OneDrive - University of Technology and Education\Workspace\N3_HK2\ECM\Eccm_Daugianguoc\WebDauGiaGiaNguoc\Views\Products\ProductByCategory.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- /product -->\r\n        </div>\r\n        <!-- /row -->\r\n    </div>\r\n    <!-- /container -->\r\n</div>\r\n<!-- /SECTION -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebDauGiaGiaNguoc.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
