#pragma checksum "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Admin\Views\Role\AssignUserRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6180985fd8623f852b43364171282514d04d7e5a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Role_AssignUserRole), @"mvc.1.0.view", @"/Areas/Admin/Views/Role/AssignUserRole.cshtml")]
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
#line 1 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Admin\Views\_ViewImports.cshtml"
using EcommerceWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Admin\Views\_ViewImports.cshtml"
using EcommerceWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6180985fd8623f852b43364171282514d04d7e5a", @"/Areas/Admin/Views/Role/AssignUserRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29071a4697982b341fe7ab3e5bf2fdc2b951066a", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Role_AssignUserRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Admin\Views\Role\AssignUserRole.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<div class=\"row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">Assign User Role</h2>\r\n    </div>\r\n");
            WriteLiteral("</div>\r\n<br />\r\n<div>\r\n    <table class=\"table table-striped border\">\r\n        <tr class=\"table-info\">\r\n            <th>\r\n                User Name\r\n            </th>\r\n            <th>\r\n                Role Name\r\n            </th>\r\n");
#nullable restore
#line 24 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Admin\Views\Role\AssignUserRole.cshtml"
             foreach (var item in ViewBag.UserRoles)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Admin\Views\Role\AssignUserRole.cshtml"
               Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Admin\Views\Role\AssignUserRole.cshtml"
               Write(item.RoleName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 33 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Admin\Views\Role\AssignUserRole.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n        <script type=\"text/javascript\">\r\n        $(function(){\r\n            var save = \'");
#nullable restore
#line 40 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                   Write(TempData["save"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if (save != \"\") {\r\n                alertify.success(save);\r\n            }\r\n        })\r\n        </script>\r\n        <script text=\"text/javascript\">\r\n        $(function () {\r\n            var deleted = \'");
#nullable restore
#line 48 "C:\Projects\ECommerceWebsite\EcommerceWebsite\EcommerceWebsite\Areas\Admin\Views\Role\AssignUserRole.cshtml"
                      Write(TempData["delete"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\'\r\n            if (deleted != \"\") {\r\n                alertify.error(deleted);\r\n            }\r\n        })\r\n        </script>\r\n    ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
