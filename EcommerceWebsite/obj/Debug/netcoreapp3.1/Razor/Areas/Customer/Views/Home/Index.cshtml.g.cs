#pragma checksum "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6d67c707183cb5d071ac379d96595e1230b598d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Customer_Views_Home_Index), @"mvc.1.0.view", @"/Areas/Customer/Views/Home/Index.cshtml")]
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
#line 1 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\_ViewImports.cshtml"
using EcommerceWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
using EcommerceWebsite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
using X.PagedList.Web.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d67c707183cb5d071ac379d96595e1230b598d", @"/Areas/Customer/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29071a4697982b341fe7ab3e5bf2fdc2b951066a", @"/Areas/Customer/_ViewImports.cshtml")]
    public class Areas_Customer_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<X.PagedList.IPagedList<Products>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 5 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <div style=""background-image: url(https://images.unsplash.com/photo-1606075920560-c43aa8659a3c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1170&q=80); background-size: cover; 
        width: 100vw; position: relative; left: 50%; right: 40%; margin-left: -50vw; margin-right: -50vw; margin-bottom: 5vw"">
        <div style="" text-align: center; padding-top: 25%; padding-bottom: 25%; text-shadow: 0px 4px 3px rgba(0,0,0,0.4), 0px 8px 13px rgba(0,0,0,0.1), 0px 18px 23px rgba(0,0,0,0.1)"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-lg-12"">
                        <div id=""content"" style=""color: white"">
                            <h1>Ecommerce Website</h1>
                            <h3>My Website Project</h3>
                            <hr style=""background-color:white"">
                            <a href=""#products"" class=""btn btn-default btn-lg"" style=""color: wh");
            WriteLiteral(@"ite"" id=""shop""><i class=""fa-solid fa-money-bill""></i> Start Shopping!</a>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<h1 id=""products"">Products</h1>
<hr />
<div class=""row"">
");
#nullable restore
#line 31 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-4"">
            <div class=""card mb-4"">
                <div class=""card-header"">
                    <h4 class=""my-0 font-weight-normal"">
                        <label style=""font-size:23px;color:black; font-family: 'Courier New', monospace;"">");
#nullable restore
#line 37 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
                                                                                                     Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    </h4>\r\n                </div>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1894, "\"", 1915, 2);
            WriteAttributeValue("", 1900, "/", 1900, 1, true);
#nullable restore
#line 40 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
WriteAttributeValue("", 1901, product.Image, 1901, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" alt=""Card Image"" class=""card-img-top"" style=""height:300px"" />
                <div class=""card-header"">
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <label style=""font-size:20px;color:#a51313""><b>$");
#nullable restore
#line 44 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
                                                                       Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></label>\r\n                        </div>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d67c707183cb5d071ac379d96595e1230b598d8347", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
                                                                        WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 51 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n    ");
#nullable restore
#line 54 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
Write(Html.PagedListPager(Model, generatePageUrl: c => Href(contentPath: "~/Customer/Home/Index?page=" + c), PagedListRenderOptions.Classic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n        $(function(){\r\n            var order = \'");
#nullable restore
#line 60 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
                    Write(TempData["checkout"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
            if (order != """") {
                // Extend existing 'alert' dialog
                if (!alertify.errorAlert) {
                    //define a new errorAlert base on alert
                    alertify.dialog('errorAlert', function factory() {
                        return {
                            build: function () {
                                var errorHeader = '<span class=""fa-solid fa-circle-check"" '
                                    + 'style=""vertical-align:middle;color:#09cf02;"">'
                                    + '</span> Order Placed';
                                this.setHeader(errorHeader);
                            }
                        };
                    }, true, 'alert');
                }
                //launch it.
                // since this was transient, we can launch another instance at the same time.
                alertify
                    .errorAlert(order + ""<br/><br/><br/>"");
            }
        })
    </script>");
                WriteLiteral("\n    <script type=\"text/javascript\">\r\n        $(function(){\r\n            var save = \'");
#nullable restore
#line 85 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Customer\Views\Home\Index.cshtml"
                   Write(TempData["addcart"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"'
            if (save != """") {
                alertify.success(save);
            }
        })
    </script>
<script type=""text/javascript"">
    $(""#shop"").click(function () {
        $('html, body').animate({
            scrollTop: $(""#products"").offset().top
        }, 2000);
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<X.PagedList.IPagedList<Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
