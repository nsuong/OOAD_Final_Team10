#pragma checksum "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad2f48ed55ba070cea66cb442b2f15766eb6f1e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_Details), @"mvc.1.0.view", @"/Views/NhanVien/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/NhanVien/Details.cshtml", typeof(AspNetCore.Views_NhanVien_Details))]
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
#line 1 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\_ViewImports.cshtml"
using QuanLyThuVien;

#line default
#line hidden
#line 2 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\_ViewImports.cshtml"
using QuanLyThuVien.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad2f48ed55ba070cea66cb442b2f15766eb6f1e6", @"/Views/NhanVien/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20a0cbbb9bc49e060a61bbf9750d63a1feede449", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuanLyThuVien.ViewModels.viewNhanVien>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(91, 122, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>NhanVien</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(214, 46, false);
#line 14 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IDNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(260, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(304, 42, false);
#line 17 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayFor(model => model.IDNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(346, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(390, 44, false);
#line 20 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(434, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(478, 40, false);
#line 23 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayFor(model => model.TaiKhoan));

#line default
#line hidden
            EndContext();
            BeginContext(518, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(562, 43, false);
#line 26 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(605, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(649, 39, false);
#line 29 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayFor(model => model.MatKhau));

#line default
#line hidden
            EndContext();
            BeginContext(688, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(732, 41, false);
#line 32 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(773, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(817, 37, false);
#line 35 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayFor(model => model.HoTen));

#line default
#line hidden
            EndContext();
            BeginContext(854, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(898, 44, false);
#line 38 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(942, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(986, 40, false);
#line 41 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayFor(model => model.NgaySinh));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1070, 48, false);
#line 44 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LoaiNhanVien));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 31, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n");
            EndContext();
#line 47 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
             if (Model.LoaiNhanVien == 0)
            {

#line default
#line hidden
            BeginContext(1207, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1225, 9, true);
            WriteLiteral("Quản lý\r\n");
            EndContext();
#line 50 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1249, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 51 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
             if (Model.LoaiNhanVien == 1)
            {

#line default
#line hidden
            BeginContext(1307, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1325, 10, true);
            WriteLiteral("Bán hàng\r\n");
            EndContext();
#line 54 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1350, 41, true);
            WriteLiteral("        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1392, 42, false);
#line 57 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1434, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1478, 38, false);
#line 60 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayFor(model => model.DiaChi));

#line default
#line hidden
            EndContext();
            BeginContext(1516, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1560, 47, false);
#line 63 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(1607, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1651, 43, false);
#line 66 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
       Write(Html.DisplayFor(model => model.TenChiNhanh));

#line default
#line hidden
            EndContext();
            BeginContext(1694, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1742, 62, false);
#line 71 "C:\Users\hainguyen\Desktop\QuanLyThuVien\Views\NhanVien\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.IDNhanVien }));

#line default
#line hidden
            EndContext();
            BeginContext(1804, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1812, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2dd44e548e6449e801830993b82e027", async() => {
                BeginContext(1834, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1850, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuanLyThuVien.ViewModels.viewNhanVien> Html { get; private set; }
    }
}
#pragma warning restore 1591
