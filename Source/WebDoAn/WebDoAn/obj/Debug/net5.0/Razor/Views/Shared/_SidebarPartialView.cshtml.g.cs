#pragma checksum "D:\N3CN22\Web\PTWeb\Project\WebDoAn\WebDoAn\Views\Shared\_SidebarPartialView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77d53981fa48b2eb39d15f2e6e2b65b4831bd62f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SidebarPartialView), @"mvc.1.0.view", @"/Views/Shared/_SidebarPartialView.cshtml")]
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
#line 1 "D:\N3CN22\Web\PTWeb\Project\WebDoAn\WebDoAn\Views\_ViewImports.cshtml"
using WebDoAn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\N3CN22\Web\PTWeb\Project\WebDoAn\WebDoAn\Views\_ViewImports.cshtml"
using WebDoAn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77d53981fa48b2eb39d15f2e6e2b65b4831bd62f", @"/Views/Shared/_SidebarPartialView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6362df66b2eb3808ebc9e66d35e0569f4a8e9454", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__SidebarPartialView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"menu_section active\">\r\n    <h3>General</h3>\r\n    <ul class=\"nav side-menu\"");
            BeginWriteAttribute("style", " style=\"", 86, "\"", 94, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
            WriteLiteral(@"        <li>
            <a><i class=""fa fa-table""></i> Category Management <span class=""fa fa-chevron-down""></span></a>
            <ul class=""nav child_menu"">
                <li><a href=""/admin/getallcategories"">View All Categories</a></li>
                <li><a href=""/admin/addCategory"">Add New Category</a></li>
            </ul>
        </li>
        <li>
            <a><i class=""fa fa-table""></i> San Pham Management <span class=""fa fa-chevron-down""></span></a>
            <ul class=""nav child_menu"">
                <li><a href=""/admin/getallsanpham"">View All San Pham</a></li>
                <li><a href=""/admin/addSanpham"">Add New San Pham</a></li>
            </ul>
        </li>
        <li>
            <a><i class=""fa fa-table""></i> Customer Management <span class=""fa fa-chevron-down""></span></a>
            <ul class=""nav child_menu"">
                <li><a href=""/admin/getallcustomer"">View All Customer</a></li>
");
            WriteLiteral(@"            </ul>
        </li>
        <li>
            <a><i class=""fa fa-table""></i> Hóa Đơn Management <span class=""fa fa-chevron-down""></span></a>
            <ul class=""nav child_menu"">
                <li><a href=""/admin/getallhoadon"">View All Hóa Đơn</a></li>
");
            WriteLiteral(@"            </ul>
        </li>
        <li>
            <a><i class=""fa fa-table""></i> Review Management <span class=""fa fa-chevron-down""></span></a>
            <ul class=""nav child_menu"">
                <li><a href=""/admin/getallreview"">View All Review</a></li>
");
            WriteLiteral(@"            </ul>
        </li>     
    </ul>
</div>
                                                                                                                                                                                                            
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591